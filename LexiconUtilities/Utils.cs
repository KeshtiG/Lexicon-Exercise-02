namespace LexiconUtilities
{
    public class Utils
    {
        // Verify string input
        public static string AskForString(string prompt, string type)
        {
            bool success = false;
            string answer;

            do
            {
                Console.Write($"{prompt}: ");
                answer = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine($"You must enter a valid {type}");
                }
                else
                {
                    success = true;
                }
            } while (!success);

            return answer;
        }

        // Verify uint input
        public static uint AskForUInt(string prompt, string type)
        {

            do
            {
                string input = AskForString(prompt, type);

                if (uint.TryParse(input, out uint result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid {type}");
                }

            } while (true);
        }
    }
}
