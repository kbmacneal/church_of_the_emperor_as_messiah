using JsonFlatFileDataStore;

namespace emperor_mvc.Classes
{
    public class DataManager
    {
        public static void insert_record(response response)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<response>();

            collection.InsertOne(response);

            store.Dispose();
        }

        public static void insert_record(question question)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<question>();

            collection.InsertOne(question);

            store.Dispose();
        }

        public static void insert_record(feedback feedback)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<feedback>();

            collection.InsertOne(feedback);

            store.Dispose();
        }
    }
}