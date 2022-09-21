using System;

namespace DesignPatterns.Strategy.Services.Image.Filter
{
    public class HighContrastImageFilter : IImageFilter
    {
        public void Processing(string fileName)
        {
            Console.WriteLine($"Processing filter image {fileName} high contract.");
        }
    }
}
