using Base_EventsPoster.Repos;
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
    public partial class Price_red : Form
    {
        Price_rep price = new Price_rep();
        public Price_red()
        {
            InitializeComponent();
            price.All(listView_Price);
        }
        public Price_red(int id_event)
        {
            InitializeComponent();
            stp_Price_Event__Result event__Result = price.id(id_event);
            listView_Price.Items.Add(new ListViewItem(new[] { event__Result.Id.ToString(), Math.Round((decimal)event__Result.Min_, 2).ToString(), Math.Round((decimal)event__Result.Ave, 2).ToString(), Math.Round((decimal)event__Result.Max_, 2).ToString() }));
        }

        private void ts_add_Click(object sender, EventArgs e) => price.Add(listView_Price);

        private void ts_update_Click(object sender, EventArgs e) => price.Update(listView_Price);

        private void ts_delete_Click(object sender, EventArgs e) => price.Delete(listView_Price);

        private void renew_Click(object sender, EventArgs e)
        {
            listView_Price.Items.Clear();
            price.All(listView_Price);
        }

        private void tb_Id_TextChanged(object sender, EventArgs e)
        {
            if (tb_Id.Text != "")
            {
                if (!Regex.IsMatch(tb_Id.Text, "^[0-9:]+$"))
                {
                    MessageBox.Show($"Ошибка в заполнении поля \"Название!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                price.GetById(Convert.ToInt32(tb_Id.Text), listView_Price);
            }
            else price.All(listView_Price);
        }

        private void listView_Price_ColumnClick(object sender, ColumnClickEventArgs e) => price.OrderBy_List(e, listView_Price);

    }
}
