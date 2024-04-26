namespace lab14
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Performer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Venue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_of_Seats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonShowCalendar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sADASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантаженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.збереженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автозбереженняВиклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Names,
            this.Performer,
            this.Data,
            this.Venue,
            this.Number_of_Seats});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 26);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 310);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Names
            // 
            this.Names.Text = "Name";
            this.Names.Width = 90;
            // 
            // Performer
            // 
            this.Performer.Text = "Performer";
            this.Performer.Width = 175;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 140;
            // 
            // Venue
            // 
            this.Venue.Text = "Venue";
            this.Venue.Width = 194;
            // 
            // Number_of_Seats
            // 
            this.Number_of_Seats.Text = "Number of Seats";
            this.Number_of_Seats.Width = 153;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(331, 341);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 27);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(420, 340);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(85, 27);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(509, 341);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 27);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(174, 202);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // buttonShowCalendar
            // 
            this.buttonShowCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowCalendar.Location = new System.Drawing.Point(81, 340);
            this.buttonShowCalendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowCalendar.Name = "buttonShowCalendar";
            this.buttonShowCalendar.Size = new System.Drawing.Size(91, 27);
            this.buttonShowCalendar.TabIndex = 6;
            this.buttonShowCalendar.Text = "Show Calendar";
            this.buttonShowCalendar.UseVisualStyleBackColor = true;
            this.buttonShowCalendar.Click += new System.EventHandler(this.buttonShowCalendar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sADASDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sADASDToolStripMenuItem
            // 
            this.sADASDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантаженняToolStripMenuItem,
            this.збереженняToolStripMenuItem,
            this.автозбереженняВиклToolStripMenuItem});
            this.sADASDToolStripMenuItem.Name = "sADASDToolStripMenuItem";
            this.sADASDToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sADASDToolStripMenuItem.Text = "Json";
            // 
            // завантаженняToolStripMenuItem
            // 
            this.завантаженняToolStripMenuItem.Name = "завантаженняToolStripMenuItem";
            this.завантаженняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.завантаженняToolStripMenuItem.Text = "Завантаження";
            this.завантаженняToolStripMenuItem.Click += new System.EventHandler(this.завантаженняToolStripMenuItem_Click);
            // 
            // збереженняToolStripMenuItem
            // 
            this.збереженняToolStripMenuItem.Name = "збереженняToolStripMenuItem";
            this.збереженняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.збереженняToolStripMenuItem.Text = "Збереження";
            this.збереженняToolStripMenuItem.Click += new System.EventHandler(this.збереженняToolStripMenuItem_Click);
            // 
            // автозбереженняВиклToolStripMenuItem
            // 
            this.автозбереженняВиклToolStripMenuItem.Name = "автозбереженняВиклToolStripMenuItem";
            this.автозбереженняВиклToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.автозбереженняВиклToolStripMenuItem.Text = "Авто-збереження викл";
            this.автозбереженняВиклToolStripMenuItem.Click += new System.EventHandler(this.автозбереженняВиклToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 387);
            this.Controls.Add(this.buttonShowCalendar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(643, 407);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Performer;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Venue;
        private System.Windows.Forms.ColumnHeader Number_of_Seats;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonShowCalendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sADASDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантаженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem збереженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автозбереженняВиклToolStripMenuItem;
    }
}

