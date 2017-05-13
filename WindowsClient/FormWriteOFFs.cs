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
    public partial class FormWriteOFFs : Form
    {
        public FormWriteOFFs()
        {
            InitializeComponent();
        }

        private void FormWriteOFFs_Load(object sender, EventArgs e)
        {
            var writeOffs = Server.GetAllWriteOff();

            int i = 0;
            foreach (var writeOff in writeOffs)
            {
                writeOffGridView.Rows.Add();
                writeOffGridView.Rows[i].Cells[0].Value = writeOff.DateTime;
                writeOffGridView.Rows[i].Cells[1].Value = writeOff.Sum;
                i++;
            }
        }
    }
}
