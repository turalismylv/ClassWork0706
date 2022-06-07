using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            while (true)
            {

                Console.WriteLine("1.Product elave edin  2.Product satin");
                string num = Console.ReadLine();
                bool isInt = int.TryParse(num, out int menu);

                if (isInt)
                {



                    switch (menu)
                    {
                        
                        case 1:
                            Console.WriteLine("Adin daxil edin ");
                            string name = Console.ReadLine();
                            Console.WriteLine("qiymet daxil edin");
                            string price = Console.ReadLine();
                            double pr = double.Parse(price);
                            Console.WriteLine("Say daxil edin");
                            string cnt = Console.ReadLine();
                            int count = int.Parse(cnt);
                            if (name.ToUpper()==Type.COFFE.ToString())
                            {
                                Coffe cofe = new Coffe(name, count, pr);
                                shop.Add(cofe);
                            }
                            else if (name.ToUpper()==Type.TEA.ToString())
                            {
                                Tea tea = new Tea(name, count, pr);
                                shop.Add(tea);

                            }
                            break;
                            
                           
                        default:
                            break;
                    }



                }

            }
            
        }
        enum Type { 
        COFFE,
        TEA
        
        }

    }
}

