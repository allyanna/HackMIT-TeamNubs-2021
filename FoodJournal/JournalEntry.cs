using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodJournal
{
    public class JournalEntry
    {
        /*stores an id of the journal entry*/
        private int ID;
        /*stores the date of entry*/
        private DateTime date;
        /*mealtime ex. dinner*/
        private string mealtime;
        /*list of foods*/
        private List<string> food;
        /*symptoms for meal*/
        private List<string> symptoms;
        /*personal rating of healthiness*/
        private int healthiness;
        /*personal rating of satisfaction*/
        private int satisfaction;

        /// <summary>
        /// ID, date, mealtime, food, symptoms, healthiness, satisfaction
        /// </summary>
        public JournalEntry()
        {

        }

        /// <summary>
        /// ID, date, mealtime, food, symptoms, healthiness, satisfaction
        /// </summary>
        public JournalEntry(int ID, DateTime date, string mealtime, List<string> food, List<string> symptoms, int healthiness, int satisfaction)
        {
            this.ID = ID;
            this.date = date;
            this.mealtime = mealtime;
            this.food = food;
            this.symptoms = symptoms;
            this.healthiness = healthiness;
            this.satisfaction = satisfaction;
        }




    }
}
