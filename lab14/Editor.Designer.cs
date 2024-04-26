namespace lab14
{
    partial class Editor
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPerformer = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxVenue = new System.Windows.Forms.TextBox();
            this.textBoxNumSeats = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPerformer = new System.Windows.Forms.Label();
            this.labeldata = new System.Windows.Forms.Label();
            this.labelvenue = new System.Windows.Forms.Label();
            this.labelNumSeat = new System.Windows.Forms.Label();
            this.labelUpText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonConcert = new System.Windows.Forms.RadioButton();
            this.radioButtonFestival = new System.Windows.Forms.RadioButton();
            this.errorPerformer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorData = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorVenue = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumSeats = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorPerformer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(147, 68);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(181, 26);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxPerformer
            // 
            this.textBoxPerformer.Location = new System.Drawing.Point(147, 165);
            this.textBoxPerformer.Name = "textBoxPerformer";
            this.textBoxPerformer.Size = new System.Drawing.Size(181, 26);
            this.textBoxPerformer.TabIndex = 2;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(147, 213);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(181, 26);
            this.textBoxData.TabIndex = 3;
            // 
            // textBoxVenue
            // 
            this.textBoxVenue.Location = new System.Drawing.Point(147, 264);
            this.textBoxVenue.Name = "textBoxVenue";
            this.textBoxVenue.Size = new System.Drawing.Size(181, 26);
            this.textBoxVenue.TabIndex = 4;
            // 
            // textBoxNumSeats
            // 
            this.textBoxNumSeats.Location = new System.Drawing.Point(147, 313);
            this.textBoxNumSeats.Name = "textBoxNumSeats";
            this.textBoxNumSeats.Size = new System.Drawing.Size(181, 26);
            this.textBoxNumSeats.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(65, 71);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 20);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Id";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 118);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelPerformer
            // 
            this.labelPerformer.AutoSize = true;
            this.labelPerformer.Location = new System.Drawing.Point(65, 168);
            this.labelPerformer.Name = "labelPerformer";
            this.labelPerformer.Size = new System.Drawing.Size(79, 20);
            this.labelPerformer.TabIndex = 8;
            this.labelPerformer.Text = "Performer";
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Location = new System.Drawing.Point(65, 216);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(44, 20);
            this.labeldata.TabIndex = 9;
            this.labeldata.Text = "Data";
            // 
            // labelvenue
            // 
            this.labelvenue.AutoSize = true;
            this.labelvenue.Location = new System.Drawing.Point(65, 264);
            this.labelvenue.Name = "labelvenue";
            this.labelvenue.Size = new System.Drawing.Size(56, 20);
            this.labelvenue.TabIndex = 10;
            this.labelvenue.Text = "Venue";
            // 
            // labelNumSeat
            // 
            this.labelNumSeat.AutoSize = true;
            this.labelNumSeat.Location = new System.Drawing.Point(65, 316);
            this.labelNumSeat.Name = "labelNumSeat";
            this.labelNumSeat.Size = new System.Drawing.Size(84, 20);
            this.labelNumSeat.TabIndex = 11;
            this.labelNumSeat.Text = "NumSeats";
            // 
            // labelUpText
            // 
            this.labelUpText.AutoSize = true;
            this.labelUpText.Location = new System.Drawing.Point(143, 29);
            this.labelUpText.Name = "labelUpText";
            this.labelUpText.Size = new System.Drawing.Size(75, 20);
            this.labelUpText.TabIndex = 12;
            this.labelUpText.Text = "Edit id -> ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // radioButtonConcert
            // 
            this.radioButtonConcert.AutoSize = true;
            this.radioButtonConcert.Location = new System.Drawing.Point(147, 118);
            this.radioButtonConcert.Name = "radioButtonConcert";
            this.radioButtonConcert.Size = new System.Drawing.Size(98, 24);
            this.radioButtonConcert.TabIndex = 15;
            this.radioButtonConcert.TabStop = true;
            this.radioButtonConcert.Text = "Концерт";
            this.radioButtonConcert.UseVisualStyleBackColor = true;
            // 
            // radioButtonFestival
            // 
            this.radioButtonFestival.AutoSize = true;
            this.radioButtonFestival.Location = new System.Drawing.Point(251, 116);
            this.radioButtonFestival.Name = "radioButtonFestival";
            this.radioButtonFestival.Size = new System.Drawing.Size(121, 24);
            this.radioButtonFestival.TabIndex = 16;
            this.radioButtonFestival.TabStop = true;
            this.radioButtonFestival.Text = "Фестеваль";
            this.radioButtonFestival.UseVisualStyleBackColor = true;
            // 
            // errorPerformer
            // 
            this.errorPerformer.ContainerControl = this;
            // 
            // errorData
            // 
            this.errorData.ContainerControl = this;
            // 
            // errorVenue
            // 
            this.errorVenue.ContainerControl = this;
            // 
            // errorNumSeats
            // 
            this.errorNumSeats.ContainerControl = this;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonFestival);
            this.Controls.Add(this.radioButtonConcert);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUpText);
            this.Controls.Add(this.labelNumSeat);
            this.Controls.Add(this.labelvenue);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.labelPerformer);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxNumSeats);
            this.Controls.Add(this.textBoxVenue);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxPerformer);
            this.Controls.Add(this.textBoxId);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorPerformer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPerformer;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxVenue;
        private System.Windows.Forms.TextBox textBoxNumSeats;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPerformer;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.Label labelvenue;
        private System.Windows.Forms.Label labelNumSeat;
        private System.Windows.Forms.Label labelUpText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonConcert;
        private System.Windows.Forms.RadioButton radioButtonFestival;
        private System.Windows.Forms.ErrorProvider errorPerformer;
        private System.Windows.Forms.ErrorProvider errorData;
        private System.Windows.Forms.ErrorProvider errorVenue;
        private System.Windows.Forms.ErrorProvider errorNumSeats;
    }
}