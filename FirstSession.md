1.	Every application/program/script has a starting point.
2.	This is where we begin our tests.
3.	Different types of systems have different starting points.
4.	The first way is with HTML and JavaScript because JS has become the standard for programming web pages when on the front end/in browser.
5.	The second way is using tools such as NUnit/Xunit for C# code
6.	Another way is to use the web browser via Selenium

Selenium is a tool written in Java, it has been around since 2004, and was originally developed by a renowned software organisation called ThoughtWorks.

Selenium uses the html content that you are able to see in most browsers when you right click on a web page, and select to view the source.

Selenium has been ported to numerous eco systems, from PHP, Perl through to Ruby and many others.

The main eco system is Java, but due to the longevity of the project it can be comprehensively used from all main stream languages, including those on the .Net framework, Python, Ruby, and so forth.


———————————————————————————————————————————


How do we want to use testing in our projects?

We need to be as smart as we can to make sure we don’t duplicate effort, undertake work that can be automated, and make sure our test suites are robust enough to cover our code whilst being practical to use, easy to understand, easy to maintain, ultimately making the product easier to develop to deliver value for the business.

First of all let’s look at how we can perform a basic test in the .Net framework, without selenium.

For this we can use a popular library called NUnit, but we shouldn’t limit ourselves simply to this library as there are other good choices that give variant ways of achieving the same thing.

Let’s use dot net core to make our lives easy, and visual studio code which is freely available.

Open a command prompt, and type 

  /> dir

to see what directory we are currently in. Then type:

  /> cd \

now type 

 /> mkdir TestLearning

then cd into that new directory.

Now we are in this directory we need to create a new project using dot net core:

 /> dotnet new sln

 /> mkdir ConsoleApp

 /> cd ConsoleApp

 /> dotnet new console

 /> cd ..

 /> mkdir ConsoleApp.Tests

 /> cd ConsoleApp.Tests

 /> dotnet new xunit

 /> cd ..

 /> dotnet sln add ConsoleApp\ConsoleApp.csproj

 /> dotnet sln add ConsoleApp.Tests\ConsoleApp.Tests.csproj
 

Now we should have a project that builds:

 /> dotnet build

If you have problems then read the steps again, and write down the issues you find.

Now we can open the folder in VS Code.

Now open the folder by typing

 /> code .

We can see in UnitTest1.cs a test has already been provided for us.

Now we should be able to run the test, and see that it fails:

 /> dotnet restore && dotnet test ConsoleApp.Tests


Now analyse the code, and next time we can see how we can do more.
