using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
    public class Meals
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Breakfast
        {
            get;
            set;
        }
        public string Lunch
        {
            get;
            set;
        }
        public string Snacks
        {
            get;
            set;
        }
        public string Dinner
        {
            get;
            set;
        }
        public string DODM
        {
            get;
            set;
        }



    }
}
