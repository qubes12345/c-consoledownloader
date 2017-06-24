using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace ConsoleApplication7
{
    class Program
    {
        /// <summary>
        /// created by qubes
        /// please do not steal credit for the program i made.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            
            try
            {
                if (args[0] == "-help")
                {
                    Console.WriteLine(@"


Usage is as follows. 

Variables: #currentdir# can be used to get the current directory of where the program is running. For example, google.com/img.img #currentdir# yes.png.
With normal usage, 2 parameters are required. The first one (arg[0]) is where you want to get the file from, the second one (args[1]) can be the #currentdir# or the save location of your file . The third one (args[2]) is for if you are doing #currentdir#, if so, then the filename must be given, or this could be for -show which is a parameter that shows the user where the path is, with #currentdir# this is the fourth paramter which is args[3]");
                    return;
                }
                if (args.Length == 0)
                {
                    Console.WriteLine(@" Incorrect Usage


Usage is as follows. 

Variables: #currentdir# can be used to get the current directory of where the program is running. For example, google.com/img.img #currentdir# yes.png.
With normal usage, 2 parameters are required. The first one (arg[0]) is where you want to get the file from, the second one (args[1]) can be the #currentdir# or the save location of your file . The third one (args[2]) is for if you are doing #currentdir#, if so, then the filename must be given, or this could be for -show which is a parameter that shows the user where the path is, with #currentdir# this is the fourth paramter which is args[3]");
                    return;
                }

            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine(@" Incorrect Usage


Usage is as follows. 

Variables: #currentdir# can be used to get the current directory of where the program is running. For example, google.com/img.img #currentdir# yes.png.
With normal usage, 2 parameters are required. The first one (arg[0]) is where you want to get the file from, the second one (args[1]) can be the #currentdir# or the save location of your file . The third one (args[2]) is for if you are doing #currentdir#, if so, then the filename must be given, or this could be for -show which is a parameter that shows the user where the path is, with #currentdir# this is the fourth paramter which is args[3]");
                //normal
                return;
            }
            catch (System.IndexOutOfRangeException)
            {
                //norma
                Console.WriteLine(@" Incorrect Usage


Usage is as follows. 

Variables: #currentdir# can be used to get the current directory of where the program is running. For example, google.com/img.img #currentdir# yes.png.
With normal usage, 2 parameters are required. The first one (arg[0]) is where you want to get the file from, the second one (args[1]) can be the #currentdir# or the save location of your file . The third one (args[2]) is for if you are doing #currentdir#, if so, then the filename must be given, or this could be for -show which is a parameter that shows the user where the path is, with #currentdir# this is the fourth paramter which is args[3]");
                return;
            }
            try
            {
                if (args[1] == "#currentdir#")
                {

                    web.DownloadFile(args[0], Environment.CurrentDirectory + "\\" + args[2]);
                    if (args[3] == "-show")
                    {
                        Console.WriteLine("File successfully saved at " + Environment.CurrentDirectory + "\\" + args[2]);
                    }
                    return;
                }
            
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //no this is nnormal the user did not specify arguments
                
                return;
            }
            catch (System.IndexOutOfRangeException)
            {
                //something
                
            }
            try
            {
                web.DownloadFile(args[0], args[1]);
                if (args[2] == "-show")
                {
                    Console.WriteLine("File successfully saved at " + args[1]);
                }
                return;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //normal
               
                return;
            }
            catch (Exception excpcatch)
            {
                Console.WriteLine(excpcatch.ToString());
                
                return;
            }
            

            
            
            

            
            
        }
    }
}
