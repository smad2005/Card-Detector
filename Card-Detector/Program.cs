using System;
using Card_Detector.Model;

namespace Card_Detector
{
    internal class Program
    {
        private static void Main()
        {
            var detector = new Detector();
            var cards = new[] { "371449635398431", "30569309025904", "6011111111111117", "3530111333300000", "5555555555554444", "4111111111111111" };
            foreach (string card in cards)
                Console.WriteLine("{0}:{1}", card, detector.Detect(card));
        }
    }
}