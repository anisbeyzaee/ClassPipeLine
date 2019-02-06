using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Class1
{
    class Program
    {

        static void Main(string[] args)
        {

            connect("SALAM HAJI");



            void connect(String path)
            {
                ProcessStartInfo s = new ProcessStartInfo();
                s.FileName = @"C:\Program Files\Java\jdk1.8.0_131\bin\java.exe";
                //s.FileName = @"C:\Temp\JoeClassifierjava.java";
                s.WorkingDirectory = @"C:\Temp";


                s.Arguments = @"JoeClassifierJava " + path; // C:\Temp\ForestImage.png";

                s.UseShellExecute = false;   // value false causes the WorkingDirectory to be applied to fileName which is executed

                s.RedirectStandardOutput = true;

                s.RedirectStandardError = true;

                s.CreateNoWindow = true;



                Process process = new Process();

                process.StartInfo = s;

                process.Start();





                while (!process.StandardOutput.EndOfStream)

                {

                    string isFire = process.StandardOutput.ReadLine();



                    System.Windows.Forms.MessageBox.Show("isFire: " + isFire);

                    break;

                }
            }

        }
    }
}
