using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUNet_Management_Application.Forms
{
    public partial class FrmStatistical : Form
    {
        public FrmStatistical()
        {
            InitializeComponent();
            FrmMain.isSensorForm = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFrom_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void lbTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }

        private void LoadStat()
        {
            string timeStart = dtpFrom.Value.ToString("yyyy-MM-dd HH:mm");
            string timeEnd = dtpTo.Value.ToString("yyyy-MM-dd HH:mm");

            string time = $"{timeStart} - {timeEnd}";
            int serviceDF = int.Parse(BUS.Stat_BUS.TotalDFService(timeStart, timeEnd));
            int serviceM = int.Parse(BUS.Stat_BUS.TotalMService(timeStart, timeEnd));
            int serviceTotal = serviceDF + serviceM;

            lwDataList.Items.Clear();
            string[] row = { time, serviceDF.ToString(), serviceM.ToString(), serviceTotal.ToString() };
            var lwi = new ListViewItem(row);
            lwDataList.Items.Add(lwi);

            double rateDF = 0;
            double rateM = 0;
            if (serviceTotal > 0)
            {
                rateDF = (double)serviceDF / serviceTotal * 100;
                rateM = (double)serviceM / serviceTotal * 100;
            }
            
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["stat"].Points.AddXY("Ăn uống", $"{rateDF}");
            chart1.Series["stat"].Points.AddXY("Nạp tiền", $"{rateM}");
            
        }

        private void FrmStatistical_Load(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void lwDataList_SizeChanged(object sender, EventArgs e)
        {
            foreach (ColumnHeader column in lwDataList.Columns)
            {
                column.Width = lwDataList.Width / lwDataList.Columns.Count;
            }
        }
    }
}
