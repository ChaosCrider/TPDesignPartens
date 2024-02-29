using System;

namespace TPDesignPartens.statePatern.view
{
    internal class CaptureInput: ICaptureInput
    {
        public CaptureInput()
        {
        }

        public int CaptureInt(string prompt, int rangeMin, int rangeMax)
        {
            int capture = 0;             // Variable to store the captured integer
            bool capturedValue;          // Flag to indicate if a valid integer was captured

            do
            {
                capturedValue = true;     // Assume a valid value initially
                Console.WriteLine(prompt);  // Display the prompt message

                try
                {
                    capture = int.Parse(Console.ReadLine());  // Attempt to parse user input to an integer
                }
                catch (System.FormatException e)
                {
                    capturedValue = false;  // Set flag to false if parsing fails
                }

                // Display a message if the captured value isn't within the specified range
                if (capture < rangeMin || capture > rangeMax)
                    Console.WriteLine("Value out of bound.");

                // Display a message if no valid number was detected
                if (!capturedValue)
                    Console.WriteLine("No number detected.");

            } while (capture < rangeMin || capture > rangeMax || !capturedValue);  // Repeat no valid integer is capture

            return capture;  // Return the captured integer within the specified range
        }

        public string CaptureString(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
    }
}