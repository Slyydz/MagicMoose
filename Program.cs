using System;
using System.Collections.Generic;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            void MainTaco()
            {

                Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Ask me a question!");
                string userInput = Console.ReadLine();
                MooseSaysFunc(userInput);
            }

            void MooseSaysFunc(string userInput)
            {
                while (userInput != "")
                {
                    List<string> response = new List<string>()
                    {
                        "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."
                    };

                    Random randInt = new Random();

                    MooseSays(response[randInt.Next(0, 19)]);
                    Console.WriteLine("Ask me a question!");
                    userInput = Console.ReadLine();
                }

                System.Environment.Exit(0);
            }

            void MooseSays(string message)
            {
                Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
            }

            MainTaco();
        }
    }
}
