using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.BussinesLogic;

namespace WindowsClient
{
    public partial class FormAllInfo : Form
    {
        public FormAllInfo()
        {
            InitializeComponent();
        }

        private void FormAllInfo_Load(object sender, EventArgs e)
        {
            var users = Server.GetAllUsers().OrderBy(u => u.GarageNumber);
            
            int i = 0;
            foreach (var user in users)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = user.GarageNumber;
                dataGridView1.Rows[i].Cells[1].Value = user.Name;
                dataGridView1.Rows[i].Cells[2].Value = user.Surname;
                dataGridView1.Rows[i].Cells[3].Value = user.CarNumber;
                dataGridView1.Rows[i].Cells[4].Value = user.Balance;
                i++;
            }
            int width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed);
            width += dataGridView1.RowHeadersWidth;
            width += 2;
            //var y = dataGridView1.ColHeW
            dataGridView1.Width = width;
            var height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            height += dataGridView1.ColumnHeadersHeight;
            height += 2;
            dataGridView1.Height = height;
        }
    }
}
