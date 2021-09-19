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

        /// <summary>
        /// Gets the id of an entry
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return ID;
        }

        /// <summary>
        /// Gets the date of the entry
        /// </summary>
        /// <returns></returns>
        public DateTime getDate()
        {
            return date;
        }

        /// <summary>
        /// Gets the meal time 
        /// ex. dinner
        /// </summary>
        /// <returns></returns>
        public string getMealtime()
        {
            return mealtime;
        }

        /// <summary>
        /// Gets the list of food for the entry
        /// </summary>
        /// <returns></returns>
        public List<string> getFoodList()
        {
            return food;
        }

        /// <summary>
        /// Sets the list of food 
        /// </summary>
        /// <param name="listOfFood"></param>
        public void setFoodList(List<string> listOfFood)
        {
            this.food = listOfFood;
        }

        /// <summary>
        /// Gets the symptoms for a meal
        /// </summary>
        /// <returns></returns>
        public List<string> getSymptoms()
        {
            return symptoms;
        }

        /// <summary>
        /// Sets the symptoms of a meal
        /// </summary>
        public void setSymptoms(List<string> symptoms)
        {
            this.symptoms = symptoms;
        }

        /// <summary>
        /// Gets the healthiness of the meal
        /// </summary>
        /// <returns></returns>
        public int getHealthiness() {
            return healthiness;
        }

        /// <summary>
        /// sets the healthiness
        /// </summary>
        /// <param name="healthiness"></param>
        public void setHealthiness(int healthiness) {
            this.healthiness = healthiness;
        }

        /// <summary>
        /// Gets the satisfaction of a meal
        /// </summary>
        /// <returns></returns>
        public int getSatisfaction() {
            return satisfaction;
        }

        /// <summary>
        /// Sets the satisfaction of a meal
        /// </summary>
        /// <param name="satisfaction"></param>
        public void setSatisfaction(int satisfaction) {
            this.satisfaction = satisfaction;
        }
    }
}
