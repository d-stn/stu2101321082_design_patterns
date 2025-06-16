using stu2101321082_design_patterns.singleton;

namespace stu2101321082_design_patterns {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Do you want to see the [d]emo or try your [c]ustom input? (Answer d/c)");
            string? demoAnswer = Console.ReadLine();
            while (demoAnswer == null || demoAnswer.Length > 1 || (demoAnswer[0] != 'd' && demoAnswer[0] != 'c')) {
                Console.WriteLine("That is not a valid answer. You answer with either the 'd' character or the 'c' character.");
                demoAnswer = Console.ReadLine();
            }

            Office office = Office.GetInstance();

            if (demoAnswer[0] == 'd') {
                office.ProcessPackage("Plovdiv");
                office.ProcessPackage("Sofia");
                office.ProcessPackage("Bulgaria");
                office.ProcessPackage("plovdiv");
                office.ProcessPackage("International");
                office.ProcessPackage("Bulgaria");
            }
            // Custom input case
            else {
                List<string> destinations = new List<string>();

                while (true) {
                    Console.WriteLine("Enter a destination: (you can use 'p', 'b' and 'i' for short, or enter a custom destination. Enter 'exit' to quit and see output.)");
                    string input = Console.ReadLine();
                    // Check if user wants to exit (ignore case)
                    if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase)) {
                        break;
                    }

                    input = input?.ToLower();

                    switch (input) {
                        case "p":
                            destinations.Add("Plovdiv");
                            Console.WriteLine("Added Plovdiv");
                            break;
                        case "b":
                            destinations.Add("Bulgaria");
                            Console.WriteLine("Added Bulgaria");
                            break;
                        case "i":
                            destinations.Add("International");
                            Console.WriteLine("Added International");
                            break;
                        default:
                            destinations.Add(input);
                            Console.WriteLine($"Added: {input}");
                            break;
                    }
                }

                // Process added packages
                foreach (string dest in destinations) {
                    office.ProcessPackage(dest);
                }
            }
        }
    }
}
