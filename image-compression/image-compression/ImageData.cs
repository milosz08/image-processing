using System;
using System.Drawing.Imaging;
using System.IO;

namespace ImageCompression
{
    internal class ImageData
    {
        internal string Path { get; set; }
        internal ImageFormat Extension { get; set; }
        internal string ControlName { get; set; }
        internal double CP { get; set; }
        internal double CR { get; set; }
        internal int X { get; set; }
    }

    internal class Coefficients
    {
        internal string CR { get; set; }
        internal string CP { get; set; }
    }

    internal class BaseEncoder
    {
        internal string Name { get; set; }
        internal EncoderValue Value { get; set; }
    }

    internal static class Manipulator
    {
        internal static Coefficients CalculateCrAndCp(string originalPath, string pathToOutputFile)
        {
            // pobranie ilości bajtów pliku oryginalnego
            long bytesCountOfOriginal = new FileInfo(originalPath).Length;
            // pobranie ilości bajtów pliku konwertowanego
            long bytesCountOfGenerated = new FileInfo(pathToOutputFile).Length;
            // obliczenie współczynnia CR
            double CR = Convert.ToDouble(bytesCountOfOriginal) / Convert.ToDouble(bytesCountOfGenerated);
            double CP = (1.0 - (1.0 / CR)) * 100; // na podstawie współczynnika CR, obliczenie CP
            return new Coefficients() // zwrócenie wartości w czytelnej formie
            {
                CR = Math.Round(CR, 3).ToString() + ":1",
                CP = Math.Round(CP, 3).ToString() + "%",
            };
        }
    }
}