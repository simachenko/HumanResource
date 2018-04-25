namespace UserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.expBox1 = new System.Windows.Forms.TextBox();
            this.armyButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoArmyButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.ShowButton2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Workers = new System.Windows.Forms.TabPage();
            this.workerListBox1 = new System.Windows.Forms.ListBox();
            this.DepartControl1 = new System.Windows.Forms.TabControl();
            this.AddDepartButton = new System.Windows.Forms.Button();
            this.DepBox1 = new System.Windows.Forms.TextBox();
            this.DeleteDepButton5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Workers.SuspendLayout();
            this.DepartControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox1
            // 
            this.SearchTextBox1.Location = new System.Drawing.Point(138, 28);
            this.SearchTextBox1.Name = "SearchTextBox1";
            this.SearchTextBox1.Size = new System.Drawing.Size(294, 26);
            this.SearchTextBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(682, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expBox1
            // 
            this.expBox1.Location = new System.Drawing.Point(568, 72);
            this.expBox1.Name = "expBox1";
            this.expBox1.Size = new System.Drawing.Size(30, 26);
            this.expBox1.TabIndex = 3;
            // 
            // armyButton1
            // 
            this.armyButton1.AutoSize = true;
            this.armyButton1.Location = new System.Drawing.Point(483, 30);
            this.armyButton1.Name = "armyButton1";
            this.armyButton1.Size = new System.Drawing.Size(63, 24);
            this.armyButton1.TabIndex = 4;
            this.armyButton1.TabStop = true;
            this.armyButton1.Text = "Army";
            this.armyButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name(Surname)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expirience";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(138, 72);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(294, 26);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passport Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoArmyButton1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.armyButton1);
            this.groupBox1.Controls.Add(this.expBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SearchTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // NoArmyButton1
            // 
            this.NoArmyButton1.AutoSize = true;
            this.NoArmyButton1.Location = new System.Drawing.Point(558, 30);
            this.NoArmyButton1.Name = "NoArmyButton1";
            this.NoArmyButton1.Size = new System.Drawing.Size(83, 24);
            this.NoArmyButton1.TabIndex = 9;
            this.NoArmyButton1.TabStop = true;
            this.NoArmyButton1.Text = "NoArmy";
            this.NoArmyButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(682, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ShowButton2
            // 
            this.ShowButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowButton2.ForeColor = System.Drawing.Color.Navy;
            this.ShowButton2.Location = new System.Drawing.Point(694, 322);
            this.ShowButton2.Name = "ShowButton2";
            this.ShowButton2.Size = new System.Drawing.Size(130, 23);
            this.ShowButton2.TabIndex = 9;
            this.ShowButton2.Text = "ShowInfo";
            this.ShowButton2.UseVisualStyleBackColor = true;
            this.ShowButton2.Click += new System.EventHandler(this.ShowButton2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(694, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(694, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Workers
            // 
            this.Workers.Controls.Add(this.workerListBox1);
            this.Workers.Location = new System.Drawing.Point(4, 25);
            this.Workers.Name = "Workers";
            this.Workers.Padding = new System.Windows.Forms.Padding(3);
            this.Workers.Size = new System.Drawing.Size(671, 227);
            this.Workers.TabIndex = 1;
            this.Workers.Text = "AllWorkers";
            this.Workers.UseVisualStyleBackColor = true;
            // 
            // workerListBox1
            // 
            this.workerListBox1.FormattingEnabled = true;
            this.workerListBox1.ItemHeight = 16;
            this.workerListBox1.Location = new System.Drawing.Point(0, 1);
            this.workerListBox1.Name = "workerListBox1";
            this.workerListBox1.Size = new System.Drawing.Size(666, 212);
            this.workerListBox1.TabIndex = 0;
            // 
            // DepartControl1
            // 
            this.DepartControl1.Controls.Add(this.Workers);
            this.DepartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartControl1.Location = new System.Drawing.Point(9, 137);
            this.DepartControl1.Name = "DepartControl1";
            this.DepartControl1.SelectedIndex = 0;
            this.DepartControl1.Size = new System.Drawing.Size(679, 256);
            this.DepartControl1.TabIndex = 13;
            // 
            // AddDepartButton
            // 
            this.AddDepartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepartButton.ForeColor = System.Drawing.Color.Green;
            this.AddDepartButton.Location = new System.Drawing.Point(694, 160);
            this.AddDepartButton.Name = "AddDepartButton";
            this.AddDepartButton.Size = new System.Drawing.Size(119, 23);
            this.AddDepartButton.TabIndex = 14;
            this.AddDepartButton.Text = "AddDepartament";
            this.AddDepartButton.UseVisualStyleBackColor = true;
            this.AddDepartButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // DepBox1
            // 
            this.DepBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepBox1.Location = new System.Drawing.Point(694, 189);
            this.DepBox1.Name = "DepBox1";
            this.DepBox1.Size = new System.Drawing.Size(119, 22);
            this.DepBox1.TabIndex = 15;
            this.DepBox1.Visible = false;
            // 
            // DeleteDepButton5
            // 
            this.DeleteDepButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDepButton5.ForeColor = System.Drawing.Color.Red;
            this.DeleteDepButton5.Location = new System.Drawing.Point(694, 215);
            this.DeleteDepButton5.Name = "DeleteDepButton5";
            this.DeleteDepButton5.Size = new System.Drawing.Size(119, 23);
            this.DeleteDepButton5.TabIndex = 16;
            this.DeleteDepButton5.Text = "DeleteDepart";
            this.DeleteDepButton5.UseVisualStyleBackColor = true;
            this.DeleteDepButton5.Click += new System.EventHandler(this.DeleteDepButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 411);
            this.Controls.Add(this.DeleteDepButton5);
            this.Controls.Add(this.DepBox1);
            this.Controls.Add(this.AddDepartButton);
            this.Controls.Add(this.DepartControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowButton2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ManageHumanResource";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Workers.ResumeLayout(false);
            this.DepartControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox expBox1;
        private System.Windows.Forms.RadioButton armyButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShowButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton NoArmyButton1;
        private System.Windows.Forms.TabPage Workers;
        private System.Windows.Forms.ListBox workerListBox1;
        private System.Windows.Forms.TabControl DepartControl1;
        private System.Windows.Forms.Button AddDepartButton;
        private System.Windows.Forms.TextBox DepBox1;
        private System.Windows.Forms.Button DeleteDepButton5;
    }
}

