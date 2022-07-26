using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Base_EventsPoster.Conn;
using Base_EventsPoster.Repos;

namespace Base_EventsPoster
{
    public partial class Anceta_Event : Form
    {
        public Event_ event_ { get; set; } = new Event_();
        Category_rep cat = new Category_rep();
        Price_rep pr = new Price_rep();
        bool n = true;
        public Anceta_Event()
        {
            InitializeComponent();
            dateTimePicker_Start.Value = DateTime.Now;
            dateTimePicker_End.Value = DateTime.Now;
            dateTimePicker_Start.MinDate = DateTime.Now;
            dateTimePicker_Start.MaxDate = new DateTime(dateTimePicker_Start.Value.Year + 1, dateTimePicker_Start.Value.Month, dateTimePicker_Start.Value.Day);
            dateTimePicker_End.MaxDate = new DateTime(dateTimePicker_Start.MaxDate.Year + 1, dateTimePicker_Start.MaxDate.Month, dateTimePicker_Start.MaxDate.Day);
            dateTimePicker_End.MinDate = DateTime.Now;
            event_.Event_Category_Id = -1;
            event_.Price_id = -1;
            cat.All(listView_Cat);
            pr.All(listView_Price);
        }

        public Anceta_Event(int i)
        {
            InitializeComponent();
            dateTimePicker_Start.Value = DateTime.Now;
            dateTimePicker_End.Value = DateTime.Now;
            dateTimePicker_Start.MinDate = DateTime.Now;
            dateTimePicker_Start.MaxDate = new DateTime(dateTimePicker_Start.Value.Year + 1, dateTimePicker_Start.Value.Month, dateTimePicker_Start.Value.Day);
            dateTimePicker_End.MaxDate = new DateTime(dateTimePicker_Start.MaxDate.Year + 1, dateTimePicker_Start.MaxDate.Month, dateTimePicker_Start.MaxDate.Day);
            dateTimePicker_End.MinDate = DateTime.Now;
            event_.Event_Category_Id = -1;
            event_.Price_id = -1;
            cat.All(listView_Cat);
            listView_Price.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            maskedTextBox2.Visible = false;
            n = false;
            button1.Location = new System.Drawing.Point(33, 609);
            button2.Location = new System.Drawing.Point(313, 609);
            int size = 720;
            this.Size = new System.Drawing.Size(this.Size.Width, size);
        }

        public Anceta_Event(Event_ event_up)
        {
            InitializeComponent();
            event_.Id = event_up.Id;
            dateTimePicker_Start.Value = event_up.Date_Start;
            dateTimePicker_End.Value = event_up.Date_Finish;
            dateTimePicker_Start.MinDate = DateTime.Now;
            dateTimePicker_Start.MaxDate = new DateTime(dateTimePicker_Start.Value.Year + 1, dateTimePicker_Start.Value.Month, dateTimePicker_Start.Value.Day);
            dateTimePicker_End.MaxDate = new DateTime(dateTimePicker_Start.MaxDate.Year + 1, dateTimePicker_Start.MaxDate.Month, dateTimePicker_Start.MaxDate.Day);
            dateTimePicker_End.MinDate = DateTime.Now;
            textBox_Name.Text = event_up.Name_Event;
            textBox_City.Text = event_up.Сity;
            textBox_Place.Text = event_up.Place;
            maskedTextBox_Time.Text = event_up.Time_.ToString();
            textBox_Description.Text = event_up.Event_description;
            textBox_Age.Text = event_up.Age_limitation.ToString();
            textBox_Col_ticket.Text = event_up.Maximum_count_tickets.ToString();
            textBox_Sale_ticket.Text = event_up.Purchased_count_tickets.ToString();
            event_.Event_Category_Id = event_up.Event_Category_Id;
            event_.Price_id = event_up.Price_id;
            label_cat.Text = event_.Event_Category_Id.ToString();
            label14.Text = event_up.Price_id.ToString();
            cat.All(listView_Cat);
            pr.All(listView_Price);
        }

