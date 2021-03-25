
namespace TestForGAZIT
{
    partial class fEdform
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
            this.bSave = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbChief = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgSubs = new System.Windows.Forms.DataGridView();
            this.lSubs = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.bChPost = new System.Windows.Forms.Button();
            this.bChDivision = new System.Windows.Forms.Button();
            this.tbDivision = new System.Windows.Forms.TextBox();
            this.lDivision = new System.Windows.Forms.Label();
            this.bChChief = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.bChAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(449, 283);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(110, 31);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(565, 283);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(115, 31);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Отмена";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата рождения";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(117, 227);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(246, 23);
            this.dtpBirthDate.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 25);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(246, 23);
            this.tbLastName.TabIndex = 9;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 54);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(246, 23);
            this.tbFirstName.TabIndex = 10;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(117, 83);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(246, 23);
            this.tbSecondName.TabIndex = 11;
            this.tbSecondName.TextChanged += new System.EventHandler(this.tbSecondName_TextChanged);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(117, 112);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.ReadOnly = true;
            this.tbFullName.Size = new System.Drawing.Size(246, 23);
            this.tbFullName.TabIndex = 12;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(117, 198);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(246, 23);
            this.mtbPhone.TabIndex = 13;
            // 
            // tbChief
            // 
            this.tbChief.Location = new System.Drawing.Point(469, 28);
            this.tbChief.Name = "tbChief";
            this.tbChief.ReadOnly = true;
            this.tbChief.Size = new System.Drawing.Size(180, 23);
            this.tbChief.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Руководитель";
            // 
            // dgSubs
            // 
            this.dgSubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgSubs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgSubs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSubs.Location = new System.Drawing.Point(469, 115);
            this.dgSubs.MultiSelect = false;
            this.dgSubs.Name = "dgSubs";
            this.dgSubs.RowHeadersVisible = false;
            this.dgSubs.RowTemplate.Height = 25;
            this.dgSubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubs.Size = new System.Drawing.Size(180, 135);
            this.dgSubs.TabIndex = 16;
            // 
            // lSubs
            // 
            this.lSubs.AutoSize = true;
            this.lSubs.Location = new System.Drawing.Point(371, 120);
            this.lSubs.Name = "lSubs";
            this.lSubs.Size = new System.Drawing.Size(85, 15);
            this.lSubs.TabIndex = 17;
            this.lSubs.Text = "Подчиненные";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Убрать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Должность";
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(117, 141);
            this.tbPost.Name = "tbPost";
            this.tbPost.ReadOnly = true;
            this.tbPost.Size = new System.Drawing.Size(181, 23);
            this.tbPost.TabIndex = 21;
            // 
            // bChPost
            // 
            this.bChPost.Location = new System.Drawing.Point(296, 141);
            this.bChPost.Name = "bChPost";
            this.bChPost.Size = new System.Drawing.Size(67, 23);
            this.bChPost.TabIndex = 22;
            this.bChPost.Text = "Выбрать";
            this.bChPost.UseVisualStyleBackColor = true;
            this.bChPost.Click += new System.EventHandler(this.bChPost_Click);
            // 
            // bChDivision
            // 
            this.bChDivision.Location = new System.Drawing.Point(296, 169);
            this.bChDivision.Name = "bChDivision";
            this.bChDivision.Size = new System.Drawing.Size(67, 23);
            this.bChDivision.TabIndex = 25;
            this.bChDivision.Text = "Выбрать";
            this.bChDivision.UseVisualStyleBackColor = true;
            this.bChDivision.Click += new System.EventHandler(this.bChDivision_Click);
            // 
            // tbDivision
            // 
            this.tbDivision.Location = new System.Drawing.Point(117, 169);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.ReadOnly = true;
            this.tbDivision.Size = new System.Drawing.Size(181, 23);
            this.tbDivision.TabIndex = 24;
            // 
            // lDivision
            // 
            this.lDivision.AutoSize = true;
            this.lDivision.Location = new System.Drawing.Point(19, 172);
            this.lDivision.Name = "lDivision";
            this.lDivision.Size = new System.Drawing.Size(92, 15);
            this.lDivision.TabIndex = 23;
            this.lDivision.Text = "Подразделение";
            // 
            // bChChief
            // 
            this.bChChief.Location = new System.Drawing.Point(655, 28);
            this.bChChief.Name = "bChChief";
            this.bChChief.Size = new System.Drawing.Size(25, 23);
            this.bChChief.TabIndex = 26;
            this.bChChief.Text = "Выбрать";
            this.bChChief.UseVisualStyleBackColor = true;
            this.bChChief.Click += new System.EventHandler(this.bChChief_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(469, 62);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(180, 47);
            this.tbAddress.TabIndex = 27;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(371, 65);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(40, 15);
            this.lAddress.TabIndex = 28;
            this.lAddress.Text = "Адрес";
            // 
            // bChAddress
            // 
            this.bChAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bChAddress.Location = new System.Drawing.Point(655, 62);
            this.bChAddress.Name = "bChAddress";
            this.bChAddress.Size = new System.Drawing.Size(25, 23);
            this.bChAddress.TabIndex = 29;
            this.bChAddress.Text = "Указать";
            this.bChAddress.UseVisualStyleBackColor = true;
            this.bChAddress.Click += new System.EventHandler(this.bChAddress_Click);
            // 
            // fEdform
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(692, 326);
            this.Controls.Add(this.bChAddress);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.bChChief);
            this.Controls.Add(this.bChDivision);
            this.Controls.Add(this.tbDivision);
            this.Controls.Add(this.lDivision);
            this.Controls.Add(this.bChPost);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lSubs);
            this.Controls.Add(this.dgSubs);
            this.Controls.Add(this.tbChief);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Name = "fEdform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.fEdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox tbChief;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgSubs;
        private System.Windows.Forms.Label lSubs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.Button bChPost;
        private System.Windows.Forms.Button bChDivision;
        private System.Windows.Forms.TextBox tbDivision;
        private System.Windows.Forms.Label lDivision;
        private System.Windows.Forms.Button bChChief;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Button bChAddress;
    }
}