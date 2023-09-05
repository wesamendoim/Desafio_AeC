using System;
using System.Web;
using System.Text;
using System.IO;
using Desafio_AeC;


namespace Desafio_AeC
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Desafio_AeC.SeleniumWebDriver.Browser();

            }
            catch(IOException ex)
            {
                Console.WriteLine("O erro é" + ex);
            }
      
        }

        
    }
}
