using DesignPatterns.Strategy.Services.Image.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Filter
{
    public class BlackWhiteImageFilter : IImageFilter
    {
        public void Processing(string fileName)
        {
            Console.WriteLine($"Processing filter image {fileName} black and white.");
        }
    }
}
