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
        User selectedUser;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void GetUserInfo()
        {
            var garageNumber = comboBox1.SelectedItem.ToString();
            var user = Server.GetUserInGarage(garageNumber);
            nameTextBox.Text = user.Name;
            surnameTextBox.Text = user.Surname;
            ballanceTextBox.Text = user.Balance.ToString();
            phoneTextBox.Text = user.Phone;
            birthdayTextBox.Text = user.Birthday.ToShortDateString();            

            paymentsGridView.Rows.Clear();
            int i = 0;
            foreach (var payment in user.Payments)
            {
                paymentsGridView.Rows.Add();
                paymentsGridView.Rows[i].Cells[0].Value = payment.DateTime.Date.ToShortDateString();
                paymentsGridView.Rows[i].Cells[1].Value = payment.Sum;
                i++;
            }

            i = 0;
            cardsGridView.Rows.Clear();
            foreach (var card in user.Cards)
            {
                cardsGridView.Rows.Add();
                cardsGridView.Rows[i].Cells[0].Value = card.CardId;
                i++;
            }

            var dates = user.Entrances
                .Select(en => en.EntranceDate)
                .GroupBy(dt => dt)
                .ToList()
                ;

            entrancesDataGrid.Rows.Clear();
            i = 0;
            foreach (var entrance in dates)
            {
                entrancesDataGrid.Rows.Add();
                entrancesDataGrid.Rows[i].Cells[0].Value = entrance.Key.Date.ToShortDateString();
                entrancesDataGrid.Rows[i].Cells[1].Value = entrance.Count();
                i++;
            }
        }

    }
}
