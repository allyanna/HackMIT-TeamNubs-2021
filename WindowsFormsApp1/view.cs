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
            /*mealComboBox.SelectedIndex = 0;
            healthinessComboBox.SelectedIndex = 0;
            satisfactionComboBox.SelectedIndex = 0;*/
            
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

            //DateTime data = (DateTime)"09/02/2021";

            //string mealTime;



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


            int healthiness = 0;
            int satisfaction;

            JournalEntry entry = new JournalEntry();


            analysisBox.Text = "Out of the " + " entries you entered:\n" +
                "You rated your food an average of " + userJournal.getHealth() + " for healthiness.\n" +
                "You rated your food an average of " + userJournal.getSatisfaction() + " for satisfaction.\nThe meal most entries were entered for was ______.";




                        userJournal.getHealth().ToString();

        }

        private void analysisBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
