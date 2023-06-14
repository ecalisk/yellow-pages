using System.IO;

namespace yellow_pages
{
    public static class fileCheck
    {
        //CHECK IF DATABASE FILE EXISTS, IF NOT CREATE ONE
        public static void checkNCreate() 
        {
            string textFilePath = @".\database.txt";
            if (File.Exists(textFilePath)) 
            {
                //DO NOTHING AT ALL!
            }
            else 
            {
                using (FileStream fs = File.Create(textFilePath));
            }
        }
    } 
}

