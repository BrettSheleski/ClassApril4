using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyFamilyList
{
    public class FamilyMemberDatabase
    {

        public FamilyMemberDatabase()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string dbFileName = "familyMembers.db";

            string dbFilePath = System.IO.Path.Combine(folderPath, dbFileName);

            DbConnection = new SQLite.SQLiteConnection(dbFilePath);

            DbConnection.CreateTable<Person>();
        }

        public SQLite.SQLiteConnection DbConnection { get; private set; }

        public List<Person> GetAll()
        {
            // retrieve all Person's from the database

            SQLite.TableQuery<Person> personTable = DbConnection.Table<Person>();

            List<Person> peopleList = personTable.ToList();

            return peopleList;
        }

        public void Add(Person person)
        {
            // insert a new record into the database representing person

            DbConnection.Insert(person);

        }

    }
}
