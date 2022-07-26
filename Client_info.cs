using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Client_info : Form
    {
        bool n;
        Category_rep cat = new Category_rep();
        Client_rep client_ = new Client_rep();
        Event_rep event_ = new Event_rep();
        Ticket_rep ticket_ = new Ticket_rep();
        public Client_info(string Email)
        {
            InitializeComponent();
            client_.GetByEmail(Email, Client_List);
            Client_List.Columns[0].Width = 0;
            event_.Actual_Event_for_Client(Convert.ToInt32( Client_List.Items[0].Text), Events_List);
            Events_List.Columns[0].Width = 0;
            Events_List.Columns[2].Width = 0;
            Events_List.Columns[12].Width = 0;
            Client_Pictures.Image_output_(pictureBox_client, Convert.ToInt32(Client_List.Items[0].Text));
            cat.All(listView_Cat);
            listView_Cat.Columns[0].Width = 0;
            n = true;
            dateTimePicker1.MinDate = DateTime.Now;
            toolStripStatusLabel1.BackColor = Color.Black;
            toolStripStatusLabel1.ForeColor = Color.White;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)=>event_.Actual_events(Events_List);

        private void button3_Click(object sender, EventArgs e)=> event_.OrderBy_5_DESC(Events_List);


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы подписаны на {event_.Event_Count(Convert.ToInt32(Client_List.Items[0].Text))} событий", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "")
            {
                if (!Regex.IsMatch(textBox_Name.Text, "^[а-яА-Яa-zA-Z0-9- .()\":]+$"))
                {
                    MessageBox.Show($"Ошибка в заполнении поля \"Название!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                event_.Name_Event(textBox_Name.Text, Events_List);
            }
            else event_.Actual_Event_for_Client(Convert.ToInt32(Client_List.Items[0].Text), Events_List);
        }

        private void listView_Cat_DoubleClick(object sender, EventArgs e)
        {
            event_.Event_Category_(Convert.ToInt32(listView_Cat.SelectedItems[0].Text), Convert.ToInt32(Client_List.Items[0].Text), Events_List);
            n = true;
        }

        private void Events_List_DoubleClick(object sender, EventArgs e)
        {
            if (n)
            {
                
                ticket_.Add_client(Events_List, Convert.ToInt32( Events_List.SelectedItems[0].Text), Convert.ToInt32(Client_List.Items[0].Text));
                event_.Actual_Event_for_Client(Convert.ToInt32(Client_List.Items[0].Text), Events_List);
            }
            else
            {
                ticket_.Delete_Ticket_Client_info(Convert.ToInt32(Events_List.SelectedItems[0].Text), Convert.ToInt32(Client_List.Items[0].Text));
                n = true;
                event_.Event_Client(Events_List, Convert.ToInt32(Client_List.Items[0].Text));
            }
            
        }


        private void renew_Click(object sender, EventArgs e)
        {
            if (pictureBox_Event.Image != null)
            {
                pictureBox_Event.Image.Dispose();
                pictureBox_Event.Image = null;
            }
            event_.Actual_Event_for_Client(Convert.ToInt32(Client_List.Items[0].Text), Events_List);
            n = true;
            Events_List.ColumnClick += Events_List_ColumnClick;
        }

        private void Events_List_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            textBox_Name.Clear();
            textBox_Name.Focus();
            event_.OrderBy_List(e, Events_List);
        }

        private void timer1_Tick(object sender, EventArgs e)=>toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();

        private void Events_List_Click(object sender, EventArgs e)
        {
            if(Events_List.SelectedItems.Count>0) Event_Pictures.Image_output(pictureBox_Event, Convert.ToInt32(Events_List.SelectedItems[0].Text));
        }

        private void add_pictureToolStripMenuItem_Click(object sender, EventArgs e)=> Client_Pictures.Picture_selection(Client_List, pictureBox_client);

        private void Update_pictureToolStripMenuItem_Click(object sender, EventArgs e)=> Client_Pictures.Picture_selection(Client_List, pictureBox_client, false);

        private void Delete_PictureToolStripMenuItem_Click(object sender, EventArgs e)=> Client_Pictures.Delete_Picture(pictureBox_client, Client_List);

        private void Event_Ticket_Click(object sender, EventArgs e)
        {
            event_.Event_Client(Events_List, Convert.ToInt32(Client_List.Items[0].Text));
            n = false;
            Events_List.ColumnClick -= Events_List_ColumnClick;
        }

        private void listView_Cat_ColumnClick(object sender, ColumnClickEventArgs e)=> cat.OrderBy_List(e, listView_Cat);

        private void bt_price_Click(object sender, EventArgs e)
        {
            if(tb_price.Text != "")
            {
                decimal num;
                if (decimal.TryParse(tb_price.Text.Replace(".", ","), out num)) event_.Price_Event_Search(Events_List, Convert.ToInt32(Client_List.Items[0].Text), num);
                else MessageBox.Show("Не верно заполнены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {
            if(tb_price.Text !="")
            {
                decimal num;
                if (!decimal.TryParse(tb_price.Text.Replace(".", ","), out num))
                {
                    MessageBox.Show("Не верно заполнены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_price.Text = "";
                }
            } 
        }

        private void dtn_date_Click(object sender, EventArgs e) => event_.Event_dateNow(Events_List, dateTimePicker1.Value, Convert.ToInt32(Client_List.Items[0].Text));

        private void btn_city_Click(object sender, EventArgs e)
        {
            if(tb_city.Text != "")
            {
                event_.Event_City(Events_List, tb_city.Text, Convert.ToInt32(Client_List.Items[0].Text));
                tb_city.Text = "";
            }
        }

        private void tb_city_TextChanged(object sender, EventArgs e)
        {
            if(tb_city.Text != "")
            {
                if (!Regex.IsMatch(tb_city.Text, "^[а-яА-Яa-zA-Z- :]+$"))
                {
                    MessageBox.Show($"Ошибка в заполнении поля город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_city.Text = "";
                }
            }
            
        }
    }
}
