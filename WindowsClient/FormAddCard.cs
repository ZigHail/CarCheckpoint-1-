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
    public partial class FormAddCard : Form
    {
        List<User> users = Server.GetAllUsers();
        public FormAddCard()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void FormAddCard_Load(object sender, EventArgs e)
        {
            var garages = users.Select(u => u.GarageNumber).OrderBy(g => g).ToArray();            
            foreach (var garage in garages)            
                garageComboBox.Items.Add(garage);            
        }

        private void garageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = users
                .FirstOrDefault(u => u.GarageNumber == (int)garageComboBox.SelectedItem);
            label1.Text = selectedUser.Name;
            label2.Text = selectedUser.Surname;
            label3.Text = selectedUser.Balance.ToString();
        }

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cardTextBox.Text.Length != 0)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Server.AddCardToUser(users
                .FirstOrDefault(u => u.GarageNumber == (int)garageComboBox.SelectedItem), 
                                cardTextBox.Text);
            MessageBox.Show(result, result, MessageBoxButtons.OK);
        }
    }
}
