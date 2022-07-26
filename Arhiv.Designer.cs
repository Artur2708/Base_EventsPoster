
namespace Base_EventsPoster
{
    partial class Arhiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arhiv));
            this.Arhiv_List = new System.Windows.Forms.ListView();
            this.column_ID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Name_event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCat_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_city_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column__place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCol_ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSale_ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_Arhive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_arhive_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_arhive_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_arhive__delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_arhive_ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Event = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Update_EventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete_Event = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tb_Id = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnFromArchiveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Time_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cms_Arhive.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Arhiv_List
            // 
            this.Arhiv_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Arhiv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID_,
            this.column_Name_event,
            this.columnCat_ID,
            this.column_sDate,
            this.column_fDate,
            this.column_city_,
            this.column__place,
            this.columnTime,
            this.columnDescription,
            this.columnAge,
            this.columnCol_ticket,
            this.columnSale_ticket});
            this.Arhiv_List.ContextMenuStrip = this.cms_Arhive;
            this.Arhiv_List.FullRowSelect = true;
            this.Arhiv_List.GridLines = true;
            this.Arhiv_List.HideSelection = false;
            this.Arhiv_List.Location = new System.Drawing.Point(3, 70);
            this.Arhiv_List.Name = "Arhiv_List";
            this.Arhiv_List.Size = new System.Drawing.Size(1359, 234);
            this.Arhiv_List.TabIndex = 4;
            this.Arhiv_List.UseCompatibleStateImageBehavior = false;
            this.Arhiv_List.View = System.Windows.Forms.View.Details;
            this.Arhiv_List.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Arhiv_List_ColumnClick);
            this.Arhiv_List.DoubleClick += new System.EventHandler(this.Arhiv_List_DoubleClick);
            // 
            // column_ID_
            // 
            this.column_ID_.Text = "ID";
            this.column_ID_.Width = 26;
            // 
            // column_Name_event
            // 
            this.column_Name_event.Text = "Название";
            this.column_Name_event.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Name_event.Width = 230;
            // 
            // columnCat_ID
            // 
            this.columnCat_ID.Text = "Категория - ID";
            this.columnCat_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCat_ID.Width = 85;
            // 
            // column_sDate
            // 
            this.column_sDate.Text = "Дата начала";
            this.column_sDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_sDate.Width = 125;
            // 
            // column_fDate
            // 
            this.column_fDate.Text = "Дата завершения";
            this.column_fDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_fDate.Width = 133;
            // 
            // column_city_
            // 
            this.column_city_.Text = "Город";
            this.column_city_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_city_.Width = 81;
            // 
            // column__place
            // 
            this.column__place.Text = "Место";
            this.column__place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column__place.Width = 147;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Время";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 58;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Описание";
            this.columnDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDescription.Width = 167;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Возраст";
            this.columnAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAge.Width = 58;
            // 
            // columnCol_ticket
            // 
            this.columnCol_ticket.Text = "Количество билетов";
            this.columnCol_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCol_ticket.Width = 116;
            // 
            // columnSale_ticket
            // 
            this.columnSale_ticket.Text = "Проданно билетов";
            this.columnSale_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSale_ticket.Width = 109;
            // 
            // cms_Arhive
            // 
            this.cms_Arhive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cms_Arhive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_arhive_add,
            this.toolStripMenuItem14,
            this.cms_arhive_update,
            this.toolStripMenuItem15,
            this.cms_arhive__delete,
            this.toolStripMenuItem5,
            this.cms_arhive_});
            this.cms_Arhive.Name = "cms_Event";
            this.cms_Arhive.Size = new System.Drawing.Size(186, 110);
            // 
            // cms_arhive_add
            // 
            this.cms_arhive_add.Name = "cms_arhive_add";
            this.cms_arhive_add.Size = new System.Drawing.Size(185, 22);
            this.cms_arhive_add.Text = "Добавить событие";
            this.cms_arhive_add.Click += new System.EventHandler(this.add_Event_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(182, 6);
            // 
            // cms_arhive_update
            // 
            this.cms_arhive_update.Name = "cms_arhive_update";
            this.cms_arhive_update.Size = new System.Drawing.Size(185, 22);
            this.cms_arhive_update.Text = "Изменить событие";
            this.cms_arhive_update.Click += new System.EventHandler(this.Update_EventToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(182, 6);
            // 
            // cms_arhive__delete
            // 
            this.cms_arhive__delete.Name = "cms_arhive__delete";
            this.cms_arhive__delete.Size = new System.Drawing.Size(185, 22);
            this.cms_arhive__delete.Text = "Удалить событие";
            this.cms_arhive__delete.Click += new System.EventHandler(this.Delete_Event_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(182, 6);
            // 
            // cms_arhive_
            // 
            this.cms_arhive_.Name = "cms_arhive_";
            this.cms_arhive_.Size = new System.Drawing.Size(185, 22);
            this.cms_arhive_.Text = "Вернуть из архива";
            this.cms_arhive_.Click += new System.EventHandler(this.returnFromArchiveToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EventToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripTextBox1,
            this.tb_Id,
            this.toolStripMenuItem7,
            this.returnFromArchiveToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.ToolStripMenuItem_new,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EventToolStripMenuItem
            // 
            this.EventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Event,
            this.toolStripMenuItem3,
            this.Update_EventToolStripMenuItem,
            this.toolStripMenuItem4,
            this.Delete_Event});
            this.EventToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventToolStripMenuItem.Name = "EventToolStripMenuItem";
            this.EventToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.EventToolStripMenuItem.Text = "&Событие";
            // 
            // add_Event
            // 
            this.add_Event.Name = "add_Event";
            this.add_Event.Size = new System.Drawing.Size(215, 24);
            this.add_Event.Text = "Добавить событие";
            this.add_Event.Click += new System.EventHandler(this.add_Event_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 6);
            // 
            // Update_EventToolStripMenuItem
            // 
            this.Update_EventToolStripMenuItem.Name = "Update_EventToolStripMenuItem";
            this.Update_EventToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.Update_EventToolStripMenuItem.Text = "Изменить событие";
            this.Update_EventToolStripMenuItem.Click += new System.EventHandler(this.Update_EventToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(212, 6);
            // 
            // Delete_Event
            // 
            this.Delete_Event.Name = "Delete_Event";
            this.Delete_Event.Size = new System.Drawing.Size(215, 24);
            this.Delete_Event.Text = "Удалить событие";
            this.Delete_Event.Click += new System.EventHandler(this.Delete_Event_Click);
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
            // returnFromArchiveToolStripMenuItem1
            // 
            this.returnFromArchiveToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnFromArchiveToolStripMenuItem1.Name = "returnFromArchiveToolStripMenuItem1";
            this.returnFromArchiveToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.returnFromArchiveToolStripMenuItem1.Text = "Вернуть из архива";
            this.returnFromArchiveToolStripMenuItem1.Click += new System.EventHandler(this.returnFromArchiveToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // ToolStripMenuItem_new
            // 
            this.ToolStripMenuItem_new.BackColor = System.Drawing.Color.DimGray;
            this.ToolStripMenuItem_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_new.Name = "ToolStripMenuItem_new";
            this.ToolStripMenuItem_new.Size = new System.Drawing.Size(92, 24);
            this.ToolStripMenuItem_new.Text = "Обновить";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem2.Text = "|";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1366, 39);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Добавить событие";
            this.toolStripButton4.Click += new System.EventHandler(this.add_Event_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Изменить событие";
            this.toolStripButton5.Click += new System.EventHandler(this.Update_EventToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "Удалить событие";
            this.toolStripButton6.Click += new System.EventHandler(this.Delete_Event_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Вернуть из архива";
            this.toolStripButton1.Click += new System.EventHandler(this.returnFromArchiveToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Time_lb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1366, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Time_lb
            // 
            this.Time_lb.BackColor = System.Drawing.Color.White;
            this.Time_lb.Name = "Time_lb";
            this.Time_lb.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Arhiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 329);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Arhiv_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Arhiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив событий";
            this.cms_Arhive.ResumeLayout(false);
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

        private System.Windows.Forms.ListView Arhiv_List;
        private System.Windows.Forms.ColumnHeader column_ID_;
        private System.Windows.Forms.ColumnHeader column_Name_event;
        private System.Windows.Forms.ColumnHeader columnCat_ID;
        private System.Windows.Forms.ColumnHeader column_sDate;
        private System.Windows.Forms.ColumnHeader column_fDate;
        private System.Windows.Forms.ColumnHeader column_city_;
        private System.Windows.Forms.ColumnHeader column__place;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ColumnHeader columnCol_ticket;
        private System.Windows.Forms.ColumnHeader columnSale_ticket;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_Event;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Delete_Event;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox tb_Id;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem Update_EventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnFromArchiveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_new;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cms_Arhive;
        private System.Windows.Forms.ToolStripMenuItem cms_arhive_add;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem cms_arhive_update;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem cms_arhive__delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cms_arhive_;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Time_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}