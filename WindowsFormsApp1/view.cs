using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodJournal;

namespace WindowsFormsApp1
{
    public partial class view : Form
    {
        private Journal userJournal;

        public view()
        {
            InitializeComponent();
            userJournal = new Journal();
            mealComboBox.SelectedIndex = 0;
            healthinessComboBox.SelectedIndex = 0;
            satisfactionComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// Calls the controller to upload the new inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadButton_Click(object sender, EventArgs e)
        {

            userJournal.readFiles("test.txt");
        }

        /// <summary>
        /// Adds input into the food journal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            int newID = 0; //TODO

            int healthiness = 0;

            if (healthinessComboBox.SelectedIndex == 0)
                healthiness = 10;
            else if (healthinessComboBox.SelectedIndex == 1)
                healthiness = 9;
            else if (healthinessComboBox.SelectedIndex == 2)
                healthiness = 8;
            else if (healthinessComboBox.SelectedIndex == 3)
                healthiness = 7;
            else if (healthinessComboBox.SelectedIndex == 4)
                healthiness = 6;
            else if (healthinessComboBox.SelectedIndex == 5)
                healthiness = 5;
            else if (healthinessComboBox.SelectedIndex == 6)
                healthiness = 4;
            else if (healthinessComboBox.SelectedIndex == 7)
                healthiness = 3;
            else if (healthinessComboBox.SelectedIndex == 8)
                healthiness = 2;
            else if (healthinessComboBox.SelectedIndex == 9)
                healthiness = 1;

                int satisfaction = 0;

            if (satisfactionComboBox.SelectedIndex == 0)
                satisfaction = 10;
            else if (satisfactionComboBox.SelectedIndex == 1)
                satisfaction = 9;
            else if (satisfactionComboBox.SelectedIndex == 2)
                satisfaction = 8;
            else if (satisfactionComboBox.SelectedIndex == 3)
                satisfaction = 7;
            else if (satisfactionComboBox.SelectedIndex == 4)
                satisfaction = 6;
            else if (satisfactionComboBox.SelectedIndex == 5)
                satisfaction = 5;
            else if (satisfactionComboBox.SelectedIndex == 6)
                satisfaction = 4;
            else if (satisfactionComboBox.SelectedIndex == 7)
                satisfaction = 3;
            else if (satisfactionComboBox.SelectedIndex == 8)
                satisfaction = 2;
            else 
                satisfaction = 1;
 
                    string mealTime = "Breakfast";

            if (mealComboBox.SelectedIndex == 0)
                mealTime = "Breakfast";
            else if (mealComboBox.SelectedIndex == 1)
                mealTime = "Lunch";
            else if (mealComboBox.SelectedIndex == 2)
                mealTime = "Dinner";
            else 
                mealTime = "Other";

            string[] foods = foodTextbox.Lines.Select(s => s.ToLowerInvariant()).ToArray();
            //foods.ToList();

            List<string> symptoms = new List<string>();

            if (noneCheckBox.Checked == true)
                symptoms.Add("none");
            if (constipationCheckBox.Checked == true)
                symptoms.Add("constipation");
            if (diarrheaCheckBox.Checked == true)
                symptoms.Add("diarrhea");
            if (vomitCheckBox.Checked == true)
                symptoms.Add("vomiting");
            if (bloatCheckBox.Checked == true)
                symptoms.Add("bloating");
            if (stomachCheckBox.Checked == true)
                symptoms.Add("stomach pain");

            if (symptoms.Count == 0)
                symptoms.Add("none");


            JournalEntry entry = new JournalEntry();


            analysisBox.Text = "Out of the " + " entries you entered:\n" +
                "You rated your food an average of " + userJournal.getHealth() + " for healthiness.\n" +
                "You rated your food an average of " + userJournal.getSatisfaction() + " for satisfaction.\nThe meal most entries were entered for was ______.";




                        userJournal.getHealth().ToString();

        }

        private void analysisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder helpText = new StringBuilder();
            helpText.Append("How to enter an entry:\n");
            helpText.Append("To select your meal:   select an item from the dropdown\n");
            helpText.Append("To rate the healthiness of your food:  select a number from the dropdown\n");
            helpText.Append("To rate how satisfied you were with your food: select a number from the droptown\n");
            helpText.Append("To pick your symptoms: check all that apply\n");
            helpText.Append("To input foods you had for the meal: Add a food item on each individual line\n");

            MessageBox.Show(helpText.ToString(), "Help", MessageBoxButtons.OK);
        }
    }
}
