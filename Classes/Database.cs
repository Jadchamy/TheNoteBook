using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCalendarControl.Views;
using Rg.Plugins.Popup.Services;
using SQLite;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

using System.Collections;


namespace TheNoteBookByRibal.Classes
{

    public class Database
    {
        
        readonly SQLiteAsyncConnection _database;
        readonly SQLiteAsyncConnection _meals;
        readonly SQLiteAsyncConnection _target;
        readonly SQLiteAsyncConnection _wrkt;
        readonly SQLiteAsyncConnection _lsn;
        readonly SQLiteAsyncConnection _note;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Data>().Wait();
            _meals = new SQLiteAsyncConnection(dbPath);
            _meals.CreateTableAsync<Meals>().Wait();
            _target = new SQLiteAsyncConnection(dbPath);
            _target.CreateTableAsync<Targets>().Wait();
            _wrkt = new SQLiteAsyncConnection(dbPath);
            _wrkt.CreateTableAsync<Workout>().Wait();
            _lsn = new SQLiteAsyncConnection(dbPath);
            _lsn.CreateTableAsync<Lessons>().Wait();
            _note = new SQLiteAsyncConnection(dbPath);
            _note.CreateTableAsync<Note>().Wait();
           
        }
        
        public Task<List<Data>> GetDataAsync()
        {
            //return _database.Table<Data>().ToListAsync();
          
            string qu1 = "SELECT Titleotd FROM Data ORDER BY Id DESC LIMIT 1";
            return _database.QueryAsync < Data >(qu1);
        }
        public Task<List<Data>> GetData1Async(string H)
        {
            //return _database.Table<Data>().ToListAsync();
            // string opo = System.DateTime.Now.ToString("ddMMyyyy");
            string qu1 = "SELECT Titleotd FROM Data WHERE DOD =" + H;
            return _database.QueryAsync<Data>(qu1);
        }

        public Task <int> SaveDataAsync(Data data)
        {
           return _database.InsertAsync(data);
        }
        public Task<List<Meals>> GetMealsAsync()
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Meals ORDER BY Id DESC LIMIT 1";
            return _meals.QueryAsync<Meals>(qu1);
        }
        public Task<List<Meals>> GetMeals1Async(string H)
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Meals WHERE DODM =" + H;
            return _meals.QueryAsync<Meals>(qu1);
        }

        public Task<int> SaveMealsAsync(Meals meals)
        {
            return _meals.InsertAsync(meals);
        }
        public Task<List<Targets>> GetTargetsAsync()
        {
            // return _database.Table<Data>().ToListAsync();
            return _target.QueryAsync<Targets>("SELECT * FROM Targets ORDER BY Id DESC LIMIT 1");
        }
        public Task<List<Targets>> GetTargets1Async(string H)
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Targets WHERE DODT =" + H;
            return _target.QueryAsync<Targets>(qu1);
        }

        public Task<int> SaveTargetsAsync(Targets targets)
        {
            return _target.InsertAsync(targets);
        }
        public Task<List<Workout>> GetWorkoutAsync()
        {
            // return _database.Table<Data>().ToListAsync();
            return _wrkt.QueryAsync<Workout>("SELECT * FROM Workout ORDER BY Id DESC LIMIT 1");
        }
        public Task<List<Workout>> GetWorkout1Async(string H)
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Workout WHERE DODW =" + H;
            return _wrkt.QueryAsync<Workout>(qu1);
        }
        public Task<int> SaveWorkoutAsync(Workout wrkt)
        {
            return _wrkt.InsertAsync(wrkt);
        }
        public Task<List<Lessons>> GetLessonsAsync()
        {
            // return _database.Table<Data>().ToListAsync();
            return _lsn.QueryAsync<Lessons>("SELECT * FROM Lessons ORDER BY Id DESC LIMIT 1");
        }
        public Task<List<Lessons>> GetLessons1Async(string H)
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Lessons WHERE DODL =" + H;
            return _lsn.QueryAsync<Lessons>(qu1);
        }

        public Task<int> SaveLessonsAsync(Lessons lsn)
        {
            return _lsn.InsertAsync(lsn);
        }
        public Task<List<Note>> GetNoteAsync()
        {
            // return _database.Table<Data>().ToListAsync();
            return _note.QueryAsync<Note>("SELECT * FROM Note ORDER BY Id DESC LIMIT 1");
        }
        public Task<List<Note>> GetNote1Async(string H)
        {
            // return _database.Table<Data>().ToListAsync();
            string qu1 = "SELECT * FROM Note WHERE DODN =" + H;
            return _note.QueryAsync<Note>(qu1);
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            return _note.InsertAsync(note);
        }
      
    }
}
