using System.Collections.Generic;

namespace Card_Detector.Model
{
    internal class Detector
    {
        private static readonly List<Card> cardList = new List<Card>
            {
                new Card {Name = "Visa Electron", Regex = "^(4026|417500|4508|4844|491(3|7))", LengthLimits = new []{16}},
                new Card {Name = "Visa", Regex = "^4[0-9]{12}(?:[0-9]{3})?$", LengthLimits = new []{13, 16}},
                new Card {Name = "MasterCard", Regex = "^5[1-5][0-9]{14}$", LengthLimits = new []{16}},
                new Card {Name = "Maestro",Regex = "^(5018|5020|5038|6304|6759|676[1-3])",LengthLimits =new [] {12, 13, 14, 15, 16, 17, 18, 19}},
                new Card {Name = "American Express", Regex = "^3[47][0-9]{13}$", LengthLimits =new [] {15}},
                new Card {Name = "Diners Club", Regex = "^3(?:0[0-5]|[68][0-9])[0-9]{11}$", LengthLimits = new []{14,15, 16}},
                new Card {Name = "Laser", Regex = "^(6304|670[69]|6771)", LengthLimits = new []{16, 17, 18, 19}},
                new Card {Name = "Discover", Regex = "^6(?:011|5[0-9]{2})[0-9]{12}$", LengthLimits =new [] {16}},
                new Card {Name = "JCB", Regex = @"^(?:2131|1800|35\d{3})\d{11}$", LengthLimits = new []{15, 16}},
                new Card {Name = "China UnionPay", Regex = "^62|88", LengthLimits =new []{16,17,18,19}}
            };


        public string Detect(string cardnumber)
        {
            foreach (Card card in cardList)
                if (card.Check(cardnumber))
                    return card.Name;
            return string.Empty;
        }
    }
}