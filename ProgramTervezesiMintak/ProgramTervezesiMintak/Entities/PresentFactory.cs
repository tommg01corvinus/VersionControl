using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTervezesiMintak.Abstractions;

namespace ProgramTervezesiMintak.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color WrappingColor { get; set; }
        public Color RibbonColor { get; set; }

        public Toy CreateNew()
        {
            return new Present(WrappingColor, RibbonColor);
        }
    }
}
