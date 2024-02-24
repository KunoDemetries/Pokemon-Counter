namespace Pokemon_Odds_Counter
{
    partial class testing
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
            IncreaseCountBBox = new TextBox();
            DecreaseCountBBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            OddsComboBox = new ComboBox();
            CalculationComboBox = new ComboBox();
            NameBox = new TextBox();
            NameTextBox = new TextBox();
            textBox3 = new TextBox();
            SelectedSaveFileLocation = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // IncreaseCountBBox
            // 
            IncreaseCountBBox.Location = new Point(0, 76);
            IncreaseCountBBox.Name = "IncreaseCountBBox";
            IncreaseCountBBox.Size = new Size(302, 23);
            IncreaseCountBBox.TabIndex = 1;
            IncreaseCountBBox.TextChanged += IncreaseCountBBox_TextChanged;
            // 
            // DecreaseCountBBox
            // 
            DecreaseCountBBox.Location = new Point(0, 130);
            DecreaseCountBBox.Name = "DecreaseCountBBox";
            DecreaseCountBBox.Size = new Size(302, 23);
            DecreaseCountBBox.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 51);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(188, 19);
            textBox1.TabIndex = 5;
            textBox1.Text = "Increase Count Key Bind";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 105);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(188, 19);
            textBox2.TabIndex = 6;
            textBox2.Text = "Decrease Count Key Bind";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(0, 160);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(218, 19);
            textBox5.TabIndex = 7;
            textBox5.Text = "In-Game Shiny Odds Chance";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Menu;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(0, 215);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(146, 19);
            textBox6.TabIndex = 8;
            textBox6.Text = "Calculation Type";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // OddsComboBox
            // 
            OddsComboBox.FormattingEnabled = true;
            OddsComboBox.Items.AddRange(new object[] { "Gen 1 - Black/White 1 ", "--------------------------------", "Base Shiny Odds (1/8192)", "", "Black White 2 - Present Day", "--------------------------------", "Base Shiny Odds (WE/Eggs)", "NSC, NSP, Outbreak 60+", "NSC, SP3, Outbreak 60+", "Shiny Charm (WE)", "SC, SP3", "SC, NSP, Outbreak 60+", "SC, SP3, Outbreak 60+", "Shiny Charm (Eggs)", "NSC, Masuda Method", "SC, Masuda Method", "Tera Raid Encounters" });
            OddsComboBox.Location = new Point(0, 185);
            OddsComboBox.Name = "OddsComboBox";
            OddsComboBox.Size = new Size(302, 23);
            OddsComboBox.TabIndex = 9;
            OddsComboBox.SelectedIndexChanged += OddsComboBox_SelectedIndexChanged;
            // 
            // CalculationComboBox
            // 
            CalculationComboBox.FormattingEnabled = true;
            CalculationComboBox.Items.AddRange(new object[] { "Odds Not Shiny (1-Odds^count)", "100-ONS (100-(1-Odds^count))" });
            CalculationComboBox.Location = new Point(0, 236);
            CalculationComboBox.Name = "CalculationComboBox";
            CalculationComboBox.Size = new Size(302, 23);
            CalculationComboBox.TabIndex = 10;
            CalculationComboBox.SelectedIndexChanged += CalculationComboBox_SelectedIndexChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(0, 22);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(302, 23);
            NameBox.TabIndex = 11;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.Menu;
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(0, 0);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(188, 19);
            NameTextBox.TabIndex = 12;
            NameTextBox.Text = "Set Counter Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(0, 265);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(171, 19);
            textBox3.TabIndex = 13;
            textBox3.Text = "Output File Location";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // SelectedSaveFileLocation
            // 
            SelectedSaveFileLocation.Location = new Point(0, 294);
            SelectedSaveFileLocation.Name = "SelectedSaveFileLocation";
            SelectedSaveFileLocation.Size = new Size(302, 23);
            SelectedSaveFileLocation.TabIndex = 14;
            SelectedSaveFileLocation.TextChanged += SelectedSaveFileLocation_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(274, 294);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 15;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 319);
            Controls.Add(button1);
            Controls.Add(SelectedSaveFileLocation);
            Controls.Add(textBox3);
            Controls.Add(NameTextBox);
            Controls.Add(NameBox);
            Controls.Add(CalculationComboBox);
            Controls.Add(OddsComboBox);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DecreaseCountBBox);
            Controls.Add(IncreaseCountBBox);
            MaximizeBox = false;
            Name = "testing";
            Text = "Form2";
            FormClosing += testing_FormClosing;
            Load += testing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ButtonOutput;
        private TextBox IncreaseCountBBox;
        private TextBox DecreaseCountBBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox OddsComboBox;
        private ComboBox CalculationComboBox;
        private TextBox NameBox;
        private TextBox NameTextBox;
        private TextBox textBox3;
        private TextBox SelectedSaveFileLocation;
        private Button button1;
    }
}