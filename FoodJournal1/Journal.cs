using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FoodJournal
{
    public class Journal
    {
        public Dictionary<int, JournalEntry> journal { get; set; }
        private int jID;
        public Journal()
        {
            journal = new Dictionary<int, JournalEntry>();
            jID = 0;
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
                List<JournalEntry> entries = JsonConvert.DeserializeObject<List<JournalEntry>>(json);
            }

        
        }
        

       
    }
}
