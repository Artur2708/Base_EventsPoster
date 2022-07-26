using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Base_EventsPoster
{
    public partial class Cat : Form
    {
        public Сategories cat { get; set; } = new Сategories();
        public Cat()
        {
            InitializeComponent();
        }

        public Cat(Сategories cat_)
        {
            InitializeComponent();
            cat.Id = cat_.Id;
            cat.Category = cat_.Category;
            textBox_Name.Text = cat.Category;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_Name.Text, "^[а-яА-Яa-zA-Z- ]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label1}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cat.Category = textBox_Name.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
