using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Base_EventsPoster.Conn;
using System.Data.SqlClient;
using System.Data;
using Base_EventsPoster.Repos;
using System.Linq;
using System.Collections.Generic;

namespace Base_EventsPoster
{
    public partial class Admin : Form
    {
        bool n = true;
        Event_rep ev = new Event_rep();
        Client_rep cl = new Client_rep();
        public Admin()
        {
            InitializeComponent();
            ev.All(Events_List);
            cl.All(Client_List);
            timer1.Start();
            
        }
        public Admin(int id_client, int id_event)
        {
            InitializeComponent();
            ev.GetById(id_event, Events_List);
            cl.GetById(id_client,Client_List);
            Client_Pictures.Image_output_(pictureBox_client, id_client);
            Event_Pictures.Image_output(pictureBox_Event, id_event);
            timer1.Start();
        }

        public Admin( int id_cat)
        {
            InitializeComponent();
            ev.Cat(id_cat, Events_List);
            timer1.Start();
        }

        private void add_Event_Click(object sender, EventArgs e) => ev.Add(Events_List);

        private void Update_Event_Click(object sender, EventArgs e) => ev.Update(Events_List);

        private void Delete_Event_Click(object sender, EventArgs e) => ev.Delete(Events_List);

        private void add_Client_Click(object sender, EventArgs e)=> cl.Add(Client_List);

        private void Update_Client_Click(object sender, EventArgs e) => cl.Update(Client_List);

        private void Delete_Client_Click(object sender, EventArgs e) => cl.Delete(Client_List);


        private void renew_Click(object sender, EventArgs e)
        {
            tb_Id.Clear();
            if (pictureBox_Event.Image != null)
            {
                pictureBox_Event.Image.Dispose();
                pictureBox_Event.Image = null;
            }
            if (pictureBox_client.Image != null)
            {
                pictureBox_client.Image.Dispose();
                pictureBox_client.Image = null;
            }
            ev.All(Events_List);
            cl.All(Client_List);
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Id.Text, "^[0-9]+$") || tb_Id.Text == "")
            {
                if (n)
                {
                    if (tb_Id.Text != "")cl.GetById(Convert.ToInt32(tb_Id.Text), Client_List);
                    else cl.All(Client_List);
                }
                else
                {
                    if (tb_Id.Text != "") ev.GetById(Convert.ToInt32(tb_Id.Text), Events_List);
                    else ev.All(Events_List);

                }
               
            }
            else MessageBox.Show($"Ошибка в заполнении поля \"!\"Поиск по ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void timer1_Tick(object sender, EventArgs e)=>toolStripStatusLabel_DateTime.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();

        private void add_photoToolStripMenuItem_Click(object sender, EventArgs e)=>Event_Pictures.Picture_selection(Events_List, pictureBox_Event);

        private void Events_List_Click(object sender, EventArgs e)
        {
            if(Events_List.SelectedItems.Count>0)Event_Pictures.Image_output(pictureBox_Event, Convert.ToInt32(Events_List.SelectedItems[0].Text));
        }

        private void update_PictureToolStripMenuItem_Click(object sender, EventArgs e)=>Event_Pictures.Picture_selection(Events_List, pictureBox_Event, false);

        private void Delete_PictureToolStripMenuItem_Click(object sender, EventArgs e)=> Event_Pictures.Delete_Picture(pictureBox_Event, Events_List);


        private void Client_List_Click(object sender, EventArgs e)
        {
            if(Client_List.SelectedItems.Count > 0)Client_Pictures.Image_output_(pictureBox_client, Convert.ToInt32(Client_List.SelectedItems[0].Text));
        }

        private void Add_picture_clientToolStripMenuItem1_Click(object sender, EventArgs e) => Client_Pictures.Picture_selection(Client_List, pictureBox_client);

        private void Update_picture_clientToolStripMenuItem_Click(object sender, EventArgs e) => Client_Pictures.Picture_selection(Client_List, pictureBox_client, false);

        private void Delete_Picture_clientToolStripMenuItem_Click(object sender, EventArgs e) => Client_Pictures.Delete_Picture(pictureBox_client, Client_List);


        private void Client_List_DoubleClick(object sender, EventArgs e)
        {
            n = true;
            tb_Id.Clear();
            tb_Id.Focus();
        }

        private void Events_List_DoubleClick(object sender, EventArgs e)
        {
            n = false;
            tb_Id.Clear();
            tb_Id.Focus();
        }

        private void Ticket_Event_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ticket_Cat"] as Ticket_Cat == null  )
            {
                cl.Client_Event(Convert.ToInt32(Events_List.SelectedItems[0].Text), Client_List);
                Ticket_Cat ticket_Cat = new Ticket_Cat(Convert.ToInt32(Events_List.SelectedItems[0].Text), Events_List.FocusedItem.SubItems[2].Text);
                ticket_Cat.Show();
            }
            else MessageBox.Show("Окно билеты уже открыто");
            if(Application.OpenForms["Price_red"] as Price_red == null)
            {
                Price_red price_Red = new Price_red(Convert.ToInt32(Events_List.SelectedItems[0].Text));
                price_Red.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void Event_Client_Ticket_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ticket_Cat"] as Ticket_Cat == null)
            {
                ev.Event_Client(Events_List, Convert.ToInt32(Client_List.SelectedItems[0].Text));
                Ticket_Cat ticket_Cat = new Ticket_Cat(Convert.ToInt32(Client_List.SelectedItems[0].Text), Events_List);
                ticket_Cat.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void eventtoClient_Click(object sender, EventArgs e)=>ev.Event_Client(Events_List, Convert.ToInt32(Client_List.SelectedItems[0].Text));

        private void clientstoEvent_Click(object sender, EventArgs e)=> cl.Client_Event(Convert.ToInt32(Events_List.SelectedItems[0].Text), Client_List);

        private void Events_List_ColumnClick(object sender, ColumnClickEventArgs e)=>ev.OrderBy_List(e, Events_List);

        private void Client_List_ColumnClick(object sender, ColumnClickEventArgs e)=> cl.OrderBy_List(e, Client_List);

        private void Activ_Client_Click(object sender, EventArgs e) => cl.Activ_Client(Client_List);

        private void top_3_actual_events_Click(object sender, EventArgs e) => ev.Actual_events(Events_List);

        private void event_today_Click(object sender, EventArgs e) => ev.Event_for_today(Events_List);

        private void Event_100_Click(object sender, EventArgs e) => ev.Event_100(Events_List);

        private void Top_3__Click(object sender, EventArgs e) => ev.Top_3_event(Events_List);

    }
}
