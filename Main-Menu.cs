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
        public Main_Menu()
        {
            InitializeComponent();

            UserController userController = new UserController();

            
        }

        // functie de callback pt. butonul de log in.
        private void LogInButton_Click(object sender, EventArgs e)
        {
            

            /*
               ** temporar.
               strict de test pt. a testa functionalitatea.
            */
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
