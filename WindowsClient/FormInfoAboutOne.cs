using CarCheckpoint.Models;
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
    public partial class FormInfoAboutOne : Form
    {
        List<User> users = Server.GetAllUsers();
        public FormInfoAboutOne()
        {
            InitializeComponent();
        }

        private void FormInfoAboutOne_Load(object sender, EventArgs e)
        {
            var garages = users.Select(u => u.GarageNumber).OrderBy(g => g).ToArray();
            foreach (var garage in garages)
                comboBox1.Items.Add(garage);
        }
    }
}
