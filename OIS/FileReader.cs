using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OIS
{
    class FileReader
    {
        public void reader()
        {

            string path = "test.txt";
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);

                string regel = reader.ReadLine();
                while (reader.EndOfStream)
                {
                    Console.WriteLine(regel);
                }
            }
            catch(IOException IOex)
            {
                Console.WriteLine(IOex.Message);
            }
            finally
            {
                
            }
        }

    }

}
