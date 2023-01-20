using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Note1
        {
            get;
            set;
        }
        public string Note2
        {
            get;
            set;
        }
        public string Note3
        {
            get;
            set;
        }
        public string Note4
        {
            get;
            set;
        }
        public string DODN
        {
            get;
            set;
        }




    }
}
