using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

 namespace Desafio_AeC
{
    public class SeleniumWebDriver
    {
        public static void Browser()
        {   
            ///Variavel onde será armazenados os dados
            List<string> Dados;

            ////Instanciando  a classe para abrir o navegador chrome
            ChromeDriver webDriver = new ChromeDriver();

            ///Abrindo o navegador com o link abaixo
            webDriver.Url = "https://www.alura.com.br";

            ///Se o emelento existir, envie dados para elemento
            if (webDriver.FindElement(By.Id("header-barraBusca-form-campoBusca")).Displayed)
            {
                webDriver.FindElement(By.Id("header-barraBusca-form-campoBusca")).SendKeys("RPA");

                SendKeys.Send("{ENTER}");
            }
            else
            {
                return;
            }
        }

    }
}
