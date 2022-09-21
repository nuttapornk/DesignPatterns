using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Compressor
{
    public interface IImageCompressor
    {
        void Compress(string fileName);

    }
}
