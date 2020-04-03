using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.Arguments = "-p 1-1024 127.0.0.1";//prosesin argümanları
            ps.RedirectStandardOutput = true;//programın çıktısını yönlendir
            ps.FileName = "nmap";//programın ismi
            Process p = new Process();
            p.StartInfo = ps;
            p.Start();
            StreamReader stdout = p.StandardOutput;//nmap'in stdout'u çıktısı Console çıktısı
            StreamWriter sw = new StreamWriter("stdout.txt");
            sw.WriteLine(stdout.ReadToEnd());
            p.WaitForExit();
            Console.WriteLine("program bitti");
            Console.ReadKey(true);
        }
    }
}
