using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Services.Image.Filter
{
    public interface IImageFilter
    {
        void Processing(string fileName);
    }
}
