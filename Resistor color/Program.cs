namespace Resistor_color
{
    internal class Program
    {
        class ResistorColorCode
        {
            
            private static Dictionary<string, int> colorCodes = new Dictionary<string, int>
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

          
            public static int GetColorValue(string color)
            {
               
                color = color.ToLower();
                if (colorCodes.ContainsKey(color))
                {
                    return colorCodes[color];
                }
                else
                {
                    throw new ArgumentException($"Color '{color}' is not valid.");
                }
            }

           
            public static void DisplayColorList()
            {
                Console.WriteLine("Available colors and their values:");
                foreach (var color in colorCodes)
                {
                    Console.WriteLine($"{color.Key}: {color.Value}");
                }
            }

            static void Main(string[] args)
            {
               
                DisplayColorList();

               
                try
                {
                    Console.WriteLine("\nValue of 'red': " + GetColorValue("red"));
                    Console.WriteLine("Value of 'green': " + GetColorValue("green")); 
                    Console.WriteLine("Value of 'violet': " + GetColorValue("violet")); 
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}