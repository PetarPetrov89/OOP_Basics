using System;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = null;
            //
            //try
            //{
            //    var lenght = word.Length;
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //

            //
            //if (string.IsNullOrEmpty(word))
            //{
            //    Console.WriteLine("Думата не съществува");
            //}
            //else
            //{
            //    var lenght = word.Length;
            //}
            //

            try
            {
                if (string.IsNullOrEmpty(word))
                {
                    throw new CostumException();
                }
                else
                {
                    var lenght = word.Length;
                }
            }
            catch (CostumException ex)
            {
                ErrorLog.LogError(ex);
                
            }
            catch (NullReferenceException ex)
            {
                throw ex;

            }



            //Console.WriteLine(word);
        }
    }
}
