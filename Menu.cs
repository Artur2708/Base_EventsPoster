using System;
using System.Configuration;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Menu : Form
    {
        Event_rep event_ = new Event_rep();

        public Menu()
        {
            InitializeComponent();
            event_.Del_date();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Check_"] as Check_ == null)
            {
                if (Application.OpenForms["Admin_r"] as Admin_r == null)
                {
                    Admin_r admin = new Admin_r();
                    admin.Show();
                }
                else MessageBox.Show("Это окно уже открыто");

            }
            else MessageBox.Show("Вы выбрали зайти через пользователя");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Admin_r"] as Admin_r == null)
            {
                if(Application.OpenForms["Check_"] as Check_ == null)
                {
                    Check_ сheck_ = new Check_();
                    сheck_.Show();
                }
                else MessageBox.Show("Это окно уже открыто");

            }
            else MessageBox.Show("Вы выбрали зайти через админа");


        }

    }
}
