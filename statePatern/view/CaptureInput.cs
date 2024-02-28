using System;

namespace TPDesignPartens.statePatern.view
{
    internal class CaptureInput: ICaptureInput
    {
        public CaptureInput()
        {
        }

        public int CaptureInt(string str, int rangeMin, int rangeMax)
        {
            int capture = 0;
            do
            {
                Console.WriteLine(str);
                capture = int.Parse(Console.ReadLine());
                if(capture < rangeMin || capture > rangeMax) Console.WriteLine("Value out of bound.");
            } while (capture < rangeMin || capture > rangeMax);
            return capture;
        }

        public string CaptureString(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
    }
}