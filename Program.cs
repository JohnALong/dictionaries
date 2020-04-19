using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main()
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Graduation", "The completion of a defined task, usually taking months or years");
            wordsAndDefinitions.Add("Failure", "The process by which all true learning is achieved");

            foreach(KeyValuePair<string, string> wordDef in wordsAndDefinitions) {
                Console.WriteLine($"{wordDef.Value} is the definition of {wordDef.Key}");
            }
            Console.WriteLine(wordsAndDefinitions["Graduation"]);
            Console.WriteLine(wordsAndDefinitions["Failure"]);

            foreach (KeyValuePair<string, string> item in wordsAndDefinitions) {
                string key = item.Key;
                string value = item.Value;
                Console.WriteLine($"The definition of {key} is {value}");
            }
            
        }
    }
}
