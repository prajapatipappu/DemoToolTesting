using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoToolTesting
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Text_Box();
            Check_Box();
            Radio_Button();
            web_Tables();
            Buttons();
            Links();
            Upload_and_Downloads();
            Dynamic_Properties();
            Broken_Link_Image();
            Practice_Form();
            Browser_Windows();
            Alerts();
            Modal_Dialogs();

            // Console.Write("Test Case Started:");
            // String FirstName = "Pappu ";
            // String LastName = "Kumar";
            // String Email = "pappukumarbcet2019@gmail.com";
            // String Gender = "Mail";
            // String Mobile = " 8507708583 ";
            // String DateOfBirth = "11 jan 2000";
            // String Subjects = "Science";
            // String Hobbies = "Sports";
            // String CurrentAddress = "Sarai";
            // String City = "NCR";
            // String SelectState = "Delhi";


            // IWebDriver Driver = new ChromeDriver();

            // Thread.Sleep(2000);

            // Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            // Thread.Sleep(2000);

            // Driver.Manage().Window.Maximize();

            // Thread.Sleep(2000);

            // Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            // Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            // Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmil.com");

            // //Driver.FindElement(By.Id("gender-radio-1")).Click();

            // Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();

            // Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            // Driver.FindElement(By.Id("dateOfBirthInput")).Click();
            // Driver.FindElement(By.Id("subjectsContainer")).SendKeys("c#");
            // Driver.FindElement(By.Id("hobbies-checkbox-1")).Click();
            // Driver.FindElement(By.Id("currentAddress")).SendKeys("vaishali");
            // Driver.FindElement(By.Id(" css-1uccc91-singleValue")).Click();
            // Driver.FindElement(By.Id("City")).Click();



            // Driver.FindElement(By.Id("submit")).Click();

            // Task.Delay(120000).Wait();

            // Console.Write("Test Case Closed:");

            // Driver.Close();
            // Driver.Quit();






            // //IWebDriver Driver = new ChromeDriver();

            // IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            // Thread.Sleep(2000);

            // Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            // string name = "Pappu Kumar";
            // string email = "pappukumarbcet2019@gmail.com";
            // string Caddress = "sarai";
            // string Paddress = "sarai";

            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("userName")).SendKeys(name);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("currentAddress")).SendKeys(Caddress);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("permanentAddress")).SendKeys(Paddress);

            // Thread.Sleep(2000);
            // js.ExecuteScript("window.scrollBy(0,500)");
            // Thread.Sleep(2000);

            // Driver.FindElement(By.Id("submit")).Click();
            // Task.Delay(2000).Wait();

            // Console.WriteLine("test case ended");


            // Driver.Close();
            // Driver.Quit();


            // //IWebDriver Driver = new ChromeDriver();
            // //Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            // //Driver.Manage().Window.Maximize();
            // //Thread.Sleep(2000);
            // //string Fname = "Pappu";
            // //string Lname = "Kumar";
            // //string email = "pappukumarbcet2019@gmail.com";
            // //string name = "8507708583";
            // //string DOB = "11 Jan 2000";
            // //string Subjects = "";
            // //string hob = "playing cricket";
            // //string cadd = "sarai";
            // //string Padd = "sarai";
            // //Driver.FindElement(By.Id("firstName")).SendKeys("pappu");
            // //Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            // //Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            // //Thread.Sleep(2000);
            // //Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            // //Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            // ////Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("11 Jan 2000");
            // //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");
            // //Driver.FindElement(By.Id("hobbies-checkbox-1")).Click();
            // //Driver.FindElement(By.Id("currentAddress")).SendKeys("sarai");
            // //Driver.FindElement(By.Id("state")).SendKeys("sarai");

            // //Driver.FindElement(By.Id("city")).SendKeys("sarai");

            // // radio button------------------------ <> -----------------------

            // Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            // // Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            // Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---impressive
            // Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//--no


            // //check box---------------------------<>

            //Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            // Driver.Manage().Window.Maximize();

            // Thread.Sleep(2000);

            // Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();




            // //Buttons------------------------ <>

            //Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);

            // Driver.FindElement(By.Id("rightClickBtn")).Click();

            // Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("addNewRecordButton")).Click();
            // Driver.FindElement(By.Id("firstName")).SendKeys("pappu");
            // Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            // Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            // Driver.FindElement(By.Id("age")).SendKeys("22");
            // Driver.FindElement(By.Id("salary")).SendKeys("2000");
            // Driver.FindElement(By.Id("department")).SendKeys("IT");
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("submit")).Click();

            // Thread.Sleep(2000);


            //// link Table------------------------<> ---------------------------------

            // Driver.Navigate().GoToUrl("https://demoqa.com/links");
            // Driver.Manage().Window.Maximize();

            // Driver.FindElement(By.Id("simpleLink")).Click();
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("dynamicLink")).Click();

            // Thread.Sleep(2000);

            // // Driver.Dispose();
            // Thread.Sleep(2000);


            //-----------------------------practice ---------------------

            /* Console.Write("Test Case Started:");

             IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
             Thread.Sleep(2000);

             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Pappu");
             Driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("Kumar");
             Driver.FindElement(By.XPath("//input[@id='userEmail']")).SendKeys("pappukumarbcet2019@gmail.com");
             Thread.Sleep(5000);

             js.ExecuteScript("window.scrollBy(0,500)");
             Thread.Sleep(5000);

             // Driver.FindElement(By.XPath("//input[@id= 'gender-radio-1']")).Click();
             //Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
             //Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//input[@id='userNumber']")).SendKeys("8507708583");
             Thread.Sleep(5000);
            //Driver.FindElement(By.XPath("//input[@type='file']")).Click();

            //Driver.FindElement(By.XPath("//div[@id='subjectsWrapper']")).SendKeys("Maths");
            //Thread.Sleep(5000);

            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"D:\incrideble india pic\IMG_20181215_192745.jpg");
            Thread.Sleep(5000);
            Driver.FindElements(By.XPath("//textarea[@id='currentAddress']"))[0].SendKeys("Sarai Vaishali Bihar");*/



            //-----------------Browser Window-----------------

            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
             ; Thread.Sleep(2000);

             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
             Thread.Sleep(5000);




             Driver.FindElement(By.XPath("//button[@id='windowButton']")).Click();
             Thread.Sleep(5000);

             Driver.FindElement(By.XPath("//button[@id='messageWindowButton']")).Click();
             Thread.Sleep(5000); */

            //-------------------Alerts----------------------------

            /*IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(5000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);


            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().SendKeys("pappu");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();*/



            //--------------------Frames-----------------


            /*IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/frames");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);

            Driver.FindElement(By.XPath("//iframe[@id='frame2']"));
            //js.ExecuteScript("arguments[0].scrollIntoView();", Element);
            Thread.Sleep(5000);*/



            //----------------------Model ---------------------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
             Thread.Sleep(2000);

             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//button[@id='showSmallModal']")).Click();
             Thread.Sleep(2000);
             Driver.FindElement(By.XPath("//button[@class='close']")).Click();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//button[@id='showLargeModal']")).Click();
             Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
             // Driver.SwitchTo().Alert().Dismiss();
             Thread.Sleep(5000); */


            //--------------nested Frame-----------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/nestedframes");
             Thread.Sleep(2000);

             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//iframe[@srcdoc='<p>Child Iframe</p>']")).Click();*/


            //--------------------------widgets Accordian----------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/accordian");
             Thread.Sleep(2000);

             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);


             Driver.FindElement(By.XPath("//div[@id='section1Heading']")).Click();
             Thread.Sleep(2000);

             js.ExecuteScript("window.scrollBy(0,500)");
             Thread.Sleep(5000);


             Driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();
             Thread.Sleep(2000);


             Driver.FindElement(By.XPath("//div[@id='section3Heading']")).Click();
             Thread.Sleep(5000);*/


            //-----------------DatePicker---------------



            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
             Driver.Manage().Window.Maximize();
             Actions action = new Actions(Driver);
             IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));

             CalInputBox.Click();

             Thread.Sleep(2000);

             action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']")))
             .KeyDown(Keys.Control)
             .SendKeys("a")
             .KeyUp(Keys.Control)
             .Perform();

             CalInputBox.SendKeys("11 Dec 2022");

             Thread.Sleep(2000); */

            // time picker

            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
             Driver.Manage().Window.Maximize();
             Actions action = new Actions(Driver);

             IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));

             CalInputBox.Click();

             Thread.Sleep(2000);

             action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']")))
             .KeyDown(Keys.Control)
             .SendKeys("a")
             .KeyUp(Keys.Control)
             .Perform();

             CalInputBox.SendKeys("11 Dec 2022  11:30PM");

             Thread.Sleep(2000);*/


            //----------------------Slider------------

            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/slider");
             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);


             Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']")).Click();
             int xOffset = 90;
             int yOffset = 0;

             Actions action = new Actions(Driver);
             action.MoveByOffset(xOffset, yOffset).Build().Perform();*/


            //---------------------Progress Bar------------


            /*IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='resetButton']")).Click();
            Thread.Sleep(2000);*/


            //------------------tabs----------------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/tabs");
             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//a[@id='demo-tab-what']")).Click();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")).Click();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//a[@id='demo-tab-use']")).Click();
             Thread.Sleep(2000); */


            //-----------------------practiceTool--------------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             js.ExecuteScript("window.scrollBy(0,500)");
             Thread.Sleep(5000);

             Driver.FindElement(By.XPath("//button[@id='toolTipButton']")).Click();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//input[@id='toolTipTextField']")).Click();
             Thread.Sleep(2000); */


            //--------------Menu


            /*  IWebDriver Driver = new ChromeDriver();
              IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
              Thread.Sleep(2000);

              Driver.Navigate().GoToUrl("https://demoqa.com/menu");
              Driver.Manage().Window.Maximize();
              Thread.Sleep(2000);

              Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 1')]")).Click();
              Thread.Sleep(2000);

              Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 2')]")).Click();
              Thread.Sleep(2000);

              Driver.FindElement(By.XPath("//a[contains(text(),'Sub Item')]")).Click();
              Thread.Sleep(2000);
              Driver.FindElement(By.XPath("//a[contains(text(),'Sub Item')]")).Click();
              Thread.Sleep(2000);
              Driver.FindElement(By.XPath("//a[contains(text(),'SUB SUB LIST »')]")).Click();
              Thread.Sleep(2000);
              Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 1')]")).Click();
              Thread.Sleep(2000); 
              Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 2')]")).Click();
              Thread.Sleep(2000);

              Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 3')]")).Click();
              Thread.Sleep(2000);  */

            //----------------Login------------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/login");
             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//button[@id='newUser']")).Click();
             Thread.Sleep(5000);

             Driver.FindElement(By.XPath("//input[@id='firstname']")).SendKeys("xyz");
             Driver.FindElement(By.XPath("//input[@id='lastname']")).SendKeys("bcet");
             Driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("xyzbcet@gmail.com");
             Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("12345");
             Thread.Sleep(5000);

             js.ExecuteScript("window.scrollBy(0,500)");
             Thread.Sleep(2000);

             Driver.FindElement(By.XPath("//button[@id='register']")).Click();
             Thread.Sleep(2000); */



            //--------------------------dragable---------------


            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);

             Driver.Navigate().GoToUrl("https://demoqa.com/dragabble");
             Driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             //Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-simple']")).Click();
             //Thread.Sleep(2000);

             IWebElement From = Driver.FindElement(By.XPath("//div[@id='dragBox']"));
             //IWebElement To= Driver.FindElement(By.XPath("//div[@id='dragBox']"));
             Thread.Sleep(5000);
             Actions act = new Actions(Driver);
             act.DragAndDropToOffset(From, 250,150).Build().Perform();*/

        }

        private static void Text_Box()
        {
            /*IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Pappu Kumar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("currentAddress")).SendKeys("sarai, vaishali, Bihar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("permanentAddress")).SendKeys("Same As Current Address");

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();
            Task.Delay(2000).Wait();

            Console.WriteLine("test case ended");


            Driver.Close();
            Driver.Quit();*/




        }
        private static void Check_Box()
        {
            /* IWebDriver Driver = new ChromeDriver();
             IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
             Thread.Sleep(2000);
             Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
             Driver.Manage().Window.Maximize();

             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
             Thread.Sleep(2000);
             js.ExecuteScript("window.scrollBy(0,200)");
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[2].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[3].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[6].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[7].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[8].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[10].Click();
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[11].Click();
             Thread.Sleep(2000);
             js.ExecuteScript("window.scrollBy(0,200)");
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[12].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[13].Click();
             Thread.Sleep(2000);
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[15].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[16].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
             Thread.Sleep(2000);
             js.ExecuteScript("window.scrollBy(0,-200)");
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
             Thread.Sleep(2000);
             Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
             Thread.Sleep(2000);
             Driver.Close();

             Driver.Quit();*/

        }
        private static void Radio_Button()
        {
           /* IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//---impressive
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[2].Click();//--no
            IWebElement button = Driver.FindElement(By.XPath("//label[@for='noRadio']"));
            js.ExecuteScript("arguments[0].click()", button);
            Thread.Sleep(2000);
            Driver.Close();

            Driver.Quit();*/


        }
        private static void web_Tables()
        {
           /* IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("addNewRecordButton")).Click();
            Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Driver.FindElement(By.Id("age")).SendKeys("21");
            Driver.FindElement(By.Id("salary")).SendKeys("5000");
            Driver.FindElement(By.Id("department")).SendKeys("IT");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("submit")).Click();

            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();*/
        }
        private static void Buttons()
        {
          /*  IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            right_click(Driver);
            double_click(Driver);
            

        }
        private static void right_click(IWebDriver Driver)

        {
            Actions action = new Actions(Driver);
            IWebElement el = Driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(el).Perform();
            Thread.Sleep(2000);

        }
        private static void double_click(IWebDriver Driver)
        {

            Actions actions = new Actions(Driver);
            IWebElement ele = Driver.FindElement(By.Id("doubleClickBtn"));
            actions.DoubleClick(ele).Perform();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit(); */
        }
        private static void Links()
        {
           /* IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("simpleLink")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit(); */
        }
        private static void Upload_and_Downloads()
        {
           /* IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
   
            Driver.FindElement(By.Id("uploadFile")).SendKeys(@"D:\incrideble india pic\IMG_20181215_192745.jpg");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();*/

        }
        private static void Dynamic_Properties()
        {

        }
        private static void Broken_Link_Image()
        {
           /* IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);


            Driver.Navigate().GoToUrl("https://demoqa.com/broken");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
           
            //Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Valid Link')]")).Click();
            //Driver.FindElement(By.XPath("//a[@href='http://demoqa.com']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window scrrolBy(0,200)");
            Thread.Sleep(2000);

            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);
            js.ExecuteScript("window scrrolBy(0,200)");
            Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Broken Link')]")).Click();

            string r = Driver.WindowHandles[1];

            string s = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(r);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(s);
            Thread.Sleep(2000);


            //Driver.Close();
            //Driver.Quit();*/
        }
        private static void Practice_Form()
        {

            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            practice(Driver);

        }
        private static void practice(IWebDriver Driver)
        {
           /* IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(3000);

            CalInputBox.Click();
            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("11 Jan 2000");

            Thread.Sleep(3000);



            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");
           
            //Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']")).Click();
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(2000);
            
            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"D:\incrideble india pic\IMG_20181215_192745.jpg");

            Driver.Close();
            Driver.Quit();*/
        }
        private static void Browser_Windows()
        {
          /*  IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Driver.Manage().Window.Maximize();
            new_tab(Driver);
            new_window(Driver);
            new_window_messsage(Driver);

        }
        private static void new_tab(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("tabButton")).Click();
            string c = Driver.WindowHandles[1];
            string p = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(c);
            Thread.Sleep(2000);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);
            Thread.Sleep(2000);
        }
        private static void new_window(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("windowButton")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

        }
        private static void new_window_messsage(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("messageWindowButton")).Click();
            string y = Driver.WindowHandles[1];
            string z = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(y);
            //Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(z);
            Driver.Close();
            Driver.Quit();*/
        }
        private static void Alerts()
        {
          /* IWebDriver Driver = new ChromeDriver();
           IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           Thread.Sleep(2000);

           Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
           Thread.Sleep(2000);

           Driver.Manage().Window.Maximize();
           Thread.Sleep(2000);

           Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
           Driver.SwitchTo().Alert().Accept();
           Thread.Sleep(2000);


           Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
           Thread.Sleep(5000);
           Driver.SwitchTo().Alert().Accept();
           Thread.Sleep(2000);


           Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
           Driver.SwitchTo().Alert().Accept();
           Thread.Sleep(2000);

           js.ExecuteScript("window.scrollBy(0,500)");
           Thread.Sleep(5000);


           Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
           Thread.Sleep(2000);
           Driver.SwitchTo().Alert().SendKeys("pappu");
           Thread.Sleep(2000);
           Driver.SwitchTo().Alert().Accept(); */

        }
        private static void Modal_Dialogs()
        {

        }
    }
}

