using System;
using System.IO;
namespace CH40_Exception_Handing_in_C
{
    class ExceptionHanding
    { }
    class Program
    {
        /*public static void Main()
        {
            StreamReader streamReader = new StreamReader(@"D:\Source Code\Learning C#\Data CH40.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }*/

        /*public static void Main()
      {
            try
            {
                StreamReader streamReader = new StreamReader(@"D:\Source Code\Learning C#\Data CH40.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
      }*/

        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"D:\Source Code\Learning C#\Data CH40.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                //Log the detail to the DB
                Console.WriteLine("Please Check if the file {0} exits", ex.FileName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
                Console.WriteLine("Finally Block");
            }
        }
    }
}
