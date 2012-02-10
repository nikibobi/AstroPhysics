using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AstroPhysics.ObjectEnergy;

namespace AstroPhysics.ObjectEnergy
{
    public partial class EnergyChart : Form
    {
        private const int MAX_POINTS = 30;

        //public Object PhysicalObject { get; set; }

        public EnergyChart()
        {
            InitializeComponent();
            //createSeries();
        }

        private void createSeries()
        {
            for (int i = 0; i < 3; i++)
            {
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Time;
                series.YValueType = ChartValueType.Single;
                chartEnergy.Series.Add(series);
            }

            chartEnergy.Series[0].Name = "Кинетична енергия";
            chartEnergy.Series[1].Name = "Потенцялна енергия";
            chartEnergy.Series[2].Name = "Механична енергия";
        }


        public void addSeriesValues(params float[] values)
        {
            //for (int i = 0; i < chartEnergy.Series.Count; i++)
            //{
            //    while (chartEnergy.Series[i].Points.Count > MAX_POINTS)
            //    {
            //        chartEnergy.Series[i].Points.RemoveAt(i);
            //    }
            //    chartEnergy.Series[i].Points.AddXY(DateTime.Now, values[i]);
            //}
            //chartEnergy.Series.ResumeUpdates();
        }

        private void EnergyChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
