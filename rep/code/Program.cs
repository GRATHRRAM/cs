using System;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

class reder 
{
    static void Main(string[] args)
    {
        string flp = Directory.GetCurrentDirectory();
        flp = flp + @"\Game.save";
        double times = 0;
        string nn = "";
        string nl = "";
        while (true) 
        {
            Console.Clear();
            Console.WriteLine("Get Input The Game!");
            Console.WriteLine("1 : New Game");
            Console.WriteLine("2 : Load Game");
            Console.WriteLine("3 : Exit");
    
            string n = Console.ReadLine();  

            if(n == "1")
            {
                game();
            }
            if(n == "2")
            {
                read();
                game();
            }
            if(n == "3")
            {
                Console.Clear();
                break;
            } 

            void game()    
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"You type some thing: {times} times!");
                    Console.WriteLine($"Last word you type is: {nn}");
                    Console.WriteLine("If you want to exit and save type <exit>");
                    Console.WriteLine();

                    nl = Console.ReadLine();

                    if(nl != "<exit>")
                    {
                        nn = nl;
                    }

                    if(nl == "<exit>")
                    {
                        save();
                        break;
                    }
                    times += 1;
                }
            }
            void save()
            {
                File.Delete(flp);
                List<string> ls = new List<string>();
                ls.Add(times.ToString());
                ls.Add(nn);
                File.WriteAllLinesAsync(flp, ls);
            }
            void read()
            {
               string[] ln = File.ReadAllLines(flp);
               File.ReadAllLinesAsync(flp);
               string c = ln[0];
               times = Convert.ToDouble(c);
               nn = ln[1];
               
            }
        }
    }
}