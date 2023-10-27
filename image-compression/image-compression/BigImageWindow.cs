using System.Drawing;
using System.Windows.Forms;

namespace ImageCompression
{
    internal partial class BigImageWindow : Form
    {
        private readonly Image _image;
        private readonly string _title;

        internal BigImageWindow(Image image, string title)
        {
            InitializeComponent();
            _image = image;
            _title = title;
        }

        private void onLoadImageContainer(object sender, System.EventArgs e)
        {
            Text = _title;
            bigImagePictureBox.Image = _image;
        }
    }
}
