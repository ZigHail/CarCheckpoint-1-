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
    public partial class FormAddWriteOff : Form
    {
        public FormAddWriteOff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Server.WriteOff((int)numericUpDown1.Value);
            MessageBox.Show(result, result, MessageBoxButtons.OK);
        }
    }
}
