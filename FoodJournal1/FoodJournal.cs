using System;
using System.Collections.Generic;

namespace FoodJournal
{
    public class FoodJournal
    {
        private Dictionary<int, JournalEntry> journal;
        public FoodJournal()
        {
            journal = new Dictionary<int, JournalEntry>();
        }

        //read from txt (button clicked)
        //^^ if txt is incorrect then tell user, call view

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public void readFiles(string filename) { 
        //TODO: to tell user if it was successful or not


        
        }
        

       
    }
}
