using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mikroszimulacio.Entities;

namespace Mikroszimulacio
{
    public partial class Form1 : Form
    {
        List<Person> Population;
        List<BirthProbability> BirthProbabilities;
        List<DeathProbability> DeathProbabilities;
        List<int> ferfiak = new List<int>();
        List<int> nok = new List<int>();

        Random rng = new Random(1234);

        public Form1()
        {
            InitializeComponent();
        }

        private void Simulation(int zaroev, string fajlnev)
        {
            ferfiak.Clear();
            nok.Clear();
            Population = GetPopulation(fajlnev);
            BirthProbabilities = GetBirthProbabilities(@"C:\tmp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\tmp\halál.csv");
            for (int year = 2005; year <= zaroev; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SzimulaciosLepes(Population[i], year);
                }

                int ferfiakszama = (from x in Population where x.Gender == Gender.MALE && x.IsAlive == true select x).Count();
                int nokszama = (from x in Population where x.Gender == Gender.FEMALE && x.IsAlive == true select x).Count();

                ferfiak.Add(ferfiakszama);
                nok.Add(nokszama);

                Console.WriteLine(string.Format("Év: {0} Férfiak: {1} Nők: {2}", year, ferfiakszama, nokszama));
            }
            DisplayResults(zaroev);
        }

        private void DisplayResults(int zaroev)
        {
            int counter = 0;
            for (int year = 2005; year <= zaroev; year++)
            {
                richTextBox1.Text += string.Format("Szimulációs év: {0}\n\tFérfiak: {1}\n\tNők: {2}\n\n", year, ferfiak[counter], nok[counter]);
                counter++;
            }
        }

        private void SzimulaciosLepes(Person person, int year)
        {
            if (!person.IsAlive) return;
            int kor = year - person.BirthYear;

            double halalvaloszinuseg = (from x in DeathProbabilities where x.Gender == person.Gender && x.Age == kor select x.P).FirstOrDefault();
            double veletlen = rng.NextDouble();
            if (veletlen <= halalvaloszinuseg) person.IsAlive = false;

            if (person.IsAlive && person.Gender == Gender.FEMALE)
            {
                double szuletesvaloszinuseg = (from x in BirthProbabilities where x.Age == kor && x.NbrOfChildren == person.NbrOfChildren select x.P).FirstOrDefault();
                veletlen = rng.NextDouble();
                if (veletlen <= szuletesvaloszinuseg)
                {
                    Person baba = new Person();
                    baba.BirthYear = year;
                    baba.NbrOfChildren = 0;
                    baba.Gender = (Gender)rng.Next(1, 3);
                    Population.Add(baba);
                    person.NbrOfChildren += 1;
                }
            }
        }

        private List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        Age = int.Parse(line[0]),
                        P = double.Parse(line[2])
                    });
                }
            }

            return deathProbabilities;
        }

        private List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }

            return birthProbabilities;
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simulation((int)numericUpDown1.Value, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) textBox1.Text = ofd.FileName;
        }
    }

}
