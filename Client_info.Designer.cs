
namespace Base_EventsPoster
{
    partial class Client_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_info));
            this.Events_List = new System.Windows.Forms.ListView();
            this.column_ID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Name_event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCat_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_city_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column__place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCol_ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSale_ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Event_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.Client_List = new System.Windows.Forms.ListView();
            this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Name_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_LN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_BD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.btn_city = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtn_date = new System.Windows.Forms.Button();
            this.bt_price = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView_Cat = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.textBox_Name = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.renew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_client = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Update_pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete_PictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Event = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cms_Event.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_client)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Event)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Events_List
            // 
            this.Events_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Events_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID_,
            this.column_Name_event,
            this.columnCat_Id,
            this.column_sDate,
            this.column_fDate,
            this.column_city_,
            this.column__place,
            this.columnTime,
            this.columnDescription,
            this.columnAge,
            this.columnCol_ticket,
            this.columnSale_ticket,
            this.columnHeader1});
            this.Events_List.ContextMenuStrip = this.cms_Event;
            this.Events_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Events_List.FullRowSelect = true;
            this.Events_List.GridLines = true;
            this.Events_List.HideSelection = false;
            this.Events_List.Location = new System.Drawing.Point(7, 245);
            this.Events_List.Name = "Events_List";
            this.Events_List.ShowItemToolTips = true;
            this.Events_List.Size = new System.Drawing.Size(1332, 233);
            this.Events_List.TabIndex = 4;
            this.Events_List.UseCompatibleStateImageBehavior = false;
            this.Events_List.View = System.Windows.Forms.View.Details;
            this.Events_List.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Events_List_ColumnClick);
            this.Events_List.Click += new System.EventHandler(this.Events_List_Click);
            this.Events_List.DoubleClick += new System.EventHandler(this.Events_List_DoubleClick);
            // 
            // column_ID_
            // 
            this.column_ID_.Text = "ID";
            this.column_ID_.Width = 0;
            // 
            // column_Name_event
            // 
            this.column_Name_event.Text = "Название";
            this.column_Name_event.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Name_event.Width = 230;
            // 
            // columnCat_Id
            // 
            this.columnCat_Id.DisplayIndex = 11;
            this.columnCat_Id.Text = "Категория";
            this.columnCat_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCat_Id.Width = 0;
            // 
            // column_sDate
            // 
            this.column_sDate.DisplayIndex = 2;
            this.column_sDate.Text = "Дата начала";
            this.column_sDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_sDate.Width = 125;
            // 
            // column_fDate
            // 
            this.column_fDate.DisplayIndex = 3;
            this.column_fDate.Text = "Дата завершения";
            this.column_fDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_fDate.Width = 133;
            // 
            // column_city_
            // 
            this.column_city_.DisplayIndex = 4;
            this.column_city_.Text = "Город";
            this.column_city_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_city_.Width = 96;
            // 
            // column__place
            // 
            this.column__place.DisplayIndex = 5;
            this.column__place.Text = "Место";
            this.column__place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column__place.Width = 147;
            // 
            // columnTime
            // 
            this.columnTime.DisplayIndex = 6;
            this.columnTime.Text = "Время";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 58;
            // 
            // columnDescription
            // 
            this.columnDescription.DisplayIndex = 7;
            this.columnDescription.Text = "Описание";
            this.columnDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDescription.Width = 167;
            // 
            // columnAge
            // 
            this.columnAge.DisplayIndex = 8;
            this.columnAge.Text = "Возраст";
            this.columnAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAge.Width = 73;
            // 
            // columnCol_ticket
            // 
            this.columnCol_ticket.DisplayIndex = 9;
            this.columnCol_ticket.Text = "Количество билетов";
            this.columnCol_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCol_ticket.Width = 139;
            // 
            // columnSale_ticket
            // 
            this.columnSale_ticket.DisplayIndex = 10;
            this.columnSale_ticket.Text = "Проданно билетов";
            this.columnSale_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSale_ticket.Width = 132;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Price_Id";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 0;
            // 
            // cms_Event
            // 
            this.cms_Event.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Event_Ticket});
            this.cms_Event.Name = "cms_Event";
            this.cms_Event.Size = new System.Drawing.Size(246, 26);
            // 
            // Event_Ticket
            // 
            this.Event_Ticket.Name = "Event_Ticket";
            this.Event_Ticket.Size = new System.Drawing.Size(245, 22);
            this.Event_Ticket.Text = "События на которые подписан";
            this.Event_Ticket.Click += new System.EventHandler(this.Event_Ticket_Click);
            // 
            // Client_List
            // 
            this.Client_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Client_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID,
            this.column_Name_,
            this.column_LN,
            this.column_BD,
            this.column_Email});
            this.Client_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client_List.FullRowSelect = true;
            this.Client_List.GridLines = true;
            this.Client_List.HideSelection = false;
            this.Client_List.Location = new System.Drawing.Point(237, 31);
            this.Client_List.Name = "Client_List";
            this.Client_List.ShowItemToolTips = true;
            this.Client_List.Size = new System.Drawing.Size(658, 47);
            this.Client_List.TabIndex = 5;
            this.Client_List.UseCompatibleStateImageBehavior = false;
            this.Client_List.View = System.Windows.Forms.View.Details;
            // 
            // column_ID
            // 
            this.column_ID.Text = "ID";
            this.column_ID.Width = 0;
            // 
            // column_Name_
            // 
            this.column_Name_.Text = "Имя";
            this.column_Name_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Name_.Width = 118;
            // 
            // column_LN
            // 
            this.column_LN.Text = "Фамилия";
            this.column_LN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_LN.Width = 135;
            // 
            // column_BD
            // 
            this.column_BD.Text = "Дата рождения";
            this.column_BD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_BD.Width = 139;
            // 
            // column_Email
            // 
            this.column_Email.Text = "Email";
            this.column_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Email.Width = 234;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Топ 3 события";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.tb_city);
            this.panel1.Controls.Add(this.btn_city);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dtn_date);
            this.panel1.Controls.Add(this.bt_price);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(237, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 155);
            this.panel1.TabIndex = 7;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_price.Location = new System.Drawing.Point(3, 113);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(120, 20);
            this.tb_price.TabIndex = 15;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            // 
            // tb_city
            // 
            this.tb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_city.Location = new System.Drawing.Point(247, 113);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(120, 20);
            this.tb_city.TabIndex = 14;
            this.tb_city.TextChanged += new System.EventHandler(this.tb_city_TextChanged);
            // 
            // btn_city
            // 
            this.btn_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_city.Location = new System.Drawing.Point(247, 69);
            this.btn_city.Name = "btn_city";
            this.btn_city.Size = new System.Drawing.Size(120, 38);
            this.btn_city.TabIndex = 13;
            this.btn_city.Text = "Поиск по городу";
            this.btn_city.UseVisualStyleBackColor = false;
            this.btn_city.Click += new System.EventHandler(this.btn_city_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dtn_date
            // 
            this.dtn_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtn_date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dtn_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtn_date.Location = new System.Drawing.Point(125, 69);
            this.dtn_date.Name = "dtn_date";
            this.dtn_date.Size = new System.Drawing.Size(120, 38);
            this.dtn_date.TabIndex = 11;
            this.dtn_date.Text = "Поиск по дате";
            this.dtn_date.UseVisualStyleBackColor = false;
            this.dtn_date.Click += new System.EventHandler(this.dtn_date_Click);
            // 
            // bt_price
            // 
            this.bt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_price.Location = new System.Drawing.Point(3, 69);
            this.bt_price.Name = "bt_price";
            this.bt_price.Size = new System.Drawing.Size(120, 38);
            this.bt_price.TabIndex = 9;
            this.bt_price.Text = "Поиск по стоимости";
            this.bt_price.UseVisualStyleBackColor = false;
            this.bt_price.Click += new System.EventHandler(this.bt_price_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(247, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "На сколько событий подписан";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(125, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Toп 5 недавно добавленых";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView_Cat
            // 
            this.listView_Cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView_Cat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName});
            this.listView_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Cat.FullRowSelect = true;
            this.listView_Cat.GridLines = true;
            this.listView_Cat.HideSelection = false;
            this.listView_Cat.Location = new System.Drawing.Point(617, 84);
            this.listView_Cat.Name = "listView_Cat";
            this.listView_Cat.ShowItemToolTips = true;
            this.listView_Cat.Size = new System.Drawing.Size(274, 155);
            this.listView_Cat.TabIndex = 25;
            this.listView_Cat.UseCompatibleStateImageBehavior = false;
            this.listView_Cat.View = System.Windows.Forms.View.Details;
            this.listView_Cat.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Cat_ColumnClick);
            this.listView_Cat.DoubleClick += new System.EventHandler(this.listView_Cat_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 0;
            // 
            // columnName
            // 
            this.columnName.Text = "Категория";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 242;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.textBox_Name,
            this.toolStripMenuItem7,
            this.renew,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1347, 29);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(140, 25);
            this.toolStripTextBox1.Text = "Поиск по названию";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(150, 25);
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(23, 25);
            this.toolStripMenuItem7.Text = "|";
            // 
            // renew
            // 
            this.renew.BackColor = System.Drawing.Color.White;
            this.renew.BackgroundImage = global::Base_EventsPoster.Properties.Resources.Без_названия1;
            this.renew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.renew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.renew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renew.ForeColor = System.Drawing.Color.Lime;
            this.renew.Name = "renew";
            this.renew.Size = new System.Drawing.Size(99, 25);
            this.renew.Text = "Обновить";
            this.renew.Click += new System.EventHandler(this.renew_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(23, 25);
            this.toolStripMenuItem8.Text = "|";
            // 
            // pictureBox_client
            // 
            this.pictureBox_client.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_client.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_client.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox_client.Location = new System.Drawing.Point(7, 31);
            this.pictureBox_client.Name = "pictureBox_client";
            this.pictureBox_client.Size = new System.Drawing.Size(224, 208);
            this.pictureBox_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_client.TabIndex = 27;
            this.pictureBox_client.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_pictureToolStripMenuItem,
            this.toolStripMenuItem1,
            this.Update_pictureToolStripMenuItem,
            this.toolStripMenuItem2,
            this.Delete_PictureToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 82);
            // 
            // add_pictureToolStripMenuItem
            // 
            this.add_pictureToolStripMenuItem.Name = "add_pictureToolStripMenuItem";
            this.add_pictureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.add_pictureToolStripMenuItem.Text = "Добавить фото";
            this.add_pictureToolStripMenuItem.Click += new System.EventHandler(this.add_pictureToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // Update_pictureToolStripMenuItem
            // 
            this.Update_pictureToolStripMenuItem.Name = "Update_pictureToolStripMenuItem";
            this.Update_pictureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.Update_pictureToolStripMenuItem.Text = "Изменить фото";
            this.Update_pictureToolStripMenuItem.Click += new System.EventHandler(this.Update_pictureToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // Delete_PictureToolStripMenuItem
            // 
            this.Delete_PictureToolStripMenuItem.Name = "Delete_PictureToolStripMenuItem";
            this.Delete_PictureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.Delete_PictureToolStripMenuItem.Text = "Удалить фото";
            this.Delete_PictureToolStripMenuItem.Click += new System.EventHandler(this.Delete_PictureToolStripMenuItem_Click);
            // 
            // pictureBox_Event
            // 
            this.pictureBox_Event.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Event.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Event.Location = new System.Drawing.Point(901, 31);
            this.pictureBox_Event.Name = "pictureBox_Event";
            this.pictureBox_Event.Size = new System.Drawing.Size(438, 208);
            this.pictureBox_Event.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Event.TabIndex = 28;
            this.pictureBox_Event.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1347, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Client_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Base_EventsPoster.Properties.Resources._1480505775_cosmos_0011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox_Event);
            this.Controls.Add(this.pictureBox_client);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView_Cat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Client_List);
            this.Controls.Add(this.Events_List);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Афиша событий";
            this.cms_Event.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_client)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Event)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Events_List;
        private System.Windows.Forms.ColumnHeader column_ID_;
        private System.Windows.Forms.ColumnHeader column_Name_event;
        private System.Windows.Forms.ColumnHeader column_sDate;
        private System.Windows.Forms.ColumnHeader column_fDate;
        private System.Windows.Forms.ColumnHeader column_city_;
        private System.Windows.Forms.ColumnHeader column__place;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ColumnHeader columnCol_ticket;
        private System.Windows.Forms.ColumnHeader columnSale_ticket;
        private System.Windows.Forms.ListView Client_List;
        private System.Windows.Forms.ColumnHeader column_ID;
        private System.Windows.Forms.ColumnHeader column_Name_;
        private System.Windows.Forms.ColumnHeader column_LN;
        private System.Windows.Forms.ColumnHeader column_BD;
        private System.Windows.Forms.ColumnHeader column_Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView_Cat;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCat_Id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox textBox_Name;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem renew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.PictureBox pictureBox_client;
        private System.Windows.Forms.PictureBox pictureBox_Event;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem add_pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Update_pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Delete_PictureToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_Event;
        private System.Windows.Forms.ToolStripMenuItem Event_Ticket;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Button btn_city;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dtn_date;
        private System.Windows.Forms.Button bt_price;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}