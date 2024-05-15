using proiect_ip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_ip
{
    public partial class Main_Menu : Form
    {
        IUserController userController = new UserController();
        IEncrypt encrypt = new SHA256Hashing();

        public Main_Menu()
        {
            InitializeComponent();            
        }

        // functie de callback pt. butonul de log in.
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                MessageBox.Show("Trebuie sa introduci un nume de utilizator.");
                return;
            }

            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Trebuie sa introduci o parola.");
                return;
            }

            
            string username = UsernameTextBox.Text.ToLower();
            string password = encrypt.Hash(PasswordTextBox.Text);

            User user = userController.getUser(username);
            //MessageBox.Show(password);

            if((user.Password != password) || user == null)
            {
                MessageBox.Show("Numele de utilizator sau parola sunt gresite.");
                return;
            }

            Quizz test = new Quizz();

            // daca fereasta Quizz este inchisa repare fereastra principala.
            test.FormClosed += (s, args) => this.Show();
            test.Show();

            // ascunde ferastra curenta.
            this.Hide();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            Register_Form register = new Register_Form();
            register.FormClosed += (s, args) => this.Show();
            register.Show();

            this.Hide();
        }
    }
}
