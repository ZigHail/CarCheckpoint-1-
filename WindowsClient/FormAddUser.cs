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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var resutl = Server.AddUser(
                new User
                {
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text,
                    Birthday = Convert.ToDateTime(birthdayTextBox.Text),
                    CarNumber = carTextBox.Text,
                    GarageNumber = (int)garageTextBox.Value,
                    HomeAdress = homeTextBox.Text,
                    Phone = phoneTextBox.Text
                },
                cardTextBox.Text
            );
            if (resutl == "OK")
                resutl = "Sucssess!";
            MessageBox.Show(resutl, resutl, MessageBoxButtons.OK);
        }
    }
}
