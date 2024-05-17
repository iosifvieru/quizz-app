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

        private static Register_Form registerForm;

        public Main_Menu()
        {
            InitializeComponent();            
        }

        // functie de callback pt. butonul de log in.
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBoxMainUsername.Text))
            {
                MessageBox.Show("Trebuie sa introduci un nume de utilizator.");
                return;
            }

            if (string.IsNullOrEmpty(bunifuTextBoxMainPassword.Text))
            {
                MessageBox.Show("Trebuie sa introduci o parola.");
                return;
            }

            
            string username = bunifuTextBoxMainUsername.Text.ToLower();
            string password = encrypt.Hash(bunifuTextBoxMainPassword.Text);

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

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBoxMainUsername.Text))
            {
                MessageBox.Show("Trebuie sa introduci un nume de utilizator.");
                return;
            }

            if (string.IsNullOrEmpty(bunifuTextBoxMainPassword.Text))
            {
                MessageBox.Show("Trebuie sa introduci o parola.");
                return;
            }


            string username = bunifuTextBoxMainUsername.Text.ToLower();
            string password = encrypt.Hash(bunifuTextBoxMainPassword.Text);

            User user = userController.getUser(username);
            //MessageBox.Show(password);

            if ((user.Password != password) || user == null)
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

      

        private void bunifuButtonMainInregistrare_Click(object sender, EventArgs e)
        {
            // this.Hide();

            // Register_Form register=null;
            //  register.FormClosed += (s, args) => this.Show();
            //  register.Show();


            SwitchToMainMenu();

        }
        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void SwitchToMainMenu()
        {
            if (registerForm == null)
            {
                registerForm = new Register_Form();
                registerForm.FormClosed += (s, args) => { registerForm = null; this.Show(); };
            }
            this.Hide();
            registerForm.Show();
        }
    }
}
