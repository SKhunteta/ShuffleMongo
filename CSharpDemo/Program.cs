using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            string connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            var dbClient = new MongoClient(connection);
            var dbList = dbClient.ListDatabases().ToList();
            var db = dbClient.GetDatabase("myFirstDatabase");
            var collections = db.ListCollections().ToList().Select (col => col["name"]);;
           
            Console.WriteLine("The list of collections are:");
            foreach (var coll in collections)
            {
                Console.WriteLine(coll.ToString());
            }

            //Console.WriteLine(allFields);

            
        }
    }
}