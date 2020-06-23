using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionsDemo
{
    public static class ErrorLog
    {
        public static void LogError(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\NetIt\txt_f\ErrorLog.txt", true))
            {
                writer.WriteLine($"{ex.Message} - {DateTime.Now}");
            }
        }

    }
}
