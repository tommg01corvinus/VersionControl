using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using MNBXml.Entities;
using MNBXml.MNBServiceReference;

namespace MNBXml
{
    public partial class Form1 : Form
    {
        BindingList<RateData> _rates = new BindingList<RateData>();
        BindingList<string> _currencies = new BindingList<string>();


        public Form1()
        {
            InitializeComponent();
            loadCurrencyXml(getCurrencies());
            getCurrencies();
            cbValuta.DataSource = _currencies;
            RefreshData();
        }

        private void RefreshData()
        {
            if (cbValuta.SelectedItem == null) return;
            _rates.Clear();
            loadXml(getRates());
            dataGridView1.DataSource = _rates;
            makeChart();
        }

        private void makeChart()
        {
            chartRateData.DataSource = _rates;
            Series sorozatok = chartRateData.Series[0];
            sorozatok.ChartType = SeriesChartType.Line;
            sorozatok.XValueMember = "Date";
            sorozatok.YValueMembers = "Value";

            var jelmagyarazat = chartRateData.Legends[0];
            jelmagyarazat.Enabled = false;

            var diagramterulet = chartRateData.ChartAreas[0];
            diagramterulet.AxisY.IsStartedFromZero = false;
            diagramterulet.AxisY.MajorGrid.Enabled = false;
            diagramterulet.AxisX.MajorGrid.Enabled = false;
        }

        private void loadXml(string xmlString)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlString);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                _rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null) continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText.Replace(",", "."));
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void loadCurrencyXml(string xmlString)
        {
            _currencies.Clear();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlString);

            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                _currencies.Add(item.InnerText);
            }
        }

        private string getRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody req = new GetExchangeRatesRequestBody();
            req.currencyNames = cbValuta.SelectedItem.ToString();
            req.startDate = tolPicker.Value.ToString("yyyy-MM-dd");
            req.endDate = igPicker.Value.ToString("yyyy-MM-dd");
            var response = mnbService.GetExchangeRates(req);
            return response.GetExchangeRatesResult;
        }

        private string getCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody req = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(req);
            return response.GetCurrenciesResult;
        }

        private void paramChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
