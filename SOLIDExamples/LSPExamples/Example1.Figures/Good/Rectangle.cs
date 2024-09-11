using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExamples.Example1.Figures.Good
{
    public class Rectangle(string name, double width, double height) : Figure(name)
    {
        public double Width { get; set; } = width;
        public double Height { get; set; } = height;
        public override double Area => Width * Height;
    }
}
