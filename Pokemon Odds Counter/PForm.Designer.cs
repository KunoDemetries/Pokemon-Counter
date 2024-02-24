namespace Pokemon_Odds_Counter
{
    partial class PForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            NameListBox = new ListBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            NameTextBox = new TextBox();
            OddsListBox = new ListBox();
            CountListBox = new ListBox();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1, 312);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 1;
            button1.Text = "New Counter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameListBox
            // 
            NameListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NameListBox.FormattingEnabled = true;
            NameListBox.ImeMode = ImeMode.Disable;
            NameListBox.ItemHeight = 23;
            NameListBox.Location = new Point(0, 24);
            NameListBox.Name = "NameListBox";
            NameListBox.Size = new Size(154, 280);
            NameListBox.TabIndex = 0;
            NameListBox.SelectedIndexChanged += NameListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(OddsListBox);
            groupBox1.Controls.Add(CountListBox);
            groupBox1.Controls.Add(NameListBox);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 310);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(320, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(154, 19);
            textBox2.TabIndex = 15;
            textBox2.Text = "Current Odds";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(160, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(154, 19);
            textBox1.TabIndex = 14;
            textBox1.Text = "Current Count";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.Menu;
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(0, 0);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(154, 19);
            NameTextBox.TabIndex = 13;
            NameTextBox.Text = "Counter Names";
            // 
            // OddsListBox
            // 
            OddsListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OddsListBox.FormattingEnabled = true;
            OddsListBox.ImeMode = ImeMode.Disable;
            OddsListBox.ItemHeight = 23;
            OddsListBox.Location = new Point(320, 24);
            OddsListBox.Name = "OddsListBox";
            OddsListBox.Size = new Size(153, 280);
            OddsListBox.TabIndex = 2;
            OddsListBox.SelectedIndexChanged += OddsListBox_SelectedIndexChanged;
            // 
            // CountListBox
            // 
            CountListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CountListBox.FormattingEnabled = true;
            CountListBox.ImeMode = ImeMode.Disable;
            CountListBox.ItemHeight = 23;
            CountListBox.Location = new Point(160, 24);
            CountListBox.Name = "CountListBox";
            CountListBox.Size = new Size(154, 280);
            CountListBox.TabIndex = 1;
            CountListBox.SelectedIndexChanged += CountListBox_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(321, 312);
            button4.Name = "button4";
            button4.Size = new Size(154, 29);
            button4.TabIndex = 5;
            button4.Text = "Edit Selected Counter";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(161, 312);
            button3.Name = "button3";
            button3.Size = new Size(154, 29);
            button3.TabIndex = 6;
            button3.Text = "Delete Selected Counter";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // PForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 343);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PForm";
            Text = "Pokemon Odds Calculator";
            FormClosing += PForm_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox NameTextBox;
        public static ListBox CountListBox;
        public static ListBox OddsListBox;
        public static ListBox NameListBox;
    }
}