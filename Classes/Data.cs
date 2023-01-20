using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TheNoteBookByRibal.Classes
{
   public class Data
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        
        public string Titleotd
        {
            get;
            set;
        }
        public string DOD
        {
            get;
            set;
        }




    }
}
