using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster
{
    public partial class Price_Event : Form
    {
        public Price price { get; set; } = new Price();
        public Price_Event()
        {
            InitializeComponent();
        }

        public Price_Event(Price p)
        {
            InitializeComponent();
            price.Id = p.Id;
            price.Min_ = p.Min_;
            price.Ave = p.Ave;
            price.Max_ = p.Max_;
            tb_min.Text = price.Min_.ToString();
            tb_ave.Text = p.Ave.ToString();
            tb_max.Text = p.Max_.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_min.Text, "^[0-9,]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля {label1}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tb_ave.Text, "^[0-9,]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля {label2}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tb_max.Text, "^[0-9,]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля {label3}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal min = Convert.ToDecimal(tb_min.Text);
            decimal ave = Convert.ToDecimal(tb_ave.Text);
            decimal max_ = Convert.ToDecimal(tb_max.Text);
            if(min > ave || min > max_ && ave< min || ave> max_ && max_< ave || max_ < min)
            {
                MessageBox.Show($"Ошибка в заполнении полей суммы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            price.Min_ = min;
            price.Ave = ave;
            price.Max_ = max_;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
