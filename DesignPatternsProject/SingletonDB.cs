using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class SingletonDB
    {
        private static SingletonDB db = null;
        private static readonly object padlock = new object();
        SingletonDB()
        {
        }
        public static SingletonDB GetInstance()
        {
            {
                lock (padlock)
                {
                    if (db == null)
                    {
                        db = new SingletonDB();
                    }
                    
                    return db;
                }
            }
        }
        public void Logger(string message)
        {
            Console.WriteLine("logged: " + message);
        }
    }
}
