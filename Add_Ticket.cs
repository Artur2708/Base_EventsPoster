using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Add_Ticket : Form
    {
        public Clients_Event_ ticket_ { get; set; } = new Clients_Event_();
        Event_rep ev = new Event_rep();
        Client_rep cl = new Client_rep();
        Price_rep pr = new Price_rep();

        public Add_Ticket()
        {
            InitializeComponent();
            ticket_.Event_id = 0;
            ticket_.Client_Id = 0;
            cl.All(listView_Client);
            ev.All_for_ticket(listView_Event);
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        public Add_Ticket(Clients_Event_ clients_Event_)
        {
            InitializeComponent();
            ticket_.Event_id = clients_Event_.Event_id;
            ticket_.Client_Id = clients_Event_.Client_Id;
            ticket_.Price = clients_Event_.Price;
            ticket_.Purchase_date = clients_Event_.Purchase_date;
            label_Client.Text = ticket_.Client_Id.ToString();
            label_Event.Text = ticket_.Event_id.ToString();
            maskedTextBox2.Text = ticket_.Client_Id.ToString();
            maskedTextBox1.Text = ticket_.Event_id.ToString();
            dateTimePicker1.Value = ticket_.Purchase_date;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        public Add_Ticket(int Event_Id, int Client_Id)
        {
            InitializeComponent();
            ticket_.Event_id = Event_Id;
            ticket_.Client_Id = Client_Id;
            label_Client.Text = Client_Id.ToString();
            label_Event.Text = Event_Id.ToString();
            buttonAdd.Text = "Купить";
            maskedTextBox2.Text = label_Client.Text;
            maskedTextBox1.Text = label_Event.Text;
            dateTimePicker1.Value = DateTime.Now;
            listView_Event.Columns[0].Width = 0;
            listView_Client.Columns[0].Width = 0;
            dateTimePicker1.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            label1.Visible = false;
            label_Event.Visible = false;
            label2.Visible = false;
            label_Client.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Point x = new Point(100,16);
            listView_Event.Location = new Point(100,16);
            listView_Client.Location = new Point(100, 127);
            listView_Event.ColumnClick -= listView_Event_ColumnClick;
            listView_Client.ColumnClick -= listView_Client_ColumnClick;
            listView_Event.Items[0].Selected = true;
            listView_Event.Select();
            stp_Price_Event__Result p = pr.id(Convert.ToInt32(listView_Event.Items[0].Text));
            checkedListBox1.Items.Add(Math.Round((decimal)p.Min_,2), false);
            checkedListBox1.Items.Add(Math.Round((decimal)p.Ave,2), false);
            checkedListBox1.Items.Add(Math.Round((decimal)p.Max_, 2), false);
            listView_Event.Items[0].Selected = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(ticket_.Event_id != 0 && ticket_ .Client_Id != 0 && checkedListBox1.CheckedItems.Count > 0)
            {
                ticket_.Purchase_date = dateTimePicker1.Value;
                ticket_.Price = Convert.ToDecimal(checkedListBox1.CheckedItems[0].ToString());
                
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show($"Ошибка в заполнении полей \"!\"{label1} или {label2}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listView_Event_Click(object sender, EventArgs e)
        {
            if (listView_Event.SelectedItems.Count > 0)
            {
                checkedListBox1.Items.Clear();
                ticket_.Event_id = Convert.ToInt32(listView_Event.SelectedItems[0].Text);
                label_Event.Text = "ID = " + listView_Event.SelectedItems[0].Text;
                stp_Price_Event__Result p =  pr.id(Convert.ToInt32(listView_Event.SelectedItems[0].Text));
                checkedListBox1.Items.Add(Math.Round((decimal)p.Min_, 2), false);
                checkedListBox1.Items.Add(Math.Round((decimal)p.Ave,2), false);
                checkedListBox1.Items.Add(Math.Round((decimal)p.Max_,2), false);
            }
        }

        private void listView_Client_Click(object sender, EventArgs e)
        {
            if (listView_Client.SelectedItems.Count > 0)
            {
                ticket_.Client_Id = Convert.ToInt32(listView_Client.SelectedItems[0].Text);
                label_Client.Text = "ID = " + listView_Client.SelectedItems[0].Text;
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "") ev.GetById(Convert.ToInt32(maskedTextBox1.Text), listView_Event);
            else ev.All(listView_Event);
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "")cl.GetById(Convert.ToInt32(maskedTextBox2.Text), listView_Client);
            else cl.All(listView_Client);
        }

        private void listView_Event_ColumnClick(object sender, ColumnClickEventArgs e) => ev.OrderBy_List(e, listView_Event,false);

        private void listView_Client_ColumnClick(object sender, ColumnClickEventArgs e) => cl.OrderBy_List(e, listView_Client);

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in list.CheckedIndices)
                {
                    if (index != e.Index)list.SetItemChecked(index, false);
                }
                        
            }    
        }
    }
}
