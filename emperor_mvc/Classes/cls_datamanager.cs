using System.IO;
using JsonFlatFileDataStore;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace emperor_mvc.Classes
{
    public class DataManager
    {
        public static String RandomString(Int32 length)
        {
            Random rnd = new Random();
            StringBuilder str = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                char c = (char)rnd.Next(char.MinValue, char.MaxValue);
                str.Append(c);
            }
            return str.ToString();
        }
        private static string getHash(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        public static IEnumerable<user> return_user(string username)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get user collection
            var collection = store.GetCollection<user>();

            store.Dispose();

            // Use LINQ to query items
            return collection.AsQueryable().Where(e => e.username == username);


        }
        public static user return_user(int id)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get user collection
            var collection = store.GetCollection<user>();

            store.Dispose();

            // Use LINQ to query items
            return collection.AsQueryable().Where(e => e.id == id).ToList()[0];


        }
        public static IEnumerable<user> return_user()
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get user collection
            var collection = store.GetCollection<user>();

            store.Dispose();

            // Use LINQ to query items
            return collection.AsQueryable().ToList();


        }
        public static void insert_user(string username, string email, string plaintext_pw)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<user>();

            user usr = new user();

            usr.id = return_user().Max(s => s.id) + 1;

            usr.salt_text = RandomString(4);

            usr.password = getHash(string.Concat(plaintext_pw, usr.salt_text));

            usr.username = username;
            usr.email = email;

            collection.InsertOne(usr);

            store.Dispose();
        }

        public static void insert_response(response response)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<response>();

            collection.InsertOne(response);

            store.Dispose();
        }

    }
}
