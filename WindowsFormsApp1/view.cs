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
            int satisfaction = 0;

            //DateTime data = (DateTime)"09/02/2021";

            //string mealTime;

            string[] foods = foodTextbox.Lines.Select(s => s.ToLowerInvariant()).ToArray();
            //foods.ToList();

            List<string> symptoms = new List<string>();
            //todo
            

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


          

            JournalEntry entry = new JournalEntry();



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
