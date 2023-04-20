using BUS;
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
    public partial class FrmSensor : Form
    {
        public FrmSensor()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSensors.DataSource = Sensors_BUS.ListSensors_BUS();
        }

        private void LoadData()
        {
            dgvSensors.DataSource = Sensors_BUS.ListSensors_BUS();

            DataGridViewColumn colStatus = new DataGridViewTextBoxColumn();
            DataGridViewColumn colUser = new DataGridViewTextBoxColumn();
            DataGridViewColumn colStart = new DataGridViewTextBoxColumn();
            DataGridViewColumn colUsed = new DataGridViewTextBoxColumn();
            DataGridViewColumn colRemain = new DataGridViewTextBoxColumn();
            
            colStatus.HeaderText = "Trạng thái";
            colUser.HeaderText = "Người dùng";
            colStart.HeaderText = "Bắt đầu";
            colUsed.HeaderText = "Đã sử dụng";
            colRemain.HeaderText = "Còn lại";
            dgvSensors.Columns["SensorID"].HeaderCell.Value = "Mã máy";
            dgvSensors.Columns["SensorName"].HeaderCell.Value = "Tên máy";
            dgvSensors.Columns["AddressIP"].HeaderCell.Value = "Địa chỉ IP";

            colStatus.Name = "Status";
            colUser.Name = "User";
            colStart.Name = "StartTime";
            colUsed.Name = "Used";
            colRemain.Name = "Remain";

            dgvSensors.Columns.Add(colStatus);
            dgvSensors.Columns.Add(colUser);
            dgvSensors.Columns.Add(colStart);
            dgvSensors.Columns.Add(colUsed);
            dgvSensors.Columns.Add(colRemain);

            dgvSensors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmSensor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
