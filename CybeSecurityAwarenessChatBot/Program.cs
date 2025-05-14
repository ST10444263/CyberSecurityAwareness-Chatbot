using System;
using System.Collections.Generic;
using System.Media;
using System.Text.RegularExpressions;

namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        // Memory to store user details
        private static string userName;
        private static string favoriteTopic;

        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayAsciiLogo();
            WelcomeUser();
            ChatWithUser();
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                var myPlayer = new SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\Amoge\source\repos\CybeSecurityAwarenessChatBot\greeting (2).wav";
                myPlayer.LoadAsync();
                myPlayer.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while playing the sound: {ex.Message}");
            }
        }

        static void DisplayAsciiLogo()
        {
            Console.WriteLine(@"
    _____          _                           _____                    _                
   / ____|        | |                         / ____|                  | |               
  | |     __ _ ___| | ___ _ __ ___   ___ _ __| |  __ _ __ __ _ _ __ __| | ___ _ __ ___  
  | |    / _` / __| |/ _ \ '_ ` _ \ / _ \ '__| | |_ | '__/ _` | '__/ _` |/ _ \ '__/ _ \ 
  | |___| (_| \__ \ |  __/ | | | | |  __/ |  | |__| | | | (_| | | | (_| |  __/ | | (_) |
   \_____\__,_|___/_|\___|_| |_| |_|\___|_|   \_____|_|  \__,_|_|  \__,_|\___|_|  \___/ 
            ");
        }

        static void WelcomeUser()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine().Trim();

            while (!IsValidName(userName))
            {
                Console.Write("Please enter a valid name: ");
                userName = Console.ReadLine().Trim();
            }

            Console.WriteLine($"\nWelcome, {userName}! I'm here to help you stay safe online. Let's chat about Cybersecurity and online Safety.");
        }

        static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            string pattern = @"^[A-Za-z\s.'-]{2,50}$";
            return Regex.IsMatch(name, pattern);
        }

        static void ChatWithUser()
        {
            string userInput;
            while (true)
            {
                Console.WriteLine("\nWhat would you like to ask me about? (Type 'exit' to leave)");
                userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine("Thank you for chatting! Stay safe!");
                    break;
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
                else
                {
                    RespondToUser(userInput);
                }
            }
        }

        static void RespondToUser(string input)
        {
            // Normalize the input
            string normalizedInput = input.Replace("?", "").Trim().ToLower();

            // Keyword recognition
            if (normalizedInput.Contains("password"))
            {
                Console.WriteLine("Always use strong, unique passwords and consider using a password manager.");
                return;
            }
            else if (normalizedInput.Contains("scam"))
            {
                Console.WriteLine("Be alert for scams! Always verify the source before giving out any personal information.");
                return;
            }
            else if (normalizedInput.Contains("privacy"))
            {
                Console.WriteLine("Protect your privacy by adjusting your social media settings and being cautious about what you share online.");
                return;
            }

            // Random responses for common queries
            var phishingResponses = new List<string>
            {
                "Be cautious with email links and attachments. Always verify the sender.",
                "Phishing scams often look legitimate. Look for signs of fraud.",
                "Never share your personal information through email links."
            };

            if (normalizedInput.Contains("phishing"))
            {
                Random rand = new Random();
                Console.WriteLine(phishingResponses[rand.Next(phishingResponses.Count)]);
                return;
            }

            // Conversation flow and memory recall
            if (normalizedInput.Contains("favorite topic"))
            {
                if (!string.IsNullOrEmpty(favoriteTopic))
                {
                    Console.WriteLine($"You mentioned your favorite topic is {favoriteTopic}. Would you like to talk more about that?");
                }
                else
                {
                    Console.WriteLine("What's your favorite cybersecurity topic?");
                    favoriteTopic = Console.ReadLine();
                }
                return;
            }

            // General responses
            switch (normalizedInput)
            {
                case "hello":
                    Console.WriteLine("Hello! I am here to assist you :>");
                    break;
                case "how are you":
                    Console.WriteLine("I'm just a program, but I'm here to assist you!");
                    break;
                case "what do you do":
                    Console.WriteLine("I help guide you about online safety.");
                    break;
                case "what's your purpose":
                    Console.WriteLine("My purpose is to help raise awareness about cybersecurity practices.");
                    break;
                case "what can i ask you about":
                    Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
                    break;
                case "safe browsing":
                    Console.WriteLine("Use HTTPS websites, and be wary of public Wi-Fi networks.");
                    break;
                default:
                    Console.WriteLine("I didn't quite understand that. Could you rephrase or ask about a specific topic?");
                    break;
            }

            Console.WriteLine("..................");
        }
    }
}