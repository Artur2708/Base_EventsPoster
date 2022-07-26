using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Check_ : Form
    {
        Client_rep client_ = new Client_rep();
        string email;
        public Check_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_Email.Text, "^[a-zA-Z0-9@.]+$"))
            {
                MessageBox.Show("Ошибка в заполнении поля \"Email!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Email.Text != "")
            {
                ListView n = new ListView();
                client_.GetByEmail(textBox_Email.Text, n);
                if (n.Items.Count > 0)
                {
                    email = textBox_Email.Text;
                    Close();
                    Client_info client_Info = new Client_info(email);
                    client_Info.ShowDialog();
                }
            }
            else MessageBox.Show($"Вы не ввели свой Email!","Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)=> Close();


        private void button3_Click(object sender, EventArgs e)
        {
            ListView n = new ListView();
            client_.Add(n);
        }
            
        
    }
}
