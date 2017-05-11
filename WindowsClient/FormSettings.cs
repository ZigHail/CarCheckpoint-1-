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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = Server.ChangeSettings(
                new List<AdminSettings>
                {
                    new AdminSettings{Name = AdminSettingsNames.Card1, Value = card1TextBox.Text},
                    new AdminSettings{Name = AdminSettingsNames.Card2, Value = card2TextBox.Text},
                    new AdminSettings{Name = AdminSettingsNames.Card3, Value = card3TextBox.Text},
                    new AdminSettings{Name = AdminSettingsNames.Card4, Value = card4TextBox.Text},
                    new AdminSettings{Name = AdminSettingsNames.USBPort, Value = USBPortTextBox.Text},
                }
            );
            MessageBox.Show(result, result, MessageBoxButtons.OK);

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                var settings = Server.GetAdminSettings();
                card1TextBox.Text = settings.FirstOrDefault(s => s.Name == AdminSettingsNames.Card1).Value;
                card2TextBox.Text = settings.FirstOrDefault(s => s.Name == AdminSettingsNames.Card2).Value;
                card3TextBox.Text = settings.FirstOrDefault(s => s.Name == AdminSettingsNames.Card3).Value;
                card4TextBox.Text = settings.FirstOrDefault(s => s.Name == AdminSettingsNames.Card4).Value;
                USBPortTextBox.Text = settings.FirstOrDefault(s => s.Name == AdminSettingsNames.USBPort).Value;
            }
            catch 
            {
            }
            

        }
    }
}