        public Anceta_Event(Event_ event_up, int i)
        {
            InitializeComponent();
            event_.Price_id = -1;
            event_.Id = event_up.Id;
            dateTimePicker_Start.Value = event_up.Date_Start;
            dateTimePicker_End.Value = event_up.Date_Finish;
            dateTimePicker_Start.MinDate = DateTime.Now;
            dateTimePicker_Start.MaxDate = new DateTime(dateTimePicker_Start.Value.Year + 1, dateTimePicker_Start.Value.Month, dateTimePicker_Start.Value.Day);
            dateTimePicker_End.MaxDate = new DateTime(dateTimePicker_Start.MaxDate.Year + 1, dateTimePicker_Start.MaxDate.Month, dateTimePicker_Start.MaxDate.Day);
            dateTimePicker_End.MinDate = DateTime.Now;
            textBox_Name.Text = event_up.Name_Event;
            textBox_City.Text = event_up.Сity;
            textBox_Place.Text = event_up.Place;
            maskedTextBox_Time.Text = event_up.Time_.ToString();
            textBox_Description.Text = event_up.Event_description;
            textBox_Age.Text = event_up.Age_limitation.ToString();
            textBox_Col_ticket.Text = event_up.Maximum_count_tickets.ToString();
            textBox_Sale_ticket.Text = event_up.Purchased_count_tickets.ToString();
            event_.Event_Category_Id = event_up.Event_Category_Id;
            label_cat.Text = event_.Event_Category_Id.ToString();
            listView_Price.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            maskedTextBox2.Visible = false;
            n = false;
            button1.Location = new System.Drawing.Point(33, 609);
            button2.Location = new System.Drawing.Point(313, 609);
            int size = 720;
            this.Size = new System.Drawing.Size(this.Size.Width, size);
            cat.All(listView_Cat);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_Name.Text, "^[а-яА-Яa-zA-Z0-9- .()\":]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label1.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_City.Text, "^[а-яА-Яa-zA-Z- :]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label5.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_Place.Text, "^[а-яА-Яa-zA-Z0-9- /.,\" :]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label6.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_Age.Text, "^[0-9:]+$") && Convert.ToInt32(textBox_Age.Text)<0 && Convert.ToInt32(textBox_Age.Text) > 120)
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label8.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_Col_ticket.Text, "^[0-9:]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label9.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBox_Sale_ticket.Text, "^[0-9:]+$"))
            {
                MessageBox.Show($"Ошибка в заполнении поля \"{label10.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateTimePicker_Start.Value > dateTimePicker_End.Value)
            {
                MessageBox.Show("Ошибка в заполнении полей \"Дата!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox_Description.Text == null || textBox_Description.Text == "")
            {
                MessageBox.Show($"Ошибка в заполнении полей \"{label11.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(event_.Event_Category_Id == -1)
            {
                MessageBox.Show($"Ошибка в заполнении полей \"{label2.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(n)
            {
                 if(event_.Price_id == -1)
                 {
                     MessageBox.Show($"Ошибка в заполнении полей \"{label13.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                 }
            }
            TimeSpan time = new TimeSpan();
            if(!TimeSpan.TryParse( maskedTextBox_Time.Text,out time))
            {
                MessageBox.Show($"Ошибка в заполнении полей \"{label7.Text}!\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            event_.Name_Event = textBox_Name.Text;
            event_.Date_Start = dateTimePicker_Start.Value;
            event_.Date_Finish = dateTimePicker_End.Value;
            event_.Сity = textBox_City.Text;
            event_.Place = textBox_Place.Text;
            event_.Time_ = TimeSpan.Parse( maskedTextBox_Time.Text);
            event_.Event_description = textBox_Description.Text;
            event_.Age_limitation = Convert.ToInt32(textBox_Age.Text);
            event_.Maximum_count_tickets = Convert.ToInt32(textBox_Col_ticket.Text);
            event_.Purchased_count_tickets = Convert.ToInt32(textBox_Sale_ticket.Text);
            this.DialogResult = DialogResult.OK;

        }

        private void listView_Cat_DoubleClick(object sender, EventArgs e)
        {
            label_cat.Text = listView_Cat.FocusedItem.SubItems[1].Text;
            event_.Event_Category_Id = Convert.ToInt32(listView_Cat.SelectedItems[0].Text);
        }

        private void button2_Click(object sender, EventArgs e)=> this.DialogResult = DialogResult.Cancel;

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")cat.GetById(Convert.ToInt32(maskedTextBox1.Text), listView_Cat);
            else cat.All(listView_Cat);
        }

        private void listView_Cat_ColumnClick(object sender, ColumnClickEventArgs e) => cat.OrderBy_List(e, listView_Cat);

        private void listView_Price_DoubleClick(object sender, EventArgs e)
        {
            label14.Text = listView_Price.SelectedItems[0].Text;
            event_.Price_id = Convert.ToInt32(listView_Price.SelectedItems[0].Text);
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "") pr.GetById(Convert.ToInt32(maskedTextBox2.Text), listView_Price);
            else pr.All(listView_Price);
        }

        private void add_Price_Click(object sender, EventArgs e)=> pr.Add(listView_Price);

        private void add_Cat_Click(object sender, EventArgs e) => cat.Add(listView_Cat);

  
    }
}
