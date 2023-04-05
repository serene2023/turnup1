// automating these follow steps for test

// open the brower
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver(); // Iwebdriver is the instance of the browser
driver.Manage().Window.Maximize();
driver.Manage().Window.FullScreen();

// launch the turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f"); // want browser to navigate and go to url in the browser

// user textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));  // ask browser to find element UserName
usernameTextbox.SendKeys("hari");                                     // type "hari"

// user password textbox and enter valid user password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));   // ask browser to find element Password
passwordTextbox.SendKeys("123123");                                   //type "123123"

// user click on log in button
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")); // ask browser to find Xpath for login button
loginbutton.Click();                                                                                 // click on log in box

// check if user login successfully  - this is the test
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));  
if (hellohari.Text == "Hello Hari!")                                    // hellohari is an element, inside the element there is a text "Hello Hari"                    
{
    Console.WriteLine("User logged in successfully.");                      //  if it is true, display text +ve msg

}
else 
{
    Console.WriteLine("User hasn't been login.");                      // else not true, msg display -ve
}