using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Compressor
{
    public class JpegImageCompressor : IImageCompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing Image {fileName}.jpg");
        }
    }
}
