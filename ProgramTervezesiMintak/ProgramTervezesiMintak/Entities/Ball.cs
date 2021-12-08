﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramTervezesiMintak.Abstractions;

namespace ProgramTervezesiMintak.Entities
{
    public class Ball: Toy
    {
        public SolidBrush BallBrush { get; private set; }

        public Ball(Color color)
        {
            BallBrush = new SolidBrush(color);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallBrush, 0, 0, Width, Height);
        }
    }
}
