using System;
using CSharpDatabase.Connector;

namespace MongoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoConnector mongo = new MongoConnector();
            var dbs = mongo.getDatabaseList();
            var cols = mongo.getCollectionList(dbs[0]);
            var docs = mongo.getDocumentList(dbs[0], cols[0]);
        }
    }
}