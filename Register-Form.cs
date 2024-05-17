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
    public partial class Register_Form : Form
    {
        public IUserController userController = new UserController();
        public IEncrypt encrypt = new SHA256Hashing();

        private static Main_Menu mainMenuForm;
        public Register_Form()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBoxRegisterUsername.Text))
            {
                MessageBox.Show("Trebuie sa introduci un nume de utilizator.");
                return;
            }

            if (string.IsNullOrEmpty(bunifuTextBoxRegisterPassword.Text))
            {
                MessageBox.Show("Trebuie sa introduci o parola.");
                return;
            }

            // am preferat sa aleg ca username ul sa fie stocat strict lowercase
            // pt a evita situatiile in care exista username-ul "test" si "Test" 
            // iar acestea sa fie doua conturi diferite.
            string username = bunifuTextBoxRegisterUsername.Text.ToLower();
            string password = encrypt.Hash(bunifuTextBoxRegisterPassword.Text);

            User tempUser = new User(0, username, password);
            bool returnVal = userController.addUser(tempUser);

            if (returnVal == false)
            {
                MessageBox.Show("Numele de utilizator este deja folosit!");
            }
            else
            {
                MessageBox.Show("Contul a fost inregistrat!");
                // trb. facuta o tranzitie catre form-ul cu Login sau cv.
            }

        }

        private void bunifuButtonRegisterAutentificare_Click(object sender, EventArgs e)
        {
            // this.Hide();
            //  Main_Menu mainMenu = new Main_Menu();
            //  mainMenu.FormClosed += (s, args) => this.Show();
            //  mainMenu.Show();

            SwitchToMainMenu();


        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
            
        }


        private void SwitchToMainMenu()
        {
            if (mainMenuForm == null)
            {
                mainMenuForm = new Main_Menu();
                mainMenuForm.FormClosed += (s, args) => { mainMenuForm = null; this.Show(); };
            }
            this.Hide();
            mainMenuForm.Show();
        }
    }
}
