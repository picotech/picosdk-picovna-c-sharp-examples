using System;
using System.Windows.Forms;
using PicoControl2;

using System.Windows.Forms.DataVisualization.Charting;

namespace PicoVNAS21LogMagGuiExample
{
    public partial class PicoVNAS21LogMag : Form
    {
        private ConnectVNA exampleVNA;

        public class ConnectVNA
        {
            public ConnectVNA()
            {
                COMRCW = new PicoVNA_2();
            }
            public PicoVNA_2 COMRCW { get; }
        }

        public PicoVNAS21LogMag()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openButton.Visible = false;
            closeButton.Visible = calButton.Visible = true;

            // Discover the instrument
            exampleVNA = new ConnectVNA();
            var discover = exampleVNA.COMRCW.FND();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {            
            closeButton.Visible = calButton.Visible = false;

            // Close the instrument and close the GUI
            var close = exampleVNA.COMRCW.CloseVNA();
            this.Close();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            calButton.Visible = false;
            getDataButton.Visible = true;

            // Load calibration, ? opens a dialog box which allows the user to load a calibration file
            var cal = exampleVNA.COMRCW.LoadCal("?");
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            getDataButton.Visible = false;
            frequencyTextBox.Visible = normalChart.Visible = true;

            // Run the sweep
            var measure = exampleVNA.COMRCW.Measure("ALL");

            // Collect data
            var getData = exampleVNA.COMRCW.GetData("S21", "logmag", 0);

            // Save measurements to memory
            var save = exampleVNA.COMRCW.SaveToMem("S21");

            frequencyTextBox.AppendText(getData);
            frequencyTextBox.AppendText("\n");

            // Split the measurement into a list of strings
            string[] Split = getData.Split(',');
            int splitLength = Split.Length;

            double[] freq = new double[splitLength / 2];
            double[] data = new double[splitLength / 2];

            // Convert this list of strings into two seperate double arrays for Frequency and for Data
            for (int i = 0; i < splitLength / 2; i++)
            {
                freq[i] = Convert.ToDouble(Split[2 * i]);
                data[i] = Convert.ToDouble(Split[(2 * i) + 1]);
            }

            // Create a chart to plot the data against its frequency
            normalChart.Series.Add("VNAData");
            normalChart.Series["VNAData"].ChartType = SeriesChartType.Line;
            normalChart.Series["VNAData"].ChartArea = "ChartArea1";

            for (int i = 0; i < splitLength / 2; i++)
            {
                normalChart.Series["VNAData"].Points.AddXY(freq[i], data[i]);
            }
        }
    }
}