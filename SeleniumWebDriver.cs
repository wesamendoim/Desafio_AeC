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
            string DadosDoCurso;

            string SobreCurso;

            ////Instanciando  a classe para abrir o navegador chrome
            ChromeDriver webDriver = new ChromeDriver();

            ///Abrindo o navegador com o link abaixo
            webDriver.Url = "https://www.alura.com.br";

            ///Se o emelento existir, envie dados para elemento
            if (webDriver.FindElement(By.Id("header-barraBusca-form-campoBusca")).Displayed)
            {
                webDriver.FindElement(By.Id("header-barraBusca-form-campoBusca")).SendKeys("RPA");

                webDriver.FindElement(By.XPath("html/body/main/section[1]/header/div/nav/div[1]/form/button")).Click();
            }
            else
            {
                return;
            }

            ///busca-resultado-nome
            if (webDriver.FindElement(By.ClassName("busca-resultado-nome")).Displayed)
            {
                webDriver.FindElement(By.ClassName("busca-resultado-nome")).Click();
            }
            else
            {
                return;
            }

            //Capturando dados iniciais do curso
            DadosDoCurso = webDriver.FindElement(By.ClassName("course-header__wrapper")).Text;

            ///Capturando dados sobre o curso, o que ira aprender, nome do professor
            SobreCurso = webDriver.FindElement(By.ClassName("course-container--instructor")).Text;
           

            

        }

    }
}
