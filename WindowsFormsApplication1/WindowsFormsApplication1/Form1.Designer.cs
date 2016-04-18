namespace WindowsFormsApplication1
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
            this.editSurname = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.editParent = new System.Windows.Forms.TextBox();
            this.editPesel = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editSurname
            // 
            this.editSurname.Location = new System.Drawing.Point(12, 12);
            this.editSurname.Name = "editSurname";
            this.editSurname.Size = new System.Drawing.Size(212, 22);
            this.editSurname.TabIndex = 0;
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(12, 40);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(212, 22);
            this.editName.TabIndex = 1;
            // 
            // editParent
            // 
            this.editParent.Location = new System.Drawing.Point(12, 68);
            this.editParent.Name = "editParent";
            this.editParent.Size = new System.Drawing.Size(212, 22);
            this.editParent.TabIndex = 3;
            // 
            // editPesel
            // 
            this.editPesel.Location = new System.Drawing.Point(12, 383);
            this.editPesel.Name = "editPesel";
            this.editPesel.Size = new System.Drawing.Size(212, 22);
            this.editPesel.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "M",
            "K"});
            this.comboGender.Location = new System.Drawing.Point(12, 152);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(212, 24);
            this.comboGender.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imiona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Imiona Rodziców";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data urodzenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Płeć";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(430, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(128, 48);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Dodaj";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(294, 383);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 16;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(375, 81);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(183, 324);
            this.listBox.TabIndex = 17;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Location = new System.Drawing.Point(309, 354);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(46, 17);
            this.labelOk.TabIndex = 18;
            this.labelOk.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 417);
            this.Controls.Add(this.labelOk);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.editPesel);
            this.Controls.Add(this.editParent);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.editSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editSurname;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editParent;
        private System.Windows.Forms.TextBox editPesel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelOk;
    }
}

