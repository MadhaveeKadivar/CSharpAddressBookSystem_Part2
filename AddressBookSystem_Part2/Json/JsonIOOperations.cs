using AddressBookSystem_Part2.FileIOOperation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Part2.Json
{
    internal class JsonIOOperations
    {
        /// <summary>
        /// Writing User's Details In JSON Files
        /// </summary>
        /// <param name="path"></param>
        /// <param name="input"></param>
        public static void WriteRecordsInJSONFile(string path,PersonInput input)
        {
            if (Program.IsFileExists(path))
            {
                string jsonData = JsonConvert.SerializeObject(input);
                if (Program.IsFileExists(path))
                {
                    File.WriteAllText(path, jsonData);
                }
                Console.WriteLine("\nData added in JSON File Successfully");
            }
        }
        /// <summary>
        /// Reading data from JSON Files
        /// </summary>
        /// <param name="path"></param>
        public static void ReadRecordsInJSONFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                PersonInput person = JsonConvert.DeserializeObject<PersonInput>(path);
                Console.WriteLine(person);
            }
        }
    }
}
