using System;
using System.Windows.Forms;

namespace Base_EventsPoster
{
    public partial class Admin_r : Form
    {
        public Admin_r()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Admin"] as Admin == null)
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ticket_Cat"] as Ticket_Cat == null)
            {
                Ticket_Cat ticket_Cat = new Ticket_Cat();
                ticket_Cat.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Arhiv"] as Arhiv == null)
            {
                Arhiv arhiv = new Arhiv();
                arhiv.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Price_red"] as Price_red == null)
            {
                Price_red arhiv = new Price_red();
                arhiv.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }
    }
}
