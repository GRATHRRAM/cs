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