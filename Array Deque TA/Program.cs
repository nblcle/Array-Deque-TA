using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Deque_TA
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string UserInput = "";
            string ArrayInput = "";
            var BaseArray = new LinkedList<int>();
 
            while (UserInput != "404")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Was soll gemacht werden?");

                Console.WriteLine("1. offer");
                Console.WriteLine("2. push");
                Console.WriteLine("3. pop");
                Console.WriteLine("4. polllast");
                Console.WriteLine("5. peekFirst");
                Console.WriteLine("6. peekLast");
                Console.WriteLine("7. size");
                Console.WriteLine("8. capacity");
                Console.WriteLine("404. Beenden");
                Console.WriteLine("------------------------------");
                UserInput = Console.ReadLine();

                int head, tail;
                head = BaseArray.First();
                tail = BaseArray.Last();

                if (UserInput == "1") //offer
                {
                    Console.WriteLine("was möchtest du einfügen?");
                    ArrayInput = Console.ReadLine();
                    BaseArray.AddLast(Convert.ToInt32(ArrayInput));
                    UserInput = "0";
                }
                else if (UserInput == "2") // push
                {
                    Console.WriteLine("was möchtest du einfügen?");
                    ArrayInput = Console.ReadLine();
                    BaseArray.AddFirst(Convert.ToInt32(ArrayInput));
                }
                else if (UserInput == "3") //pop poll
                {
                    if (BaseArray.Count() != 0)
                    {
                        BaseArray.RemoveFirst();
                    }
                    else
                    {
                        Console.WriteLine("null");
                    }
                }
                else if (UserInput == "4") // Polllast
                {
                    if (BaseArray.Count() != 0)
                    {
                        BaseArray.RemoveLast();
                    }
                    else
                    {
                        Console.WriteLine("null");
                    }
                }
                else if (UserInput == "5") // peekfirst
                {
                    if (BaseArray.Count() != 0)
                    {
                        Console.WriteLine(BaseArray.First());
                    }
                    else
                    {
                        Console.WriteLine("null");
                    }
                }
                else if (UserInput == "6") // peeklast
                {
                    if (BaseArray.Count() != 0)
                    {
                        Console.WriteLine(BaseArray.Last());
                    }
                    else
                    {
                        Console.WriteLine("null");
                    }
                }
                else if (UserInput == "7") // size
                {
                    Console.WriteLine(BaseArray.Count());
                }
                else if (UserInput == "8") // capacity
                {
                    Console.WriteLine(BaseArray.Count());

                }
                else
                {
                    Console.WriteLine("Keine Gültige Eingabe");
                }
               
            }
            

        }
        string inputCheck(String Eingabe)
        {
            int i;
            if (int.TryParse(Eingabe, out i))
            {
                return Eingabe;
            }
            else
            {
                Console.WriteLine("Bitte geb eine Zahl ein !");
            }
            return "0";

        }


    }
}
