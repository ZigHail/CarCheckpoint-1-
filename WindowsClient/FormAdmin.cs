using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class FormAdmin : Form
    {
        public FormAdmin() => InitializeComponent();        

        private void addUserButton_Click(object sender, EventArgs e) =>
            new FormAddUser().ShowDialog();

        private void SettingsButton_Click(object sender, EventArgs e) =>
            new FormSettings().ShowDialog();

        private void addCardButton_Click(object sender, EventArgs e) =>
            new FormAddCard().ShowDialog();

        private void writeOffButton_Click(object sender, EventArgs e) =>
            new FormAddWriteOff().ShowDialog();

        private void payButton_Click(object sender, EventArgs e) =>
            new FormAddPay().ShowDialog();

        private void allInfoButton_Click(object sender, EventArgs e) =>
            new FormAllInfo().ShowDialog();

        private void oneUserInfoButton_Click(object sender, EventArgs e) =>
            new FormInfoAboutOne().ShowDialog();

        private void writeOffsButton_Click(object sender, EventArgs e) =>
            new FormWriteOFFs().ShowDialog();
    }
}
