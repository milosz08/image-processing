using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageCompression
{
    internal partial class MainWindow : Form
    {
        private string _outputDirPath; // ścieżka do plików wynikowych
        private string _inputFilePath; // ścieżka do pliku oryginalnego
        private string[] _coefficients = { "CR", "CP" }; // współczynniki
        private Image _originalImage; // referencja do oryginalnej grafiki

        internal static readonly string OUTPUT_DIR_PATH = "converted-images";
        internal static readonly char SEP = Path.DirectorySeparatorChar;

        // dane grafik z zamienianymi formatami
        private readonly List<ImageData> imagesContainer = new List<ImageData>()
        {
            new ImageData() { Path = "gfx__png-ed.png", Extension = ImageFormat.Png, ControlName = "pngPictureBox", X = 0 },
            new ImageData() { Path = "gfx__jpeg-ed.jpeg", Extension = ImageFormat.Jpeg, ControlName = "jpegPictureBox", X = 1 },
            new ImageData() { Path = "gfx__tiff-ed.tiff", Extension = ImageFormat.Tiff, ControlName = "tiffPictureBox", X = 2 },
            new ImageData() { Path = "gfx__bmp-ed.bmp", Extension = ImageFormat.Bmp, ControlName = "bmpPictureBox", X = 3 },
            new ImageData() { Path = "gfx__gif-ed.gif", Extension = ImageFormat.Gif, ControlName = "gifPictureBox", X = 4 },
        };

        public MainWindow()
        {
            InitializeComponent();
            tiffConvertAlgCombobox.SelectedIndex = 0;
            resultsGridView.RowCount = _coefficients.Length;
            for (int i = 0; i < _coefficients.Length; i++)
            {
                resultsGridView.Rows[i].HeaderCell.Value = _coefficients[i];
            }
        }

        private void onSelectSavePathDir(object sender, EventArgs e)
        {
            DialogResult result = selectOutputDirectoryControl.ShowDialog();
            if (result != DialogResult.OK) return;
            _outputDirPath = selectOutputDirectoryControl.SelectedPath.ToString();
            Directory.CreateDirectory(_outputDirPath + SEP + OUTPUT_DIR_PATH);
            saveDirPathTextbox.Text = _outputDirPath + SEP + OUTPUT_DIR_PATH;
            if (!saveDirPathTextbox.Text.Equals(string.Empty) &&
                !imageToConvertTextbox.Text.Equals(string.Empty))
            {
                insertDataButton.Enabled = true;
            }
            insertPathButton.Enabled = false;
        }

        private void onSelectImageToConvert(object sender, EventArgs e)
        {
            DialogResult result = openInputFileImageDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string filePath = openInputFileImageDialog.FileName.ToString();
            _inputFilePath = filePath;
            imageToConvertTextbox.Text = _inputFilePath;
            if (!saveDirPathTextbox.Text.Equals(string.Empty) &&
                !imageToConvertTextbox.Text.Equals(string.Empty))
            {
                insertDataButton.Enabled = true;
            }
            selectImageButton.Enabled = false;
        }

        private void onDeleteSelectedOutputDir(object sender, EventArgs e)
        {
            saveDirPathTextbox.Text = string.Empty;
            insertDataButton.Enabled = false;
            insertPathButton.Enabled = true;
            Directory.Delete(_outputDirPath + SEP + OUTPUT_DIR_PATH, true);
        }

        private void onDeleteSelectInputImage(object sender, EventArgs e)
        {
            imageToConvertTextbox.Text = string.Empty;
            insertDataButton.Enabled = false;
            selectImageButton.Enabled = true;
        }

        private void onClearImagesData(object sender, EventArgs e)
        {
            tiffDensityAlgLabel.Text = "NONE";
            tiffConvertAlgCombobox.SelectedIndex = 0;
            jpegSelectedAlgLabel.Text = "100 %";
            qualityTrackBar.Value = 100;
            insertDataButton.Enabled = true;
            clearImageButton.Enabled = false;
            // usunięcie referencji do grafik w interfejsie użytkownika
            originalPictureBox.Image = null;
            jpegQualityPictureBox.Image = null;
            tiffAlgorithmPictureBox.Image = null;
            // usunięcie zapisanych plików z katalogu projektu
            DirectoryInfo di = new DirectoryInfo(_outputDirPath + SEP + OUTPUT_DIR_PATH);
            foreach (FileInfo file in di.GetFiles()) file.Delete();
            // usunięcie referencji do grafik w interfejsie użytkownika
            foreach (ImageData imageData in imagesContainer)
            {
                ((PictureBox)Controls[imageData.ControlName]).Image = null;
            }
            // wyczyszczenie tabeli z wynikami (CR, CP)
            for (int i = 0; i < resultsGridView.RowCount; i++)
            {
                for (int j = 0; j < resultsGridView.ColumnCount; j++)
                {
                    resultsGridView[j, i].Value = string.Empty;
                }
            }
            deleteSaveImagesPathButton.Enabled = true;
            deleteInputImagePathButton.Enabled = true;
            qualityTrackBar.Enabled = false;
            tiffConvertAlgCombobox.Enabled = false;
            jpegShowAllFormButton.Enabled = false;
            tiffShowAllFormButton.Enabled = false;
        }

        private void onChangeJpegQuality(object sender, EventArgs e)
        {
            jpegSelectedAlgLabel.Text = ((TrackBar)sender).Value.ToString() + " %";
            // zmiana jakości grafiki JPEG
            ChangeJpegQuality(qualityTrackBar.Value);
        }

        private void onChangeTiffAlgorithm(object sender, EventArgs e)
        {
            tiffDensityAlgLabel.Text = ((ComboBox)sender).Text;
            if (_inputFilePath == null) return; // jeśli ścieżka jest pusta, zakończ
            // zmiana algorytmu kompresji formatu TIFF
            ChangeTiffAlgorithm(tiffConvertAlgCombobox.SelectedItem.ToString());
        }

        private void onInsertImagesAndConvert(object sender, EventArgs e)
        {
            insertDataButton.Enabled = false;
            clearImageButton.Enabled = true;
            // usunięcie zalegających poprzednich plików w folderze aplikacji
            DirectoryInfo di = new DirectoryInfo(_outputDirPath + SEP + OUTPUT_DIR_PATH);
            foreach (FileInfo file in di.GetFiles()) file.Delete();
            // stworzenie mapy bitowej i zapisanie skonwertowanych obrazów na podstawie listy
            Bitmap bitmap = new Bitmap(_inputFilePath);
            string path = _outputDirPath + SEP + OUTPUT_DIR_PATH + SEP;
            foreach (ImageData imageData in imagesContainer)
            {
                bitmap.Save(path + imageData.Path, imageData.Extension);
            }
            bitmap.Dispose();
            // otwarcie skonwertowanych grafik i umieszczenie ich w interfejsie użytkownika
            foreach (ImageData imageData in imagesContainer)
            {
                FileStream fileStream = new FileStream(path + imageData.Path, FileMode.Open);
                ((PictureBox)Controls[imageData.ControlName]).Image = Image.FromStream(fileStream);
                fileStream.Close();
                // obliczenie i wpisanie współczynników CR i CP do interfejsu
                Coefficients coefficients = Manipulator.CalculateCrAndCp(_inputFilePath, path + imageData.Path);
                resultsGridView[imageData.X, 0].Value = coefficients.CR;
                resultsGridView[imageData.X, 1].Value = coefficients.CP;
            }
            // pobranie oryginalnej grafiki i przypisanie jej do pola w interfejsie użytkownika
            FileStream originalFileStream = new FileStream(_inputFilePath, FileMode.Open);
            _originalImage = Image.FromStream(originalFileStream);
            originalPictureBox.Image = Image.FromStream(originalFileStream);
            originalFileStream.Close();

            ChangeTiffAlgorithm("NONE"); // ustawienie kompresji TIFF na NONE
            ChangeJpegQuality(100); // ustawienie jakości JPEG na 100

            deleteSaveImagesPathButton.Enabled = false;
            deleteInputImagePathButton.Enabled = false;
            jpegShowAllFormButton.Enabled = true;
            tiffShowAllFormButton.Enabled = true;
            qualityTrackBar.Enabled = true;
            tiffConvertAlgCombobox.Enabled = true;
        }

        private void ChangeJpegQuality(int qualityPercent)
        {
            Bitmap bitmap = new Bitmap(_inputFilePath); // zapisanie do mapy bitowej
            // pobranie wartości kodeka na podstawie JPEG
            ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders()
                .Where(c => c.FormatID == ImageFormat.Jpeg.Guid).FirstOrDefault();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            long quality = Convert.ToInt64(qualityPercent); // pobranie jakości z argumentu metody
            EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, quality);
            encoderParameters.Param[0] = encoderParameter; // dodanie parametru jakości do enkodera
            // zapisanie grafiki w folderze aplikacji
            string saveToPath = _outputDirPath + SEP + OUTPUT_DIR_PATH + SEP + "gfx__jpeg-qs-dynamic-ed.jpeg";
            bitmap.Save(saveToPath, codecInfo, encoderParameters);
            bitmap.Dispose();
            // otwarcie grafiki i wczytanie do interfejsu użytkownika
            FileStream convertedFileStream = new FileStream(saveToPath, FileMode.Open);
            jpegQualityPictureBox.Image = Image.FromStream(convertedFileStream);
            convertedFileStream.Close();
            // obliczenie współczynników CR i CP oraz wpisanie ich do interfejsu użytkownika
            Coefficients coefficients = Manipulator.CalculateCrAndCp(_inputFilePath, saveToPath);
            resultsGridView[5, 0].Value = coefficients.CR;
            resultsGridView[5, 1].Value = coefficients.CP;
        }

        private void ChangeTiffAlgorithm(string algorithmName)
        {
            Bitmap bitmap = new Bitmap(_inputFilePath); // zapisanie do mapy bitowej
            // pobranie informacji i kodeku TIFF
            ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders()
                .Where(c => c.FormatID == ImageFormat.Tiff.Guid).FirstOrDefault();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            // zapisanie algorytmu kompresji na podstawie nazwy z argumentu metody
            EncoderValue encoderValue = EncoderValue.CompressionNone;
            switch (algorithmName)
            {
                case "LZW": encoderValue = EncoderValue.CompressionLZW; break;
                case "CCITT3": encoderValue = EncoderValue.CompressionCCITT3; break;
                case "CCITT4": encoderValue = EncoderValue.CompressionCCITT4; break;
                case "RLE": encoderValue = EncoderValue.CompressionRle; break;
                default: encoderValue = EncoderValue.CompressionNone; break;
            }
            EncoderParameter encoderParameter = new EncoderParameter(Encoder.Compression,
                Convert.ToInt64(encoderValue));
            encoderParameters.Param[0] = encoderParameter;
            // zapisanie grafiki w folderze aplikacji
            string saveToPath = _outputDirPath + SEP + OUTPUT_DIR_PATH + SEP + "gfx__tiff-al-dynamic-ed.jpeg";
            bitmap.Save(saveToPath, codecInfo, encoderParameters);
            bitmap.Dispose();
            // wczytanie zapisanej grafiki do interfejsu użytkownika
            FileStream convertedFileStream = new FileStream(saveToPath, FileMode.Open);
            tiffAlgorithmPictureBox.Image = Image.FromStream(convertedFileStream);
            convertedFileStream.Close();
            // obliczenie współczynników CR i CP oraz wpisanie ich do interfejsu użytkownika
            Coefficients coefficients = Manipulator.CalculateCrAndCp(_inputFilePath, saveToPath);
            resultsGridView[6, 0].Value = coefficients.CR;
            resultsGridView[6, 1].Value = coefficients.CP;
        }

        private void onShowAllJpegQualities(object sender, EventArgs e)
        {
            JpegQualitiesWindow jpegQualities = new JpegQualitiesWindow(_inputFilePath, _outputDirPath, _originalImage);
            if (Application.OpenForms["JpegQualities"] == null) jpegQualities.Show();
        }

        private void onShowAllTiffAlgorithms(object sender, EventArgs e)
        {
            TiffAlgorithmsWindow tiffAlgorithms = new TiffAlgorithmsWindow(_inputFilePath, _outputDirPath, _originalImage);
            if (Application.OpenForms["TiffAlgorithms"] == null) tiffAlgorithms.Show();
        }

        private void onOpenBigImage(object sender, EventArgs e)
        {
            string title = "Original image";
            Image sendImage;
            switch (((Button)sender).Tag.ToString())
            {
                case "png": sendImage = pngPictureBox.Image; title = "Image after PNG compression"; break;
                case "jpeg": sendImage = jpegPictureBox.Image; title = "Image after JPEG compression"; break;
                case "tiff": sendImage = tiffPictureBox.Image; title = "Image after TIFF compression"; break;
                case "bmp": sendImage = bmpPictureBox.Image; title = "Image after BMP compression"; break;
                case "gif": sendImage = gifPictureBox.Image; title = "Image after GIF compression"; break;
                case "jpegQ": sendImage = jpegQualityPictureBox.Image; title = "Image after add JPEG compression filter algorithm"; break;
                case "tiffA": sendImage = tiffAlgorithmPictureBox.Image; title = "Image after TIFF compression filter algorithm"; break;
                default: sendImage = _originalImage; break;
            }
            BigImageWindow bigImageWindow = new BigImageWindow(sendImage, title);
            bigImageWindow.Show();
        }
    }
}
