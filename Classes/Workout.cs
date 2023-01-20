using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Cardio
        {
            get;
            set;
        }
        public string Weights
        {
            get;
            set;
        }
        public string Yoga
        {
            get;
            set;
        }
        public string Others
        {
            get;
            set;
        }
        public string DODW
        {
            get;
            set;
        }



    }
}
