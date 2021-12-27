using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoCSharp
{
    public class MongoConnector
    {
        private string connStr = "mongodb://root:example@localhost:27017/";
        private MongoClient mongo;

        public MongoConnector()
        {
            try
            {
                mongo = new MongoClient(connStr);
                Console.WriteLine("Connection Successful");
            }
            catch (Exception err)
            {
                Console.WriteLine("Connection Failed: " + err.Message);
            }
        }

        public List<string> getDatabaseList()
        {
            var dbs = new List<string>();
            try
            {
                dbs = mongo.ListDatabaseNames().ToList();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return dbs;
        }

        public List<string> getCollectionList(string database)
        {
            var cols = new List<string>();
            try
            {
                var db = mongo.GetDatabase(database);
                cols = db.ListCollectionNames().ToList();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            return cols;
        }

        public List<BsonDocument> getDocumentList(string database, string collection)
        {
            var docs = new List<BsonDocument>();
            try
            {
                var db = mongo.GetDatabase(database);
                var col = db.GetCollection<BsonDocument>(collection);
                docs = col.Find(new BsonDocument()).ToList();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            return docs;
        }

        public void createDatabase()
        {
            
        }

        public void createCollection(string database)
        {
            
        }

        public void createDocument(string database, string collection, BsonDocument document)
        {
            
        }
    }
}