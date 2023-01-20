using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
    public class Targets
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Target1
        {
            get;
            set;
        }
        public string Target2
        {
            get;
            set;
        }
        public string Target3
        {
            get;
            set;
        }
        public string Target4
        {
            get;
            set;
        }
        public string Target5
        {
            get;
            set;
        }
        public string DODT
        {
            get;
            set;
        }




    }
}
