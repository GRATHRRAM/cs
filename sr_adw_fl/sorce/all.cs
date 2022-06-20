using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace str_s_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\var_file_sys-io";

            mul_io m = new mul_io();

            test();
            Console.Clear();
            Console.WriteLine("Type help if you new");
            while(true)
            {
                string input = Console.ReadLine();

                if(input == "help")
                {
                    Console.WriteLine("save");
                    Console.WriteLine("read");
                    Console.WriteLine("cc");
                    Console.WriteLine("h_dir");
                }
                else if(input == "save")
                {
                    Console.WriteLine("id: ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Contet: ");
                    string con = Console.ReadLine();
                    m.save_var(id, con, dir);
                }
                else if(input == "read")
                {
                    Console.WriteLine("id: ");
                    string id = Console.ReadLine();
                    m.read_var(id, dir);
                    Console.WriteLine($"Contet: {m.var}");
                }
                else if(input == "cc")
                {
                    Console.Clear();
                }
                else if(input == "h_dir")
                {
                    input = Console.ReadLine();
                    dir = input;
                }
            }

            void test()
            {
                Console.Clear();
                Console.WriteLine("Test starting!!!");
                s(500);
                Console.WriteLine("Checking directory");

                if (Directory.Exists(dir))
                {
                    Console.WriteLine("Directory exitst!");
                    Console.WriteLine("test of Directory, success!");
                }
                else
                {
                    Console.WriteLine("Directory not exitst");
                    Console.WriteLine("test of Directory, Filed!!!");
                    Console.WriteLine("trying fix");

                    Directory.CreateDirectory(dir);

                    if (Directory.Exists(dir))
                    {
                        Console.WriteLine("Directory exitst!");
                    }
                    else
                    {
                        Console.WriteLine("Can't do Directory!!!");
                        Console.WriteLine("Run as Administrator");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();

                        Environment.Exit(0);
                    }
                    
                }
                Console.WriteLine("Test saveing...");
                s(500);
                m.save_var("test1", "test2", dir);
                string d = dir;
                if (File.Exists(d += @"\test1"))
                {
                    Console.WriteLine("Test of file saveing, success!");
                }
                else
                {
                    Console.WriteLine("Test of file saveing, Filed!!!");
                    Console.WriteLine("Intresting...");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();

                    Environment.Exit(0);
                }
                m.read_var("test1", dir);
                string txt = m.var;
                if (txt == null)
                {
                    Console.WriteLine("Test of file reading, Filed!!!");
                    Console.WriteLine("What??,How?");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();

                    Environment.Exit(0);
                }
                Console.WriteLine(txt);
                Console.WriteLine("All test complite!");
                Console.ReadKey();
                m.del_var("test1", dir);
            }
            void s(int ss)
            {
                System.Threading.Thread.Sleep(ss);
            }
        }
    }

    class mul_io
    {
        public string var;
        public void save_var(string var_name,string con,string dir)
        {
            dir += $@"\{var_name}";
            TextWriter tw = new StreamWriter(dir);
            tw.WriteLine(con);
            tw.Close();
        }
        public void read_var(string var_name, string dir)
        {
            dir += $@"\{var_name}";
            try
            {
                TextReader tr = new StreamReader(dir);
                var = tr.ReadLine();
                tr.Close();
            }
            catch
            {
                Console.WriteLine("file not exitst");
                var = "missing";
            }
        }
        public void del_var(string var_name, string dir)
        {
            dir += $@"\{var_name}";
            File.Delete(dir);
        }
    }
}
