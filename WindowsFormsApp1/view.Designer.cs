
namespace WindowsFormsApp1
{
    partial class view
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
            this.uploadButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterButton = new System.Windows.Forms.Button();
            this.foodJournalLabel = new System.Windows.Forms.Label();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.mealLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.satisfactionComboBox = new System.Windows.Forms.ComboBox();
            this.healthinessComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.foodTextbox = new System.Windows.Forms.TextBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(369, 1035);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(385, 64);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload Existing Entries ";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(843, 1035);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(171, 63);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // foodJournalLabel
            // 
            this.foodJournalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodJournalLabel.AutoSize = true;
            this.foodJournalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.foodJournalLabel.Location = new System.Drawing.Point(419, 68);
            this.foodJournalLabel.Name = "foodJournalLabel";
            this.foodJournalLabel.Size = new System.Drawing.Size(421, 76);
            this.foodJournalLabel.TabIndex = 3;
            this.foodJournalLabel.Text = "Food Journal";
            this.foodJournalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mealComboBox
            // 
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Other"});
            this.mealComboBox.Location = new System.Drawing.Point(786, 233);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(260, 39);
            this.mealComboBox.TabIndex = 4;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(780, 198);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(234, 32);
            this.mealLabel.TabIndex = 9;
            this.mealLabel.Text = "Select your meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rate the healthiness:";
            // 
            // satisfactionComboBox
            // 
            this.satisfactionComboBox.FormattingEnabled = true;
            this.satisfactionComboBox.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.satisfactionComboBox.Location = new System.Drawing.Point(786, 412);
            this.satisfactionComboBox.Name = "satisfactionComboBox";
            this.satisfactionComboBox.Size = new System.Drawing.Size(260, 39);
            this.satisfactionComboBox.TabIndex = 11;
            // 
            // healthinessComboBox
            // 
            this.healthinessComboBox.FormattingEnabled = true;
            this.healthinessComboBox.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.healthinessComboBox.Location = new System.Drawing.Point(786, 323);
            this.healthinessComboBox.Name = "healthinessComboBox";
            this.healthinessComboBox.Size = new System.Drawing.Size(260, 39);
            this.healthinessComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "How satisfied were you with the food:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Check All Symptoms:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(734, 551);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 36);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "none";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(734, 593);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(207, 36);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "constipation";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(734, 635);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(158, 36);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "diarrhea";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(734, 677);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(160, 36);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "vomiting";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(955, 551);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(155, 36);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "bloating";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(955, 593);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(222, 36);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "stomach pain";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // foodTextbox
            // 
            this.foodTextbox.Location = new System.Drawing.Point(734, 795);
            this.foodTextbox.Multiline = true;
            this.foodTextbox.Name = "foodTextbox";
            this.foodTextbox.Size = new System.Drawing.Size(385, 162);
            this.foodTextbox.TabIndex = 21;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(819, 749);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(210, 32);
            this.foodLabel.TabIndex = 22;
            this.foodLabel.Text = "Foods you had:";
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 1165);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodTextbox);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.healthinessComboBox);
            this.Controls.Add(this.satisfactionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.foodJournalLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "view";
            this.Text = "Food Journal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label foodJournalLabel;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox satisfactionComboBox;
        private System.Windows.Forms.ComboBox healthinessComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox foodTextbox;
        private System.Windows.Forms.Label foodLabel;
    }
}

