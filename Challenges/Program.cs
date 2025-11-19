// See https://aka.ms/new-console-template for more information

namespace ChallengeNameSpace
{
    public class Challenges
    {
        /// <summary>
        /// Swaps the values of the two arguments.
        /// After this method has been executed the first argument will have the value of the second argument
        /// and the second argument will have the value of the first argument.
        /// </summary>
        /// <param name="number1">first number to swap</param>
        /// <param name="number2">second number to swap</param>
        public static void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        /// <summary>
        /// Finds the highest and lowest values in an array of integers.
        /// After this method has been executed the highest argument will be assigned the highest value in the array
        /// and the lowest argument will be assigned the lowest value in the array.
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <param name="highest">Will be assigned the highest value in the array</param>
        /// <param name="lowest">Will be assigned the lowest value in the array</param>
        public static void FindHighestAndLowest(int[] numbers, out int highest, out int lowest)
        {
            // your code here
            highest = int.MinValue;
            lowest = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }
                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }
           
        }

        /// <summary>
        /// Returns the most frequently occuring vowel in the input string.
        /// If more than one vowel occurs with the same frequency then the priority order is "aeiou"
        /// </summary>
        /// <param name="input">string to be examined</param>
        /// <returns>Returns most frequently occuring vowel</returns>
        public static char MostFrequentVowel(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return Convert.ToChar("0");
            }

            // your code here
            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;
            input = input.ToLower();
            input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {


                switch (input[i])
                {
                    case 'a': countA++; break;
                    case 'e': countE++; break;
                    case 'i': countI++; break;
                    case 'o': countO++; break;
                    case 'u': countU++; break;

                }

            }

            if (countA >= countE && countA >= countI && countA >= countO && countA >= countU)
            {
                string vowel = "a";

                return Convert.ToChar(vowel);
            }
            if (countE >= countA && countE >= countI && countE >= countO && countE >= countU)
            {
                string vowel = "e";
                return Convert.ToChar(vowel);
            }
            if (countI >= countA && countI >= countE && countI >= countO && countI >= countU)
            {
                string vowel = "i";
                return Convert.ToChar(vowel);
            }
            if (countO >= countA && countO >= countE && countO >= countI && countO >= countU)
            {
                string vowel = "o";
                return Convert.ToChar(vowel);

            }
            if (countU >= countA && countU >= countE && countU >= countI && countU >= countO)
            {
                string vowel = "u";
                return Convert.ToChar(vowel);
            }
            return Convert.ToChar("0");
        }

        /// <summary>
        /// This method takes a string argument and translates it to PigLatin
        /// To find out abut PigLatin refer to https://en.wikipedia.org/wiki/Pig_Latin
        /// </summary>
        /// <param name="phrase">The phrase to be translated to pig latin</param>
        /// <returns>The input translated into pig latin</returns>
        public static string PigLatinTranslator(string phrase)
        {
           
       
            if (string.IsNullOrWhiteSpace(phrase))
                return "";

            string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string word in words)
            {
                string pigWord = ConvertWord(word);
                result += pigWord + " ";
            }

            return result.Trim();
        }

        private static string ConvertWord(string word)
        {
            string lowerWord = word.ToLower();

            // If word starts with a vowel
            if ("aeiou".Contains(lowerWord[0]))
            {
                return lowerWord + "way";
            }
            else
            {
                // Handle consonant clusters (like "smile" → "ilesmay")
                int vowelIndex = -1;
                for (int i = 0; i < lowerWord.Length; i++)
                {
                    if ("aeiou".Contains(lowerWord[i]))
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                if (vowelIndex == -1)
                {
                    // No vowels at all (rare case)
                    return lowerWord + "ay";
                }

                string prefix = lowerWord.Substring(0, vowelIndex);
                string rest = lowerWord.Substring(vowelIndex);

                return rest + prefix + "ay";
            }

        }
        

        /// <summary>
        /// This method takes a number between 1 and 100 inclusive and returns
        /// a string that contains the same number in English words. If the number parameter
        /// is outside the specified range then an empty string is returned.
        /// </summary>
        /// <param name="pNumber">The number to be changed into English words</param>
        /// <returns>A string that contains the input number in English words</returns>



        //public static string NumberTranslator(int pNumber)
        //{
        //	// your code here
        //	string numberAsLetters = "";

        //	if (pNumber == 0)
        //	{
        //		return numberAsLetters;
        //	}
        //	if (pNumber > 1)
        //	{
        //              char[] numbers = pNumber.ToString().ToCharArray();
        //              string number = numberAsLetters.ToString();
        //		if (numbers.Length == 2)
        //		{
        //			// tens place
        //			//split number into chars and then switch case on the first char and the next char to concatinate a string
        //			switch (numbers[0]) 
        //			{
        //				case '1': numberAsLetters = "ten"; break;
        //				case '2': numberAsLetters = "twenty"; break;
        //				case '3': numberAsLetters = "thirty"; break;
        //				case '4': numberAsLetters = "forty"; break;
        //				case '5': numberAsLetters = "fifty"; break;
        //				case '6': numberAsLetters = "sixty"; break;
        //				case '7': numberAsLetters = "seventy"; break;
        //				case '8': numberAsLetters = "eighty"; break;
        //				case '9': numberAsLetters = "ninety"; break;
        //                  }
        //			switch (numbers[1])
        //			{
        //					case '1': numberAsLetters += " one"; break;
        //					case '2': numberAsLetters += " two"; break;
        //					case '3': numberAsLetters += " three"; break;
        //					case '4': numberAsLetters += " four"; break;
        //					case '5': numberAsLetters += " five"; break;
        //					case '6': numberAsLetters += " six"; break;
        //					case '7': numberAsLetters += " seven"; break;
        //					case '8': numberAsLetters += " eight"; break;
        //					case '9': numberAsLetters += " nine"; break;
        //				case '0': break;
        //			}
        //			return numberAsLetters;
        //              }

        //              if (numbers.Length >= 100)
        //			{
        //				switch (numbers[0])
        //				{
        //					case '1': numberAsLetters = "one hundred"; break;
        //					case '2': numberAsLetters = "two hundred"; break;
        //					case '3': numberAsLetters = "three hundred"; break;
        //					case '4': numberAsLetters = "four hundred"; break;
        //					case '5': numberAsLetters = "five hundred"; break;
        //					case '6': numberAsLetters = "six hundred"; break;
        //					case '7': numberAsLetters = "seven hundred"; break;
        //					case '8': numberAsLetters = "eight hundred"; break;
        //					case '9': numberAsLetters = "nine hundred"; break;
        //					case '0': break;
        //				}
        //				switch (numbers[1])
        //				{
        //					case '1': numberAsLetters += " ten"; break;
        //					case '2': numberAsLetters += " twenty"; break;
        //					case '3': numberAsLetters += " thirty"; break;
        //					case '4': numberAsLetters += " forty"; break;
        //					case '5': numberAsLetters += " fifty"; break;
        //					case '6': numberAsLetters += " sixty"; break;
        //					case '7': numberAsLetters += " seventy"; break;
        //					case '8': numberAsLetters += " eighty"; break;
        //					case '9': numberAsLetters += " ninety"; break;
        //					case '0': numberAsLetters += " and"; break;
        //                      }
        //				switch (numbers[2])
        //				{
        //					case '1': numberAsLetters += " one"; break;
        //					case '2': numberAsLetters += " two"; break;
        //					case '3': numberAsLetters += " three"; break;
        //					case '4': numberAsLetters += " four"; break;
        //					case '5': numberAsLetters += " five"; break;
        //					case '6': numberAsLetters += " six"; break;
        //					case '7': numberAsLetters += " seven"; break;
        //					case '8': numberAsLetters += " eight"; break;
        //					case '9': numberAsLetters += " nine"; break;
        //					case '0': break;
        //                      }
        //				return numberAsLetters;
        //                  }

        //		else
        //		{
        //			// ones place


        //                  if (numbers.Length <= 9)
        //			{
        //				switch (numbers[0]) 
        //				{
        //					case '1': numberAsLetters = "one"; break;
        //					case '2': numberAsLetters = "two"; break;
        //					case '3': numberAsLetters = "three"; break;
        //					case '4': numberAsLetters = "four"; break;
        //					case '5': numberAsLetters = "five"; break;
        //					case '6': numberAsLetters = "six"; break;
        //					case '7': numberAsLetters = "seven"; break;
        //					case '8': numberAsLetters = "eight"; break;
        //					case '9': numberAsLetters = "nine"; break;
        //                      }
        //				return numberAsLetters;
        //                  }
        //              }
        //		return numberAsLetters;
        //          }
        //}
        public static string NumberTranslator(int pNumber)
        {
            if (pNumber < 0 || pNumber > 9999)
                throw new ArgumentOutOfRangeException("Only numbers between 0 and 9999 are supported.");

            if (pNumber == 0)
                return "zero";

            string[] unitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                          "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                          "seventeen", "eighteen", "nineteen" };

            string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            if ((pNumber / 1000) > 0)
            {
                words += unitsMap[pNumber / 1000] + " thousand ";
                pNumber %= 1000;
            }

            if ((pNumber / 100) > 0)
            {
                words += unitsMap[pNumber / 100] + " hundred ";
                pNumber %= 100;
            }

            if (pNumber > 0)
            {
                if (words != "")
                    words += "and ";

                if (pNumber < 20)
                    words += unitsMap[pNumber];
                else
                {
                    words += tensMap[pNumber / 10];
                    if ((pNumber % 10) > 0)
                        words += " " + unitsMap[pNumber % 10];
                }
            }

            return words.Trim();
        }
            static void Main()
            {
                // you can make method calls here if you like
                Console.WriteLine("Hello, World!");
            Console.WriteLine(Challenges.PigLatinTranslator("Queues are an Excellent Datastructure"));
            }
        }
    }

