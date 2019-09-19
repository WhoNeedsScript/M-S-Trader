using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MS_Traider
{
    class Pluss500Api
    {
        static ChromeDriver driver;
        
        public Pluss500Api()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.plus500.com/?id=102068&tags=g_sr%2B105924572_cpi%2BGermanySearchBrand_cp%2B4378859972_agi%2BPlus500EngNoDynamic_agn%2Bpluss500_ks%2Bkwd-16968011321_tid%2Be_mt%2Bc_de%2Bg_nt%2B_ext%2B1004576_loc%2BUURL&gclid=CjwKCAjwq4fsBRBnEiwANTahcAEAkOIz_BuR9LdDNOJ6HAc9FNM_yGWdtfwsMcyp2yueCowxtFwFDxoCbS0QAvD_BwE&refurl=https%3A%2F%2Fwww.google.com%2F&refts=2019-09-18T22%3A56%3A53.4499690%2000%3A00&webvisitid=f42908f1-dad4-4eb1-8b3a-f112e92b4951&_ga=2.123974922.1471086993.1568847415-1084525376.1568754124&_gac=1.251357044.1568847415.CjwKCAjwq4fsBRBnEiwANTahcAEAkOIz_BuR9LdDNOJ6HAc9FNM_yGWdtfwsMcyp2yueCowxtFwFDxoCbS0QAvD_BwE");
            Thread.Sleep(3000);
        }

        public void Loggin()
        {

            driver.FindElementById("demoMode").Click();
            Thread.Sleep(3000);
            driver.FindElementById("newUserCancel").Click();
            Thread.Sleep(3000);
            driver.FindElementById("email").SendKeys("Magnus96@live.de");
            driver.FindElementById("password").SendKeys("Magnus1996");
            driver.FindElementById("submitLogin").Click();
            Thread.Sleep(3000);


        }

        public void GetAllRawResource()
        {
            driver.FindElementById("tradeNav").Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[contains(text(), 'Alle Rohstoffe')]")).Click();

        }
    }
}
