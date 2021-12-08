using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramTervezesiMintak.Abstractions;

namespace ProgramTervezesiMintak.Entities
{
    public class Present : Toy
    {
        public SolidBrush WrappingBrush { get; private set; }
        public SolidBrush RibbonBrush { get; private set; }
        private int ribbonWidth = 10;

        public Present(Color wrappingColor, Color ribbonColor)
        {
            WrappingBrush = new SolidBrush(wrappingColor);
            RibbonBrush = new SolidBrush(ribbonColor);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(WrappingBrush, 0, 0, Width, Height);
            g.FillRectangle(RibbonBrush, Width / 2 - ribbonWidth / 2, 0, ribbonWidth, Height);
            g.FillRectangle(RibbonBrush, 0, Height / 2 - ribbonWidth / 2, Width, ribbonWidth);
        }
    }
}
