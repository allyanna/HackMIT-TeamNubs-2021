
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
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
            this.noneCheckBox = new System.Windows.Forms.CheckBox();
            this.constipationCheckBox = new System.Windows.Forms.CheckBox();
            this.diarrheaCheckBox = new System.Windows.Forms.CheckBox();
            this.vomitCheckBox = new System.Windows.Forms.CheckBox();
            this.bloatCheckBox = new System.Windows.Forms.CheckBox();
            this.stomachCheckBox = new System.Windows.Forms.CheckBox();
            this.foodTextbox = new System.Windows.Forms.TextBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.analysisBox = new System.Windows.Forms.TextBox();
            this.analysisLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(277, 835);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(289, 52);
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
            this.menuStrip1.Size = new System.Drawing.Size(1289, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(632, 835);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(128, 51);
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
            this.foodJournalLabel.Location = new System.Drawing.Point(314, 55);
            this.foodJournalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodJournalLabel.Name = "foodJournalLabel";
            this.foodJournalLabel.Size = new System.Drawing.Size(342, 63);
            this.foodJournalLabel.TabIndex = 3;
            this.foodJournalLabel.Text = "Food Journal";
            this.foodJournalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mealComboBox
            // 
            this.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Other"});
            this.mealComboBox.Location = new System.Drawing.Point(590, 188);
            this.mealComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(196, 33);
            this.mealComboBox.TabIndex = 4;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(585, 160);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(178, 25);
            this.mealLabel.TabIndex = 9;
            this.mealLabel.Text = "Select your meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rate the healthiness:";
            // 
            // satisfactionComboBox
            // 
            this.satisfactionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.satisfactionComboBox.Location = new System.Drawing.Point(590, 332);
            this.satisfactionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.satisfactionComboBox.Name = "satisfactionComboBox";
            this.satisfactionComboBox.Size = new System.Drawing.Size(196, 33);
            this.satisfactionComboBox.TabIndex = 11;
            // 
            // healthinessComboBox
            // 
            this.healthinessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.healthinessComboBox.Location = new System.Drawing.Point(590, 260);
            this.healthinessComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.healthinessComboBox.Name = "healthinessComboBox";
            this.healthinessComboBox.Size = new System.Drawing.Size(196, 33);
            this.healthinessComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "How satisfied were you with the food:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Check All Symptoms:";
            // 
            // noneCheckBox
            // 
            this.noneCheckBox.AutoSize = true;
            this.noneCheckBox.Location = new System.Drawing.Point(550, 444);
            this.noneCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(92, 29);
            this.noneCheckBox.TabIndex = 15;
            this.noneCheckBox.Text = "none";
            this.noneCheckBox.UseVisualStyleBackColor = true;
            // 
            // constipationCheckBox
            // 
            this.constipationCheckBox.AutoSize = true;
            this.constipationCheckBox.Location = new System.Drawing.Point(550, 478);
            this.constipationCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.constipationCheckBox.Name = "constipationCheckBox";
            this.constipationCheckBox.Size = new System.Drawing.Size(160, 29);
            this.constipationCheckBox.TabIndex = 16;
            this.constipationCheckBox.Text = "constipation";
            this.constipationCheckBox.UseVisualStyleBackColor = true;
            // 
            // diarrheaCheckBox
            // 
            this.diarrheaCheckBox.AutoSize = true;
            this.diarrheaCheckBox.Location = new System.Drawing.Point(550, 512);
            this.diarrheaCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diarrheaCheckBox.Name = "diarrheaCheckBox";
            this.diarrheaCheckBox.Size = new System.Drawing.Size(123, 29);
            this.diarrheaCheckBox.TabIndex = 17;
            this.diarrheaCheckBox.Text = "diarrhea";
            this.diarrheaCheckBox.UseVisualStyleBackColor = true;
            // 
            // vomitCheckBox
            // 
            this.vomitCheckBox.AutoSize = true;
            this.vomitCheckBox.Location = new System.Drawing.Point(550, 546);
            this.vomitCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vomitCheckBox.Name = "vomitCheckBox";
            this.vomitCheckBox.Size = new System.Drawing.Size(124, 29);
            this.vomitCheckBox.TabIndex = 18;
            this.vomitCheckBox.Text = "vomiting";
            this.vomitCheckBox.UseVisualStyleBackColor = true;
            // 
            // bloatCheckBox
            // 
            this.bloatCheckBox.AutoSize = true;
            this.bloatCheckBox.Location = new System.Drawing.Point(716, 444);
            this.bloatCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bloatCheckBox.Name = "bloatCheckBox";
            this.bloatCheckBox.Size = new System.Drawing.Size(120, 29);
            this.bloatCheckBox.TabIndex = 19;
            this.bloatCheckBox.Text = "bloating";
            this.bloatCheckBox.UseVisualStyleBackColor = true;
            // 
            // stomachCheckBox
            // 
            this.stomachCheckBox.AutoSize = true;
            this.stomachCheckBox.Location = new System.Drawing.Point(716, 478);
            this.stomachCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stomachCheckBox.Name = "stomachCheckBox";
            this.stomachCheckBox.Size = new System.Drawing.Size(172, 29);
            this.stomachCheckBox.TabIndex = 20;
            this.stomachCheckBox.Text = "stomach pain";
            this.stomachCheckBox.UseVisualStyleBackColor = true;
            // 
            // foodTextbox
            // 
            this.foodTextbox.Location = new System.Drawing.Point(550, 641);
            this.foodTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foodTextbox.Multiline = true;
            this.foodTextbox.Name = "foodTextbox";
            this.foodTextbox.Size = new System.Drawing.Size(290, 131);
            this.foodTextbox.TabIndex = 21;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(614, 604);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(161, 25);
            this.foodLabel.TabIndex = 22;
            this.foodLabel.Text = "Foods you had:";
            // 
            // analysisBox
            // 
            this.analysisBox.Location = new System.Drawing.Point(82, 222);
            this.analysisBox.Multiline = true;
            this.analysisBox.Name = "analysisBox";
            this.analysisBox.ReadOnly = true;
            this.analysisBox.Size = new System.Drawing.Size(350, 550);
            this.analysisBox.TabIndex = 23;
            this.analysisBox.Text = resources.GetString("analysisBox.Text");
            this.analysisBox.TextChanged += new System.EventHandler(this.analysisBox_TextChanged);
            // 
            // analysisLabel
            // 
            this.analysisLabel.AutoSize = true;
            this.analysisLabel.Location = new System.Drawing.Point(77, 160);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(151, 25);
            this.analysisLabel.TabIndex = 24;
            this.analysisLabel.Text = "Your Analysis:";
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 940);
            this.Controls.Add(this.analysisLabel);
            this.Controls.Add(this.analysisBox);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodTextbox);
            this.Controls.Add(this.stomachCheckBox);
            this.Controls.Add(this.bloatCheckBox);
            this.Controls.Add(this.vomitCheckBox);
            this.Controls.Add(this.diarrheaCheckBox);
            this.Controls.Add(this.constipationCheckBox);
            this.Controls.Add(this.noneCheckBox);
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
        private System.Windows.Forms.CheckBox constipationCheckBox;
        private System.Windows.Forms.CheckBox diarrheaCheckBox;
        private System.Windows.Forms.CheckBox vomitCheckBox;
        private System.Windows.Forms.CheckBox bloatCheckBox;
        private System.Windows.Forms.CheckBox stomachCheckBox;
        private System.Windows.Forms.TextBox foodTextbox;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.CheckBox noneCheckBox;
        private System.Windows.Forms.TextBox analysisBox;
        private System.Windows.Forms.Label analysisLabel;
    }
}

