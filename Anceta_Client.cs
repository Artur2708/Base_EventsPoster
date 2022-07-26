using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Base_EventsPoster
{
    public partial class Anceta_Client : Form
    {
        public Clients clients { get; set; } = new Clients();
        public Anceta_Client()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = new DateTime(1910, 01, 01);
        }

        public Anceta_Client(Clients clients_up)
        {
            InitializeComponent();
            clients.Id = clients_up.Id;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = new DateTime(1910, 01, 01);
            textBox_Name.Text = clients_up.FirstName;
            textbox_Surname.Text = clients_up.LastName;
            textBox_Email.Text = clients_up.Email;
            dateTimePicker1.Value = clients_up.BD;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_Name.Text, "^[а-яА-Яa-zA-Z- ]+$"))
            {
                MessageBox.Show("Ошибка в заполнении поля \"Имя!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textbox_Surname.Text, "^[а-яА-Яa-zA-Z- ]+$"))
            {
                MessageBox.Show("Ошибка в заполнении поля \"Фамилия!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_Email.Text, "^[a-zA-Z0-9@.]+$"))
            {
                MessageBox.Show("Ошибка в заполнении поля \"Email!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clients.FirstName = textBox_Name.Text;
            clients.LastName = textbox_Surname.Text;
            clients.Email = textBox_Email.Text;
            clients.BD = dateTimePicker1.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
