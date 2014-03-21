using System;
using Card_Detector.Model;

namespace Card_Detector
{
    internal class Program
    {
        private static void Main()
        {
            var detector = new Detector();
            var cards = Detector.TestCards;
            foreach (string card in cards)
                Console.WriteLine("{0}:{1}, checksum valid={2}\t test card={3}", card, detector.Detect(card), detector.IsValidCheckSum(card), detector.IsTestCard(card));
        }
    }
}