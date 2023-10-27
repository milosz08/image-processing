using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageCompression
{
    internal partial class TiffAlgorithmsWindow : Form
    {
        // możliwe algorytmy kompresji TIFF
        private readonly List<BaseEncoder> _tiffAlgorithms = new List<BaseEncoder> {
            new BaseEncoder() { Name = "NONE", Value = EncoderValue.CompressionNone },
            new BaseEncoder() { Name = "LZW", Value = EncoderValue.CompressionLZW },
            new BaseEncoder() { Name = "CCITT3", Value = EncoderValue.CompressionCCITT3 },
            new BaseEncoder() { Name = "CCITT4", Value = EncoderValue.CompressionCCITT4 },
            new BaseEncoder() {Name =  "RLE", Value = EncoderValue.CompressionRle },
        };

        private readonly string _inputFilePath;
        private readonly string _outputDirPath;
        private readonly Image _originalImage;

        internal TiffAlgorithmsWindow(string inputFilePath, string outputDirPath, Image originalImage)
        {
            InitializeComponent();
            _inputFilePath = inputFilePath;
            _outputDirPath = outputDirPath;
            _originalImage = originalImage;
            LoadGraphics();
        }

        private void LoadGraphics()
        {
            originalPictureBox.Image = _originalImage;
            foreach (BaseEncoder algorithm in _tiffAlgorithms) // przejdź przez wszystkie algorytmy
            {
                Bitmap bitmap = new Bitmap(_inputFilePath); // zapisanie do mapy bitowej
                // pobranie informacji i kodeku TIFF
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders()
                    .Where(c => c.FormatID == ImageFormat.Tiff.Guid).FirstOrDefault();
                // stworzenie parametru enkodera na podstawie iterowanego algorytmu
                EncoderParameters encoderParameters = new EncoderParameters(1);
                EncoderParameter encoderParameter = new EncoderParameter(Encoder.Compression,
                    Convert.ToInt64(algorithm.Value));
                encoderParameters.Param[0] = encoderParameter;
                // zapisanie grafiki w folderze aplikacji
                string saveToPath = _outputDirPath + MainWindow.SEP + MainWindow.OUTPUT_DIR_PATH +
                    MainWindow.SEP + "gfx__tiff-" + algorithm.Name.ToLower() + "-ed.jpeg";
                bitmap.Save(saveToPath, codecInfo, encoderParameters);
                bitmap.Dispose();
                // wczytanie zapisanej grafiki do interfejsu użytkownika
                FileStream convertedFileStream = new FileStream(saveToPath, FileMode.Open);
                ((PictureBox)Controls["tiffAlg" + algorithm.Name + "PictureBox"]).Image = Image.FromStream(convertedFileStream);
                convertedFileStream.Close();
                // obliczenie współczynników CR i CP oraz wpisanie ich do interfejsu użytkownika
                Coefficients coefficients = Manipulator.CalculateCrAndCp(_inputFilePath, saveToPath);
                ((Label)Controls["tiffAlg" + algorithm.Name + "CRLabel"]).Text = "CR: " + coefficients.CR;
                ((Label)Controls["tiffAlg" + algorithm.Name + "CPLabel"]).Text = "CP: " + coefficients.CP;
            }
        }

        private void onOpenBigImage(object sender, EventArgs e)
        {
            string title = "Original image";
            Image sendImage;
            switch (((Button)sender).Tag.ToString())
            {
                case "lzw": sendImage = tiffAlgLZWPictureBox.Image; title = "Image after LZW conversion"; break;
                case "ccitt3": sendImage = tiffAlgCCITT3PictureBox.Image; title = "Image after CCITT3 conversion"; break;
                case "ccitt4": sendImage = tiffAlgCCITT4PictureBox.Image; title = "Image after CCITT4 conversion"; break;
                case "lre": sendImage = tiffAlgRLEPictureBox.Image; title = "Image after LRE conversion"; break;
                case "none": sendImage = tiffAlgNONEPictureBox.Image; title = "Image after NONE conversion"; break;
                default: sendImage = _originalImage; break;
            }
            BigImageWindow bigImageWindow = new BigImageWindow(sendImage, title);
            bigImageWindow.Show();
        }
    }
}
