using DesignPatterns.Strategy.Services.Image.Compressor;
using DesignPatterns.Strategy.Services.Image.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Storage
{
    public class CloudImageStorage : ImageStorage
    {
        public CloudImageStorage(IImageCompressor compressor, IImageFilter filter) : base(compressor, filter)
        {
        }

        public override void Store(string fileName)
        {
            if (_compressor != null)
            {
                _compressor.Compress(fileName);
            }
            if (_filter != null)
            {
                _filter.Processing(fileName);
            }
            Console.WriteLine($"Store image {fileName} on cloud.");
        }
    }
}
