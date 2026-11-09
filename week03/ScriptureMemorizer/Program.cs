// Exceeding requirements:
// 1. The program keeps a small library of scriptures and picks one at random
//    each time it runs.
// 2. Only words that are still visible are chosen to hide, so every press of
//    Enter makes progress (the stretch challenge).
// 3. When a word is hidden, punctuation such as commas and periods stays
//    visible, which gives the user a clue about the sentence structure.
// 4. The user can type "hint" to reveal one hidden word when they get stuck.
// 5. A progress line shows how many words have been hidden so far.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Moroni", 10, 4),
                "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("Mosiah", 2, 17),
                "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Hidden: {scripture.GetHiddenCount()} of {scripture.GetWordCount()} words");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Great work!");
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue, type 'hint' to reveal a word, or type 'quit' to finish: ");
            string input = (Console.ReadLine() ?? "").Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealRandomWord();
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}