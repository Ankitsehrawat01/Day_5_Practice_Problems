using Day_5_Practice_Problems;

namespace Day_5_Parctice_Problems
{
    public class Program
    {
        public static void Main()
        {
            string a;
            Console.Write("Enter Program Name : ");
            a = Convert.ToString(Console.ReadLine());
            switch (a)
            {
                case "swaptwonumbers":
                    swaptwonumbers swapnum = new swaptwonumbers();
                    swapnum.swap();
                    break;
                case "flipcoin":
                    flipcoin head = new flipcoin();
                    head.flipcoinproblem();
                    break; 
                case "alphabets":
                    alphabets vowel = new alphabets();
                    vowel.alphabet();
                    break;
                case "evenodd":
                    evenodd number = new evenodd();
                    number.Num();
                    break;
                case "poweroftwo":
                    poweroftwo two = new poweroftwo();
                    two.Power();
                    break;
                case "largestnumber":
                    largestnumber greatest = new largestnumber();
                    greatest.Large();
                    break;
                case "leapyear":
                    leapyear leapyr = new leapyear();
                    leapyr.Leap();
                    break;
                case "harmonicnumbers":
                    harmonicnumbers hnumber = new harmonicnumbers();
                    hnumber.Harmonic();
                    break;
                case "factors":
                    factors primefactors = new factors();
                    primefactors.Factor();
                    break;
                default:
                    division reminder = new division();
                    reminder.Div();
                    break;

            }
        }
    }
}

