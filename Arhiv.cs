using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Arhiv : Form
    {
        Arhiv_rep arhiv_ = new Arhiv_rep();
        public Arhiv()
        {
            InitializeComponent();
            arhiv_.All(Arhiv_List);
            timer1.Start();
        }

        private void NewList()=>arhiv_.All(Arhiv_List);


        private void add_Event_Click(object sender, EventArgs e)=> arhiv_.Add(Arhiv_List);


        private void Update_EventToolStripMenuItem_Click(object sender, EventArgs e)=> arhiv_.Update(Arhiv_List);

        private void Delete_Event_Click(object sender, EventArgs e)=> arhiv_.Delete(Arhiv_List);

        private void tb_Id_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Id.Text, "^[0-9]+$") || tb_Id.Text == "")
            {
                if (tb_Id.Text != "")arhiv_.GetById(Convert.ToInt32(tb_Id.Text), Arhiv_List);
                else NewList();
            }
        }

        private void Arhiv_List_DoubleClick(object sender, EventArgs e)
        {
            tb_Id.Clear();
            tb_Id.Focus();
        }

        private void returnFromArchiveToolStripMenuItem1_Click(object sender, EventArgs e) => arhiv_.Update_Event(Arhiv_List);

        private void timer1_Tick(object sender, EventArgs e) => Time_lb.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();

        private void Arhiv_List_ColumnClick(object sender, ColumnClickEventArgs e) => arhiv_.OrderBy_List(e, Arhiv_List);
    }
}
