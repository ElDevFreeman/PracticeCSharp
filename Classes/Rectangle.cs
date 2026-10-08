using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Rectangle
    {
        public double Width {  get; set; }
        public double Height {  get; set; }


        public double Area { get
            { 
                return Width * Height;
            } 
            set; }
    }
}
