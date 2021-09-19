using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FoodJournal
{
    public class Journal
    {
        private Dictionary<int, JournalEntry> journal;
        public Journal()
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
            using (StreamReader sr = new StreamReader(filename))
            {
                string json = sr.ReadToEnd();
                List<string> entries = JsonConvert.DeserializeObject<List<JournalEntry>>(json);
            }

        
        }
        

       
    }
}
