using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ko_papir_ollo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                Random random = new Random();
                string felh;
                string gep;
                felh = "";
                gep = "";
                while (felh != "KŐ" && felh != "PAPÍR" && felh != "OLLÓ")
                {
                    Console.Write("KŐ,PAPÍR, vagy OLLÓ?: ");
                    felh = Console.ReadLine();
                    felh = felh.ToUpper();
                }
                switch(random.Next(1,4))
                {
                    case 1:
                        gep = "KŐ";
                        break;
                    case 2:
                        gep = "PAPÍR";
                        break;
                    case 3:
                        gep = "OLLÓ";
                        break ;
                }
                Console.WriteLine("A felhasználó választása: " +felh);
                Console.WriteLine("A gép választása: " +gep);

                switch (felh)
                {
                    case "KŐ":
                        if (gep == "KŐ")
                        {
                            Console.WriteLine("Döntetlen");
                        }
                        else if (gep == "PAPÍR")
                        {
                            Console.WriteLine("Vesztettél");
                        }
                        else
                        {
                            Console.WriteLine("Nyertél");
                        }
                        break;
                    case "PAPÍR":
                        if (gep == "PAPÍR")
                        {
                            Console.WriteLine("Döntetlen");
                        }
                        else if (gep == "OLLÓ")
                        {
                            Console.WriteLine("Vesztettél");
                        }
                        else
                        {
                            Console.WriteLine("Nyertél");
                        }
                        break;
                    case "OLLÓ":
                        if (gep == "OLLÓ")
                        {
                            Console.WriteLine("Döntetlen");
                        }
                        else if (gep == "KŐ")
                        {
                            Console.WriteLine("Vesztettél");
                        }
                        else
                        {
                            Console.WriteLine("Nyertél");
                        }
                        break;
                }
                Console.WriteLine("Szeretnél újra játszani?  (I=igen  ,  N=nem):  ");
            } while (Console.ReadLine().ToUpper() == "I");

          
            System.Environment.Exit(0);


            Console.ReadKey();


            
            

            
            
            
            
            
            
            
            
        }
    }
}
