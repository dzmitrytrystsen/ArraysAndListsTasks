using System;
using System.Collections.Generic;

namespace ArraysAndListsTasks
{
    class Program
    {
        static void Main()
        {
            //When you post a message on Facebook, depending on the number of people who like your post, 
            //Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: 
            //[Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, 
            //until the user presses Enter (without supplying a name). 
            //Depending on the number of names provided, display a message based on the above pattern.

            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Continue typing names or type 'END' to finish: ");
                var input = Console.ReadLine();

                if (input.ToUpper() != "END")
                {
                    names.Add(input);
                    continue;
                }

                else if (names.Count == 1)
                {
                    Console.WriteLine("{0} likes your post.", names[0]);
                }

                else if (names.Count == 2)
                {
                    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                }

                else if (names.Count > 2)
                {
                    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
                }

                Console.WriteLine("Press any key to restart...");
                Console.ReadKey();
                Main();
            }
        }
    }
}
