using DesignPatterns.Strategy.Services.Image.Compressor;
using DesignPatterns.Strategy.Services.Image.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Storage
{
    public abstract class ImageStorage
    {
        protected readonly IImageCompressor _compressor;
        protected readonly IImageFilter _filter;
        public ImageStorage(IImageCompressor compressor,IImageFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public abstract void Store(string fileName);
    }
}
