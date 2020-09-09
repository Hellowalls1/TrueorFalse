using System;

namespace TrueorFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nAnswer True or False:");
            
            // Type your code below
            string[] questions = new string[]
            {
        "An eggplant is also known as an aubergine.", "Eggplants are a species in the nightshade family.", "According to botanical definition, eggplant is a vegetable.", "When cut open, eggplants do not oxidize.", "Eggplants were originally domesticated from the wild species bitter apple, or S. incanum."
            };

            bool[] answers = new bool[]
            {
        true, true, false, false, true
            };

            //empty array of responses with the same length as questions
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("WARNING: There are not the proper number of questions or answers. ");
            };

            int askingIndex = 0;

            //taking an answer for each question and a bunch of other shit
            foreach (string question in questions)
            {
                string input;
                bool isBool;

                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False");
                input = Console.ReadLine();


                //converting the string value to a boolean value. Will be false if user answers anything other than true

                isBool = Boolean.TryParse(input, out inputBool);

                //if isBool is not true do all of this
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();

                    //converting string value to a boolean value again
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                //storing the users response (isBool) in the responses array then incrementing the index so that the next answer is in the next indexx in the array. Since inside of a for each loop it all happens again
                responses[askingIndex] = inputBool;
                askingIndex++;

            }

            //declaring variables that will be used in next code block
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + " ");
                Console.WriteLine($"Input: {response} | Answer: {answer}");
                if (answer == response)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct! ");

        }
    }
}
