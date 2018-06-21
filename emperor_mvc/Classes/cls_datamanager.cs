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
