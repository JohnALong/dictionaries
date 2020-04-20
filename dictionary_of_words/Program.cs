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
            // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // // Add several more words and their definitions
            // wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            // wordsAndDefinitions.Add("Graduation", "The completion of a defined task, usually taking months or years");
            // wordsAndDefinitions.Add("Failure", "The process by which all true learning is achieved");

            // foreach(KeyValuePair<string, string> wordDef in wordsAndDefinitions) {
            //     Console.WriteLine($"{wordDef.Value} is the definition of {wordDef.Key}");
            // }
            // Console.WriteLine(wordsAndDefinitions["Graduation"]);
            // Console.WriteLine(wordsAndDefinitions["Failure"]);

            // foreach (KeyValuePair<string, string> item in wordsAndDefinitions) {
            //     string key = item.Key;
            //     string value = item.Value;
            //     Console.WriteLine($"The definition of {key} is {value}");
            // }

            // new list of dictionaries 
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");
            dictionaryOfWords.Add(excitedWord);

            Dictionary<string, string> depressedWord = new Dictionary<string, string>();
            depressedWord.Add("word", "depressed");
            depressedWord.Add("definition", "having, showing, or characterized by a lowered state of energy, enthusiasm, eagerness");
            depressedWord.Add("part of speech", "adjective");
            depressedWord.Add("example sentence", "I am depressed that going to NSS cost me my marriage");
            dictionaryOfWords.Add(depressedWord);

            Dictionary<string, string> codeWord = new Dictionary<string, string>();
            codeWord.Add("word", "code");
            codeWord.Add("definition", "the act of programming and solving problems with programming languages");
            codeWord.Add("part of speech", "verb");
            codeWord.Add("example sentence", "I only feel alive when I code.");
            dictionaryOfWords.Add(codeWord);

            foreach (Dictionary<string, string> word in dictionaryOfWords) {
                foreach(KeyValuePair<string, string> x in word) {
                    string key = x.Key;
                    string value = x.Value;
                    Console.WriteLine($"{key}: {value}");
                }
            }
            
            // foreach (KeyValuePair<string, string> item in excitedWord) {
            //     string key = item.Key;
            //     string value = item.Value;
            //     Console.WriteLine($"The {key} is {value}");
            // }
        }
    }
}
