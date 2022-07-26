
namespace Base_EventsPoster
{
    partial class Ticket_Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Cat));
            this.listView_Ticket = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_EventID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_Ticket = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_Ticket_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Ticket_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Ticket_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.all_tsp = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Cat = new System.Windows.Forms.ListView();
            this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_Cat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_Cat_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Cat_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Cat_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.all_tsi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_cat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Update_cat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete_cat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Update_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tb_Id = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cms_Ticket.SuspendLayout();
            this.cms_Cat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Ticket
            // 
            this.listView_Ticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView_Ticket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.column_EventID,
            this.column_ClientID,
            this.column_Price,
            this.column_Date});
            this.listView_Ticket.ContextMenuStrip = this.cms_Ticket;
            this.listView_Ticket.FullRowSelect = true;
            this.listView_Ticket.GridLines = true;
            this.listView_Ticket.HideSelection = false;
            this.listView_Ticket.Location = new System.Drawing.Point(299, 70);
            this.listView_Ticket.Name = "listView_Ticket";
            this.listView_Ticket.Size = new System.Drawing.Size(457, 320);
            this.listView_Ticket.TabIndex = 2;
            this.listView_Ticket.UseCompatibleStateImageBehavior = false;
            this.listView_Ticket.View = System.Windows.Forms.View.Details;
            this.listView_Ticket.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Ticket_ColumnClick);
            this.listView_Ticket.DoubleClick += new System.EventHandler(this.listView_Ticket_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 41;
            // 
            // column_EventID
            // 
            this.column_EventID.Text = "Событие ID";
            this.column_EventID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_EventID.Width = 86;
            // 
            // column_ClientID
            // 
            this.column_ClientID.Text = "Клиент ID";
            this.column_ClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_ClientID.Width = 87;
            // 
            // column_Price
            // 
            this.column_Price.Text = "Цена";
            this.column_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Price.Width = 96;
            // 
            // column_Date
            // 
            this.column_Date.Text = "Дата покупки";
            this.column_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Date.Width = 124;
            // 
            // cms_Ticket
            // 
            this.cms_Ticket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cms_Ticket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_Ticket_add,
            this.toolStripSeparator2,
            this.cms_Ticket_update,
            this.toolStripSeparator3,
            this.cms_Ticket_delete,
            this.toolStripMenuItem10,
            this.all_tsp});
            this.cms_Ticket.Name = "cms_Event";
            this.cms_Ticket.Size = new System.Drawing.Size(175, 110);
            // 
            // cms_Ticket_add
            // 
            this.cms_Ticket_add.Name = "cms_Ticket_add";
            this.cms_Ticket_add.Size = new System.Drawing.Size(174, 22);
            this.cms_Ticket_add.Text = "Добавить билет";
            this.cms_Ticket_add.Click += new System.EventHandler(this.add_Ticket_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // cms_Ticket_update
            // 
            this.cms_Ticket_update.Name = "cms_Ticket_update";
            this.cms_Ticket_update.Size = new System.Drawing.Size(174, 22);
            this.cms_Ticket_update.Text = "Изменить билет";
            this.cms_Ticket_update.Click += new System.EventHandler(this.Update_Ticket_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // cms_Ticket_delete
            // 
            this.cms_Ticket_delete.Name = "cms_Ticket_delete";
            this.cms_Ticket_delete.Size = new System.Drawing.Size(174, 22);
            this.cms_Ticket_delete.Text = "Удалить билет";
            this.cms_Ticket_delete.Click += new System.EventHandler(this.Delete_Ticket_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(171, 6);
            // 
            // all_tsp
            // 
            this.all_tsp.Name = "all_tsp";
            this.all_tsp.Size = new System.Drawing.Size(174, 22);
            this.all_tsp.Text = "Вся информация";
            this.all_tsp.Click += new System.EventHandler(this.all_tsp_Click);
            // 
            // listView_Cat
            // 
            this.listView_Cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView_Cat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID,
            this.column_Cat});
            this.listView_Cat.ContextMenuStrip = this.cms_Cat;
            this.listView_Cat.FullRowSelect = true;
            this.listView_Cat.GridLines = true;
            this.listView_Cat.HideSelection = false;
            this.listView_Cat.Location = new System.Drawing.Point(3, 70);
            this.listView_Cat.Name = "listView_Cat";
            this.listView_Cat.Size = new System.Drawing.Size(246, 320);
            this.listView_Cat.TabIndex = 3;
            this.listView_Cat.UseCompatibleStateImageBehavior = false;
            this.listView_Cat.View = System.Windows.Forms.View.Details;
            this.listView_Cat.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Cat_ColumnClick);
            this.listView_Cat.DoubleClick += new System.EventHandler(this.listView_Cat_DoubleClick);
            // 
            // column_ID
            // 
            this.column_ID.Text = "ID";
            // 
            // column_Cat
            // 
            this.column_Cat.Text = "Категория";
            this.column_Cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Cat.Width = 182;
            // 
            // cms_Cat
            // 
            this.cms_Cat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cms_Cat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_Cat_add,
            this.toolStripMenuItem14,
            this.cms_Cat_update,
            this.toolStripMenuItem15,
            this.cms_Cat_delete,
            this.toolStripMenuItem9,
            this.all_tsi});
            this.cms_Cat.Name = "cms_Event";
            this.cms_Cat.Size = new System.Drawing.Size(199, 110);
            // 
            // cms_Cat_add
            // 
            this.cms_Cat_add.Name = "cms_Cat_add";
            this.cms_Cat_add.Size = new System.Drawing.Size(198, 22);
            this.cms_Cat_add.Text = "Добавить категорию";
            this.cms_Cat_add.Click += new System.EventHandler(this.add_cat_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(195, 6);
            // 
            // cms_Cat_update
            // 
            this.cms_Cat_update.Name = "cms_Cat_update";
            this.cms_Cat_update.Size = new System.Drawing.Size(198, 22);
            this.cms_Cat_update.Text = "Изменить категорию";
            this.cms_Cat_update.Click += new System.EventHandler(this.Update_cat_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(195, 6);
            // 
            // cms_Cat_delete
            // 
            this.cms_Cat_delete.Name = "cms_Cat_delete";
            this.cms_Cat_delete.Size = new System.Drawing.Size(198, 22);
            this.cms_Cat_delete.Text = "Удалить категорию";
            this.cms_Cat_delete.Click += new System.EventHandler(this.Delete_cat_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(195, 6);
            // 
            // all_tsi
            // 
            this.all_tsi.Name = "all_tsi";
            this.all_tsi.Size = new System.Drawing.Size(198, 22);
            this.all_tsi.Text = "Вся информация";
            this.all_tsi.Click += new System.EventHandler(this.all_tsi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatToolStripMenuItem,
            this.toolStripMenuItem5,
            this.TicketToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripTextBox1,
            this.tb_Id,
            this.toolStripMenuItem7,
            this.ToolStripMenuItem_new,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(759, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CatToolStripMenuItem
            // 
            this.CatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_cat,
            this.toolStripMenuItem1,
            this.Update_cat,
            this.toolStripMenuItem2,
            this.Delete_cat});
            this.CatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CatToolStripMenuItem.Name = "CatToolStripMenuItem";
            this.CatToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.CatToolStripMenuItem.Text = "&Категория";
            // 
            // add_cat
            // 
            this.add_cat.Name = "add_cat";
            this.add_cat.Size = new System.Drawing.Size(231, 24);
            this.add_cat.Text = "Добавить категорию";
            this.add_cat.Click += new System.EventHandler(this.add_cat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // Update_cat
            // 
            this.Update_cat.Name = "Update_cat";
            this.Update_cat.Size = new System.Drawing.Size(231, 24);
            this.Update_cat.Text = "Изменить категорию";
            this.Update_cat.Click += new System.EventHandler(this.Update_cat_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // Delete_cat
            // 
            this.Delete_cat.Name = "Delete_cat";
            this.Delete_cat.Size = new System.Drawing.Size(231, 24);
            this.Delete_cat.Text = "Удалить категорию";
            this.Delete_cat.Click += new System.EventHandler(this.Delete_cat_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem5.Text = "|";
            // 
            // TicketToolStripMenuItem
            // 
            this.TicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Ticket,
            this.toolStripMenuItem3,
            this.Update_Ticket,
            this.toolStripMenuItem4,
            this.Delete_Ticket});
            this.TicketToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem";
            this.TicketToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.TicketToolStripMenuItem.Text = "&Билет";
            // 
            // add_Ticket
            // 
            this.add_Ticket.Name = "add_Ticket";
            this.add_Ticket.Size = new System.Drawing.Size(196, 24);
            this.add_Ticket.Text = "Добавить билет";
            this.add_Ticket.Click += new System.EventHandler(this.add_Ticket_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
            // 
            // Update_Ticket
            // 
            this.Update_Ticket.Name = "Update_Ticket";
            this.Update_Ticket.Size = new System.Drawing.Size(196, 24);
            this.Update_Ticket.Text = "Изменить билет";
            this.Update_Ticket.Click += new System.EventHandler(this.Update_Ticket_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // Delete_Ticket
            // 
            this.Delete_Ticket.Name = "Delete_Ticket";
            this.Delete_Ticket.Size = new System.Drawing.Size(196, 24);
            this.Delete_Ticket.Text = "Удалить билет";
            this.Delete_Ticket.Click += new System.EventHandler(this.Delete_Ticket_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem6.Text = "|";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 24);
            this.toolStripTextBox1.Text = "Поиск по ID";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 24);
            this.tb_Id.TextChanged += new System.EventHandler(this.tb_Id_TextChanged);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem7.Text = "|";
            // 
            // ToolStripMenuItem_new
            // 
            this.ToolStripMenuItem_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_new.Name = "ToolStripMenuItem_new";
            this.ToolStripMenuItem_new.Size = new System.Drawing.Size(98, 24);
            this.ToolStripMenuItem_new.Text = "&Обновить";
            this.ToolStripMenuItem_new.Click += new System.EventHandler(this.ToolStripMenuItem_new_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem8.Text = "|";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(759, 39);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Добавить категорию";
            this.toolStripButton1.Click += new System.EventHandler(this.add_cat_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Изменить категорию";
            this.toolStripButton2.Click += new System.EventHandler(this.Update_cat_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Удалить категорию";
            this.toolStripButton3.Click += new System.EventHandler(this.Delete_cat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Добавить билет ";
            this.toolStripButton4.Click += new System.EventHandler(this.add_Ticket_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Изменить билет ";
            this.toolStripButton5.Click += new System.EventHandler(this.Update_Ticket_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "Удалить билет";
            this.toolStripButton6.Click += new System.EventHandler(this.Delete_Ticket_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Ticket_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(759, 416);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView_Cat);
            this.Controls.Add(this.listView_Ticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ticket_Cat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор таблиц \"Категория\" и \"Билет\"";
            this.cms_Ticket.ResumeLayout(false);
            this.cms_Cat.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Ticket;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader column_EventID;
        private System.Windows.Forms.ColumnHeader column_ClientID;
        private System.Windows.Forms.ColumnHeader column_Price;
        private System.Windows.Forms.ColumnHeader column_Date;
        private System.Windows.Forms.ListView listView_Cat;
        private System.Windows.Forms.ColumnHeader column_ID;
        private System.Windows.Forms.ColumnHeader column_Cat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_cat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Update_cat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Delete_cat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_Ticket;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Update_Ticket;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Delete_Ticket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox tb_Id;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_new;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip cms_Cat;
        private System.Windows.Forms.ToolStripMenuItem cms_Cat_add;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem cms_Cat_update;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem cms_Cat_delete;
        private System.Windows.Forms.ContextMenuStrip cms_Ticket;
        private System.Windows.Forms.ToolStripMenuItem cms_Ticket_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cms_Ticket_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cms_Ticket_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem all_tsi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem all_tsp;
    }
}