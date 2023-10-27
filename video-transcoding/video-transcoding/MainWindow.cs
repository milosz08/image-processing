using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VideoTranscoding
{
    internal partial class MainWindow : Form
    {
        private string _inputFileName; // nazwa wczytywanego pliku
        private static readonly char SEP = Path.DirectorySeparatorChar;

        internal MainWindow()
        {
            InitializeComponent();
            videoCodecCombobox.SelectedIndex = 0;
            audioCodecCombobox.SelectedIndex = 0;
        }

        private void onSelectPathToVideoFile(object sender, EventArgs e)
        {
            // procedura otwierania okna do wczytania ścieżki do pliku
            if (openVideoFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("You must pick the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EnableConvertButton();
            selectVideoFileTextbox.Text = openVideoFileDialog.FileName;
            _inputFileName = Path.GetFileName(openVideoFileDialog.FileName);
            selectVideoFileButton.Enabled = false;
            deleteVideoFileButton.Enabled = true;
        }

        private void onDeletePathForVideoFile(object sender, EventArgs e)
        {
            selectVideoFileButton.Enabled = true;
            deleteVideoFileButton.Enabled = false;
            convertAndSaveToFileButton.Enabled = false;
            selectVideoFileTextbox.Text = string.Empty;
        }

        private void onSelectPathForOutputVideoFile(object sender, EventArgs e)
        {
            // procedura otwierania okna do wczytania ścieżki do katalogu wynikowego
            if (openOutputDirDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("You must pick the path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EnableConvertButton();
            selectOutputVideoFileTextbox.Text = openOutputDirDialog.SelectedPath;
            selectOutputVideoFileButton.Enabled = false;
            deleteOutputVideoFileButton.Enabled = true;
        }

        private void onDeletePathForOutputVideoFile(object sender, EventArgs e)
        {
            selectOutputVideoFileButton.Enabled = true;
            deleteOutputVideoFileButton.Enabled = false;
            convertAndSaveToFileButton.Enabled = false;
            selectOutputVideoFileTextbox.Text = string.Empty;
        }

        private void onSelectVlcExecutablePath(object sender, EventArgs e)
        {
            // procedura otwierania okna do wczytania pliku wykonywalnego exe VLC
            if (openVlcExecutableFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("You must pick the path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EnableConvertButton();
            vlcExecutablePathTextbox.Text = openVlcExecutableFileDialog.FileName;
            selectVlcExecutableButton.Enabled = false;
            removeVlcExecutableButton.Enabled = true;
        }

        private void onDeleteVlcExecutablePath(object sender, EventArgs e)
        {
            selectVlcExecutableButton.Enabled = true;
            removeVlcExecutableButton.Enabled = false;
            convertAndSaveToFileButton.Enabled = false;
            vlcExecutablePathTextbox.Text = string.Empty;
        }

        private void onConvertAndSaveToFile(object sender, EventArgs e)
        {
            // pobranie nazwy pliku oryginalnego, usunięcie rozszerzenia i dodanie .mp4
            string targetFile = _inputFileName.Remove(_inputFileName.LastIndexOf('.')) + "__conv.mp4";
            // utworzenie komendy zgodnie z instrukcją zamieszczoną w przebiegu ćwiczenia
            string command =
                "\"" + selectVideoFileTextbox.Text + "\"" +
                " --sout=#transcode{" +
                    "vcodec=" + videoCodecCombobox.SelectedItem.ToString() +
                    ",vb=" + videoBitrateNumericbox.Value.ToString() +
                    ",fps=" + framesPerSecondNumericbox.Value.ToString() +
                    ",acodec=" + audioCodecCombobox.Text +
                    ",ab=" + audioBitrateNumericbox.Value.ToString() +
                    ",width=" + widthResNumericbox.Value.ToString() +
                    ",height=" + heightResNumericbox.Value.ToString() +
                    ",channels=2,deinterlance" +
                "}:standard{" +
                    "access=file" +
                    ",mux=ts" +
                    ",dst=" + "\"" + selectOutputVideoFileTextbox.Text + SEP + targetFile + "\"" +
                "}";

            ProcessStartInfo process = new ProcessStartInfo(); // stworzenie nowego procesu
            process.WindowStyle = ProcessWindowStyle.Hidden; // ustawienie procesu na ukryty
            process.FileName = vlcExecutablePathTextbox.Text; // pobranie ścieżki do procesu
            process.Arguments = command + " vlc://quit"; // dodanie utworzonej komendy do procesu

            convertAndSaveToFileButton.Enabled = false;
            Process executable = Process.Start(process); // uruchomienie procesu w trybie blokującym
            executable.WaitForExit(); // blokowanie programu aż do zakończenia procesu transkodowania
            convertAndSaveToFileButton.Enabled = true;
        }

        private void EnableConvertButton()
        {
            if (selectVideoFileTextbox.Text != string.Empty
                || selectOutputVideoFileTextbox.Text != string.Empty
                || vlcExecutablePathTextbox.Text != string.Empty)
            {
                convertAndSaveToFileButton.Enabled = true;
            }
            else convertAndSaveToFileButton.Enabled = false;
        }
    }
}
