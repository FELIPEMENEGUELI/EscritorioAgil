using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace ProjetoEscritorioAgil
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://escritorioagil.netlify.app/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //Cadastro/criarConta/
            driver.FindElement(By.XPath("//nav/child::div[2]/child::a[4]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Contrata nos");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("Contratanos@gmail.com");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("1234567");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='confirmPassword']")).SendKeys("1234567");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='seletorFuncao']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='seletorFuncao active']//div[3][@class='seletorOption']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[contains(.,'Função')]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div/child::button")).Click();
            System.Threading.Thread.Sleep(2000);
            //Login
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[contains(.,'Crie')]/parent::div/parent::div/ancestor::div[1]/descendant::input[1]")).SendKeys("Contratanos@gmail.com");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[contains(.,'Crie')]/parent::div/parent::div/ancestor::div[1]/descendant::input[2]")).SendKeys("1234567");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='primary']")).Click();
            System.Threading.Thread.Sleep(2000);
            //Criar time/projetos
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div/child::h1/parent::div/child::button[contains(.,'Adicionar')]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div/child::h1/following-sibling::input")).SendKeys("Contrata nós");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div/child::a/following::div/child::a")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[contains(.,'Detalhe do projeto')]/parent::div/child::input")).SendKeys("T2M Contrata nós");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[contains(.,'Empresa')]/parent::div/parent::div/child::input")).SendKeys("t2m - FEST");
            //saindo do projeto criado
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[name()='svg']")).Click();
            System.Threading.Thread.Sleep(2000);
            //excluir projeto
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='root']/descendant::div[31]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='root']/div/child::div[8]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='swal2-confirm swal2-styled swal2-default-outline']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='swal2-confirm swal2-styled']")).Click();
            System.Threading.Thread.Sleep(2000);
            //excluir conta
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@class = 'clickable']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[contains(.,'Meu perfil')]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div/descendant::div[11]/button[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='swal2-confirm swal2-styled swal2-default-outline']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='swal2-confirm swal2-styled']")).Click();
            

        }
    }
}