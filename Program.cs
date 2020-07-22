using System;
using System.Collections.Generic;

namespace intro
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("what is your name?");
            string firstName = Console.ReadLine();

            int mPH = 30;

            Console.WriteLine($"Hello, {firstName}");
            if (mPH > 20)
            {
                Console.WriteLine("something");
            }
            else
            {
                Console.WriteLine("something else");
            }

            // List<string> fruits = new List<string>(){
            //     "apple", "orange","kiwi", "grapes"
            // };

            // for (int i = 0; i < fruits.Count; i++)
            // {
            //     Console.WriteLine(fruits[i]);
            // }

            // foreach (string fruit in fruits)
            // {
            //     Console.WriteLine(fruit);
            // }

            // List<int> faveNums = new List<int>(){
            //     4, 3, 1, 3, 3, 3 ,3 ,3 ,3,
            // };

            // foreach (int faveNum in faveNums)
            // {
            //     Console.WriteLine(faveNum);
            // }

            // fruits.Add("potatoes");
            // fruits.ForEach(fruit => Console.WriteLine(fruit));

            // Dictionary<string, int> toysSold = new Dictionary<string, int>(){
            //     {"hotwheels", 3},
            //     {"legos", 8}
            // };

            // toysSold.Add("xbox", 7);


            // foreach (KeyValuePair<string, int> toy in toysSold)
            // {
            //     Console.WriteLine($"we sold {toy.Value} units of {toy.Key}");
            // }


            // foreach (KeyValuePair<string, int> toy in toysSold)
            // {
            //     if (toy.Value > 500)
            //     {
            //         Console.WriteLine($"we sold {toy.Value} units of {toy.Key}");
            //     }
            //     else
            //     {
            //         Console.WriteLine("we need higher sales");
            //     }
            // }
            // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
            //     {"fear", "cellardoor"},
            //     {"death", "to die"},
            //     {"eat", "to eat"}
            // };

            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"the definition of {word.Key} is {word.Value}");
            // }

            // List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // excitedWord.Add("word", "excited");
            // excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            // excitedWord.Add("part of speech", "adjective");
            // excitedWord.Add("exapmple sentence", "I am excited to learn C#!");

            // dictionaryOfWords.Add(excitedWord);

            // Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // dictionary.Add("word", "dictionary");
            // dictionary.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            // dictionary.Add("part of speech", "adjective");
            // dictionary.Add("exapmple sentence", "I am excited to learn C#!");

            // dictionaryOfWords.Add(dictionary);




            // foreach (Dictionary<string, string> dictionaryOfWord in dictionaryOfWords)
            // {
            //     foreach (KeyValuePair<string, string> wordData in dictionaryOfWord)
            //     {
            //         Console.WriteLine($"{wordData.Key}:{wordData.Value}");
            //     }

            // }


//             Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
// idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
// idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
// idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
// idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
// idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
// idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
// idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
// idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
// idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
// idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

// foreach(Dictionary<string, List<string>> idiom in idioms){
//     Console.WriteLine($"{idiom.Key}", String.Join(" ", primes))
// }


//             foreach (Dictionary<string, List<string>> idiom in idioms)
//             {
//                 foreach (KeyValuePair<string, string> wordData in dictionaryOfWord)
//                 {
//                     Console.WriteLine($"{wordData.Key}:{wordData.Value}");
//                 }

//             }


// List<string> planetList = new List<string>(){"Mercury", "Mars"};

// planetList.Add("Jupiter");
// planetList.Add("Saturn");

// planetList.ForEach(planet => Console.WriteLine(planet));

// List<string> planetList2 = new List<string>(){"Uranus", "Neptune", "Pluto"};

// planetList2.ForEach(planet2 => Console.WriteLine(planet2));




        }
    }

}