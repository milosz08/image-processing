using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageCompression
{
    internal partial class JpegQualitiesWindow : Form
    {

        private readonly long[] _qualityStages = { 5L, 25L, 50L, 100L };
        private readonly string _inputFilePath;
        private readonly string _outputDirPath;
        private readonly Image _originalImage;

        internal JpegQualitiesWindow(string inputFilePath, string outputDirPath, Image originalImage)
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
            foreach (int qualityStage in _qualityStages) // przejście przez wszystkie poziomy jakości
            {
                Bitmap bitmap = new Bitmap(_inputFilePath); // zapisanie do mapy bitowej
                // pobranie wartości kodeka na podstawie JPEG
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders()
                    .Where(c => c.FormatID == ImageFormat.Jpeg.Guid).FirstOrDefault();
                EncoderParameters encoderParameters = new EncoderParameters(1);
                EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, qualityStage);
                encoderParameters.Param[0] = encoderParameter; // dodanie parametru jakości do enkodera
                // zapisanie grafiki w folderze aplikacji
                string saveToPath = _outputDirPath + MainWindow.SEP + MainWindow.OUTPUT_DIR_PATH +
                    MainWindow.SEP + "gfx__jpeg-qs-" + qualityStage + "-ed.jpeg";
                bitmap.Save(saveToPath, codecInfo, encoderParameters);
                bitmap.Dispose();
                // wczytanie zapisanej grafiki do interfejsu użytkownika
                FileStream convertedFileStream = new FileStream(saveToPath, FileMode.Open);
                ((PictureBox)Controls["jpegQuality" + qualityStage + "PictureBox"]).Image = Image.FromStream(convertedFileStream);
                convertedFileStream.Close();
                // obliczenie współczynników CR i CP oraz wpisanie ich do interfejsu użytkownika
                Coefficients coefficients = Manipulator.CalculateCrAndCp(_inputFilePath, saveToPath);
                ((Label)Controls["jpegQuality" + qualityStage + "CRLabel"]).Text = "CR: " + coefficients.CR;
                ((Label)Controls["jpegQuality" + qualityStage + "CPLabel"]).Text = "CP: " + coefficients.CP;
            }
        }

        private void onOpenBigImage(object sender, System.EventArgs e)
        {
            string title = "Original image";
            Image sendImage;
            switch (((Button)sender).Tag.ToString())
            {
                case "5": sendImage = jpegQuality5PictureBox.Image; title = "Image after keeping 5% of original"; break;
                case "25": sendImage = jpegQuality25PictureBox.Image; title = "Image after keeping 25% original"; break;
                case "50": sendImage = jpegQuality50PictureBox.Image; title = "Image after keeping 50% original"; break;
                case "100": sendImage = jpegQuality100PictureBox.Image; title = "Image after keeping 100% original"; break;
                default: sendImage = _originalImage; break;
            }
            BigImageWindow bigImageWindow = new BigImageWindow(sendImage, title);
            bigImageWindow.Show();
        }
    }
}
