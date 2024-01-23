namespace Proje1
{
    partial class AJANDY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AJANDY));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_StDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_EnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.B_Send = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.T_Passw = new System.Windows.Forms.TextBox();
            this.T_SendGmail = new System.Windows.Forms.TextBox();
            this.T_exc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_Title = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_EnDate = new System.Windows.Forms.MaskedTextBox();
            this.T_StDate = new System.Windows.Forms.MaskedTextBox();
            this.T_Not = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.C_Warn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(374, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Filtreler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Oluşturulma Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(521, 347);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Title,
            this.C_Not,
            this.C_StDate,
            this.C_EnDate,
            this.C_Warn});
            this.dataGridView1.Location = new System.Drawing.Point(353, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // C_Title
            // 
            this.C_Title.HeaderText = "Title";
            this.C_Title.Name = "C_Title";
            // 
            // C_Not
            // 
            this.C_Not.HeaderText = "Notlar";
            this.C_Not.Name = "C_Not";
            // 
            // C_StDate
            // 
            this.C_StDate.HeaderText = "Başlangıç Tarihi";
            this.C_StDate.Name = "C_StDate";
            // 
            // C_EnDate
            // 
            this.C_EnDate.HeaderText = "Bitiş Tarihi";
            this.C_EnDate.Name = "C_EnDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.T_exc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.T_Title);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.B_Save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.T_EnDate);
            this.groupBox1.Controls.Add(this.T_StDate);
            this.groupBox1.Controls.Add(this.T_Not);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Kayıt Noktası";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.B_Send);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.T_Passw);
            this.groupBox2.Controls.Add(this.T_SendGmail);
            this.groupBox2.Location = new System.Drawing.Point(6, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Şifrenizi Giriniz";
            // 
            // B_Send
            // 
            this.B_Send.Location = new System.Drawing.Point(139, 62);
            this.B_Send.Name = "B_Send";
            this.B_Send.Size = new System.Drawing.Size(120, 23);
            this.B_Send.TabIndex = 2;
            this.B_Send.Text = "Gönder";
            this.B_Send.UseVisualStyleBackColor = true;
            this.B_Send.Click += new System.EventHandler(this.B_Send_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gmail giriniz";
            // 
            // T_Passw
            // 
            this.T_Passw.Location = new System.Drawing.Point(139, 38);
            this.T_Passw.Name = "T_Passw";
            this.T_Passw.PasswordChar = '*';
            this.T_Passw.Size = new System.Drawing.Size(120, 20);
            this.T_Passw.TabIndex = 0;
            // 
            // T_SendGmail
            // 
            this.T_SendGmail.Location = new System.Drawing.Point(139, 13);
            this.T_SendGmail.Name = "T_SendGmail";
            this.T_SendGmail.Size = new System.Drawing.Size(120, 20);
            this.T_SendGmail.TabIndex = 0;
            // 
            // T_exc
            // 
            this.T_exc.Location = new System.Drawing.Point(121, 243);
            this.T_exc.Mask = "00000";
            this.T_exc.Name = "T_exc";
            this.T_exc.Size = new System.Drawing.Size(100, 20);
            this.T_exc.TabIndex = 8;
            this.T_exc.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Uyarı Sıklığı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Başlık :";
            // 
            // T_Title
            // 
            this.T_Title.Location = new System.Drawing.Point(110, 39);
            this.T_Title.Name = "T_Title";
            this.T_Title.Size = new System.Drawing.Size(100, 20);
            this.T_Title.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(86, 272);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 5;
            this.B_Save.Text = "Kaydet";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kayıt Silinme Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kayıt Tarihi :";
            // 
            // T_EnDate
            // 
            this.T_EnDate.Location = new System.Drawing.Point(121, 205);
            this.T_EnDate.Mask = "00/00/0000";
            this.T_EnDate.Name = "T_EnDate";
            this.T_EnDate.Size = new System.Drawing.Size(100, 20);
            this.T_EnDate.TabIndex = 3;
            this.T_EnDate.ValidatingType = typeof(System.DateTime);
            // 
            // T_StDate
            // 
            this.T_StDate.Location = new System.Drawing.Point(121, 175);
            this.T_StDate.Mask = "00/00/0000";
            this.T_StDate.Name = "T_StDate";
            this.T_StDate.Size = new System.Drawing.Size(100, 20);
            this.T_StDate.TabIndex = 3;
            this.T_StDate.ValidatingType = typeof(System.DateTime);
            // 
            // T_Not
            // 
            this.T_Not.Location = new System.Drawing.Point(110, 78);
            this.T_Not.Name = "T_Not";
            this.T_Not.Size = new System.Drawing.Size(196, 90);
            this.T_Not.TabIndex = 2;
            this.T_Not.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notunuzu Giriniz :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // C_Warn
            // 
            this.C_Warn.HeaderText = "Uyarı Sıklığı";
            this.C_Warn.Name = "C_Warn";
            // 
            // AJANDY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AJANDY";
            this.Text = "Ajandy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T_Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox T_EnDate;
        private System.Windows.Forms.MaskedTextBox T_StDate;
        private System.Windows.Forms.RichTextBox T_Not;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_StDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_EnDate;
        private System.Windows.Forms.MaskedTextBox T_exc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_Send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox T_SendGmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox T_Passw;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Warn;
    }
}

