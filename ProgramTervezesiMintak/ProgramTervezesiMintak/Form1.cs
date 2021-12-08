using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramTervezesiMintak.Abstractions;
using ProgramTervezesiMintak.Entities;

namespace ProgramTervezesiMintak
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        Toy _nextToy;

        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set {
                _factory = value;
                DisplayNext();
            }
        }

        private void DisplayNext()
        {
            if (_nextToy != null) Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Toy t = Factory.CreateNew();
            _toys.Add(t);
            t.Left = -t.Width;
            mainPanel.Controls.Add(t);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            if (_toys.Count == 0) return;
            Toy lastToy = _toys[0];

            foreach (Toy toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > lastToy.Left) lastToy = toy;
            }

            if (lastToy.Left > 1000)
            {
                _toys.Remove(lastToy);
                mainPanel.Controls.Remove(lastToy);
            }
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory() { BallColor = btnBallColor.BackColor };
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btnBallColor_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory() {
                WrappingColor = btnPresenWrappingColor.BackColor,
                RibbonColor = btnPresentRibbonColor.BackColor
            };
        }
    }
}
