using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Ticket_Cat : Form
    {
        bool n = true;
        Ticket_rep ticket_ = new Ticket_rep();
        Category_rep cat = new Category_rep();
        ListView event_ = new ListView();
        int id;
        public Ticket_Cat()
        {
            InitializeComponent();
            ticket_.All(listView_Ticket);
            cat.All(listView_Cat); 
            timer1.Start();
        }

        public Ticket_Cat( int id, string id_cat)
        {
            InitializeComponent();
            n = false;
            tb_Id.Text = id.ToString();
            ticket_.Client(listView_Ticket,id);
            cat.GetById(Convert.ToInt32(id_cat), listView_Cat);
            listView_Cat.ColumnClick -= listView_Cat_ColumnClick;
            listView_Ticket.ColumnClick -= listView_Ticket_ColumnClick;
            this.id = id;
            timer1.Start();
        }

        public Ticket_Cat(int id, ListView listView)
        {
            InitializeComponent();
            n = false;
            tb_Id.Text = id.ToString();
            ticket_.Event(listView_Ticket, id);
            event_ = listView;
            this.id = id;
            listView_Cat.ColumnClick -= listView_Cat_ColumnClick;
            listView_Ticket.ColumnClick -= listView_Ticket_ColumnClick;
            timer1.Start();
        }

        private void New_listView()
        {
            ticket_.All(listView_Ticket);
            cat.All(listView_Cat);
        }

        private void add_cat_Click(object sender, EventArgs e) => cat.Add(listView_Cat);

        private void Update_cat_Click(object sender, EventArgs e) => cat.Update(listView_Cat);

        private void Delete_cat_Click(object sender, EventArgs e) => cat.Delete(listView_Cat);

        private void add_Ticket_Click(object sender, EventArgs e)
        {
            ticket_.Add(listView_Ticket);
            New_listView();
        }


        private void Update_Ticket_Click(object sender, EventArgs e) => ticket_.Update(listView_Ticket);


        private void Delete_Ticket_Click(object sender, EventArgs e) => ticket_.Delete(listView_Ticket);
     

        private void tb_Id_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Id.Text, "^[0-9]+$") || tb_Id.Text == "")
            {
                if (n)
                {
                    if (tb_Id.Text != "") cat.GetById(Convert.ToInt32(tb_Id.Text), listView_Cat);
                    else cat.All(listView_Cat);

                }
                else
                {
                    if (tb_Id.Text != "") ticket_.GetById(Convert.ToInt32(tb_Id.Text), listView_Ticket);
                    else ticket_.All(listView_Ticket);
                }

            }
            else MessageBox.Show($"Ошибка в заполнении поля \"!\"Поиск по ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listView_Cat_DoubleClick(object sender, EventArgs e)
        {
            n = true;
            tb_Id.Clear();
            tb_Id.Focus();
        }

        private void listView_Ticket_DoubleClick(object sender, EventArgs e)
        {
            n = false;
            tb_Id.Clear();
            tb_Id.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)=>toolStripStatusLabel1.Text =  DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();

        private void ToolStripMenuItem_new_Click(object sender, EventArgs e)=> New_listView();

        private void listView_Ticket_ColumnClick(object sender, ColumnClickEventArgs e) => ticket_.OrderBy_List(e, listView_Ticket);

        private void listView_Cat_ColumnClick(object sender, ColumnClickEventArgs e) => cat.OrderBy_List(e, listView_Cat);

        private void all_tsp_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Admin"] as Admin == null)
            {
                cat.Cat_Event(Convert.ToInt32(listView_Ticket.FocusedItem.SubItems[1].Text), listView_Cat);
                Admin admin = new Admin(Convert.ToInt32(listView_Ticket.FocusedItem.SubItems[2].Text),Convert.ToInt32(listView_Ticket.FocusedItem.SubItems[1].Text));
                admin.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void all_tsi_Click(object sender, EventArgs e)
        {
            ticket_.Ticket_for_cat(listView_Cat, listView_Ticket);
            if (Application.OpenForms["Admin"] as Admin == null)
            {
                Admin admin = new Admin(Convert.ToInt32(listView_Cat.SelectedItems[0].Text));
                admin.Show();
            }
            else MessageBox.Show("Это окно уже открыто");

        }
    }
}
