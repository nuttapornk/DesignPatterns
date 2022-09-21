using DesignPatterns.Strategy.Services;
using DesignPatterns.Strategy.Services.Image.Compressor;
using DesignPatterns.Strategy.Services.Image.Filter;
using DesignPatterns.Strategy.Services.Image.Storage;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            string image1 = "rabbit1";
            IImageCompressor imageCompressor = new JpegImageCompressor();
            IImageFilter imageFilter = new HighContrastImageFilter();
            ImageStorage imageStorage = new CloudImageStorage(imageCompressor, imageFilter);

            imageStorage.Store(image1);
            
            //ImageStorage imageStorage = new CloudImageStorage(new JpegImageCompressor(), new BlackWhiteImageFilter());
            //imageStorage.Store(image1);


        }
    }

}