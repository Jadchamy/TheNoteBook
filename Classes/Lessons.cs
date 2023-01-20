using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
    public class Lessons
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string lesson1
        {
            get;
            set;
        }
        public string lesson2
        {
            get;
            set;
        }
        public string lesson3
        {
            get;
            set;
        }
        public string lesson4
        {
            get;
            set;
        }
        public string DODL
        {
            get;
            set;
        }




    }
}
