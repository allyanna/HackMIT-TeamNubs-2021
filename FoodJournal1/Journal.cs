using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FoodJournal
{
    public class Journal
    {
        public Dictionary<int, JournalEntry> journal { get; set; }
        private int jID;
        private double avgHealth;
        private double avgSatisfaction;

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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = ofd.FileName;
                    var filestream = ofd.OpenFile(); // HMMMMMM

                    using (StreamReader sr = new StreamReader(filename))
                    {
                        string json = sr.ReadToEnd();
                        List<JournalEntry> entries = JsonConvert.DeserializeObject<List<JournalEntry>>(json);

                        AnalyzeEntries(entries);
                        /*foreach (JournalEntry entry in entries)
                        {
                            Console.WriteLine(entry.getMealtime());

                        }*/
                    }
                }
            }
        }

        public void AnalyzeEntries(List<JournalEntry> entries)
        {
            // ouf of the ___ entries you entered:
            int numEntries = entries.Count;


            // you rated your food an average of ___ for healthiness
            int n = 0;
            int totalHealth = 0;
            int totalSatisf = 0;
            foreach (JournalEntry entry in entries)
            {
                totalHealth += entry.getHealthiness();
                totalSatisf += entry.getSatisfaction();

                n++;
            }

            avgHealth = (double) totalHealth / n;
            avgSatisfaction = (double) totalSatisf / n;

            

            // you rated your food an average of ___ for satisfaction
            // symptoms??
            // the most entries you entered were for _______
        }


        public double getHealth()
        {
            return avgHealth;
        }

        public double getSatisfaction()
        {
            return avgSatisfaction;
        }
        

       
    }
}
