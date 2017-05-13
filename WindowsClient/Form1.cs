using CarCheckpoint.Models;
using CarCheckpoint.Models.DTO;
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
    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminSettings = new Dictionary<string, string>();
        const string password = "0988905606";
        bool firstOpen = true;
        public Form1()
        {
            InitializeComponent();

            foreach (var admSetting in Server.GetAdminSettings())
                adminSettings.Add(admSetting.Name, admSetting.Value);

            serialPort1.PortName = adminSettings.FirstOrDefault(a => a.Key == AdminSettingsNames.USBPort).Value;
            serialPort1.Open();
        }

        private void cardIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cardIdTextBox.Text.Length == 10)
            {
                var cardId = cardIdTextBox.Text;
                cardIdTextBox.Text = "";
                errorLabel.Text = "";

                if (cardId == password || adminSettings.Values.Contains(cardId))
                {
                    ReactionOnCard.Admin();                    
                    return;
                }

                var user = Server.GetUser(cardId);
                if (user.User == null)
                {
                    errorLabel.Text = "Unknown person";
                }
                else
                {
                    KnownUser(user);
                    if (user.User.Balance >= 0)
                    {
                        new Action(SendCommandToArduino).BeginInvoke(null, null);                    
                    }
                }                
            }
        }


        private void SendCommandToArduino()
        {
            const int isReady = 4, end = 5;  

            if (serialPort1.IsOpen)
                serialPort1.Write("5");

            //serialPort1.DiscardInBuffer();
            //if (firstOpen)
            //{
            //    firstOpen = false;
            //    serialPort1.Close();
            //    return;
            //}

            //var answer = serialPort1.ReadChar();

            //for (int i = 0; i < 15; i++)
            //{
            //    answer = serialPort1.ReadChar();
            //    if (answer == end)
            //    {
            //        serialPort1.Close();
            //        break;
            //    }
            //    else if (answer == isReady)
            //    {
            //        serialPort1.Close();
            //        SendCommandToArduino();
            //        break;
            //    }
            //    if (i == 14)
            //    {
            //        serialPort1.Close();
            //        break;
            //    }
            //}
        }

        private void KnownUser(AllUserData user)
        {           
            nameLabel.Text = user.User.Name;
            surnameLabel.Text = user.User.Surname;
            garageLabel.Text = user.User.GarageNumber.ToString();            
            phoneLabel.Text = user.User.Phone;
            ballanceLabel.Text = user.User.Balance.ToString();
            errorLabel.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
