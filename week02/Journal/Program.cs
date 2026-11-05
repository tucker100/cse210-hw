// Exceeding requirements:
// 1. Each entry also records the user's mood, which is saved, loaded,
//    and displayed with the entry.
// 2. Loading checks whether the file exists and skips blank lines,
//    so the program does not crash on a bad file name.
// 3. Displaying an empty journal shows a friendly message.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How would you describe your mood today? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, response, mood);
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice != "5")
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}