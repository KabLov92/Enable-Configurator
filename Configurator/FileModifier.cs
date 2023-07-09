using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Configurator
{
    public class FileModifier
    {
        public static void ForwardNewConfig(string[] args)
        {
           ProcessStartInfo start = new ProcessStartInfo("venv/Scripts/python.exe", "Scripts/test.py");
            

            start.Arguments = string.Format("{0} {1} {2}", args[0], args[1], args[2]);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    // this prints 11
                    Console.Write(result);

                }
            }
            Console.Read();
        }
            
          

    }

    }