using System;
using System.IO;
using System.Threading;

namespace BatchGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "batchgrab";
            Console.ForegroundColor = ConsoleColor.Red;
            string ver = "1.0.0";
            string ascii = @"
     /$$                   /$$               /$$                                    /$$      
    | $$                  | $$              | $$                                   | $$      
    | $$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$$| $$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$ | $$$$$$$ 
    | $$__  $$ |____  $$|_  $$_/   /$$_____/| $$__  $$ /$$__  $$ /$$__  $$|____  $$| $$__  $$
    | $$  \ $$  /$$$$$$$  | $$    | $$      | $$  \ $$| $$  \ $$| $$  \__/ /$$$$$$$| $$  \ $$
    | $$  | $$ /$$__  $$  | $$ /$$| $$      | $$  | $$| $$  | $$| $$      /$$__  $$| $$  | $$
    | $$$$$$$/|  $$$$$$$  |  $$$$/|  $$$$$$$| $$  | $$|  $$$$$$$| $$     |  $$$$$$$| $$$$$$$/
    |_______/  \_______/   \___/   \_______/|__/  |__/ \____  $$|__/      \_______/|_______/ 
                                                       /$$  \ $$                             
                                                      |  $$$$$$/                             
                                                       \______/                              ";
            Console.WriteLine(ascii);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Made by b1scoito and freddyplogins, with the help of google.   " + "v." + ver);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                              Simple, open' the .exe converted file.");
            Console.WriteLine();
            string sfuck = @"
               .--.      .-'.      .--.      .--.      .--.      .--.      .`-.      .--.
               :::::.\::::::::.\::::::::.\::::::::.\::::::::.\::::::::.\::::::::.\::::::::.\
               '      `--'      `.-'      `--'      `--'      `--'      `-.'      `--'      `
";
            Console.WriteLine(sfuck);
            FileSystemWatcher watcher = new FileSystemWatcher();
            string dir = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Temp";
            watcher.Path = dir;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            Console.ReadKey();
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(127);
            foreach (string dir in Directory.GetDirectories(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Temp\" + e.Name))
            {
                string[] dirs = Directory.GetFiles(dir + @"\", "*.bat", SearchOption.AllDirectories);
                string sourcef2 = Directory.GetCurrentDirectory();
                try
                {
                    File.Move(dirs[0], sourcef2 + @"\batchgrabbed.bat");
                    Environment.Exit(0);
                }
                catch
                {
                    Console.WriteLine("Arquivo puxado com sucesso!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
