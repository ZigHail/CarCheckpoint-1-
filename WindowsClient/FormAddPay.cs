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
    public partial class FormAddPay : Form
    {
        List<User> users = Server.GetAllUsers();
        User selectedUser;
        public FormAddPay()
        {
            InitializeComponent();
        }

        private void FormAddPay_Load(object sender, EventArgs e)
        {
            foreach (var user in users.OrderBy(u => u.GarageNumber)) 
            {
                garageComboBox.Items.Add(user.GarageNumber.ToString());
            }            
        }

        private void garageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = users.FirstOrDefault(u => u.GarageNumber.ToString() == garageComboBox.SelectedItem.ToString());
            label5.Text = selectedUser.Name;
            label6.Text = selectedUser.Surname;
            label7.Text = selectedUser.Balance.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = Server.Pay(selectedUser, Convert.ToInt32(moneyTextBox.Text));
            MessageBox.Show(result, result, MessageBoxButtons.OK);
        }
    }
}
