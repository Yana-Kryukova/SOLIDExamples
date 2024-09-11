using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExamples.Example1.Figures.Good
{
    public abstract class Figure
    {
        protected Figure() 
        {
            Name = "Figure";
        }
        public Figure(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        public abstract double Area { get; }
    }
}
