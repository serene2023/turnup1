// automating these follow steps for test

// open the brower
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;



IWebDriver driver = new ChromeDriver(); // Iwebdriver is the instance of the browser
//driver.Manage().Window.Position = new System.Drawing.Point(2000, 2); // To 2nd monitor. 
driver.Manage().Window.Maximize();


// launch the turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f"); // want browser to navigate and go to url in the browser
Thread.Sleep(1000);

// user textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));  // ask browser to find element UserName
usernameTextbox.SendKeys("hari");                                     // type "hari"

// user password textbox and enter valid user password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));   // ask browser to find element Password
passwordTextbox.SendKeys("123123");                                   //type "123123"

// user click on log in button
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")); // ask browser to find Xpath for login button
loginbutton.Click();                                                                                 // click on log in box
Thread.Sleep(2000);

// check if user login successfully  - this is the test
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text == "Hello hari!")                                 // hellohari is an element, inside the element there is a text "Hello Hari"                    
{
    Console.WriteLine("User logged in successfully.");               //  if it is true, display text +ve msg
}
else 
{
    Console.WriteLine("User hasn't been login.");                    // else not true, msg display -ve
}

//Create new time record

IWebElement directory = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
directory.Click();

Thread.Sleep(3000);
//Navigate to new time material
IWebElement newTm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
newTm.Click();

Thread.Sleep(3000);
//Click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

// select Time option from dropdown
IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
dropdown.Click();

Thread.Sleep(3000);
//Select Time option from dropdown
IWebElement selectTimeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));  //i can't find this Xpath 


Thread.Sleep(3000);
//type code into code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("hari2023");

Thread.Sleep(3000);
//type description into description textbox
IWebElement descrptionTextbox = driver.FindElement(By.Id("Description"));
descrptionTextbox.SendKeys("harihari2023");

// type price into price per unit textbox
IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceOverlap.Click();

Thread.Sleep(5000);
//type price per unit into price per unit textbox
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");

//click on Save button 
IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
Savebutton.Click();
Thread.Sleep(3000);

// check if new Time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "hari2023")
{
    Console.WriteLine("New record has been created successfully.");
}
else
{
    Console.WriteLine("Record hasn't been created.");
}
