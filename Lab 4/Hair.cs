using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public struct Hair
    {
        public int Length { get; set; }
        public string Color { get; set; }

        public Hair(int length, string color)
        {
            Length = length;
            Color = color;
        }
    }
}
