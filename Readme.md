Coin Changer Kata
===============================

This Kata will help you learn more about TDD development.

Table of Contents
=================

  1. Preparing your machine
  2. Coin change Kata

Preparing your machine
===============

1.1. Installing Visual Studio
-----------------
Download visual studio installation from the link below and install it on your machine:
* https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx

1.2. Adding Visual Studio extensions
--------------------------------
Because we will be using Nunit, it will be useful to add Nunit test adapter extension to visual studio in order to run tests from within the test explorer:
* Open Visual Studio and go to Tools > Extensions and Updates.
* Search for NUnit test adapter on the online gallery and add it.

1.3. Creating the test project
---------------------------
Finally, create a new library project and add reference to the following packages via Nuget Manager console:
* Open Visual Studio and go to Tools > NuGet package manager > NuGet package manager console and type these commands.
* Install-Package NUnit
* Install-Package NSubstitute
   
Coin Changer Kata
===============

You've just created a virtual vending machine that will dispense widgets of programming goodness when a user puts money into the machine. The machine should dispense the proper change. You now need the programming logic to determine which coins to dispense. 
 
Write a program that will correctly determine the least number of coins to be given to the user such that the sum of the coins' value would equal the correct amount of change.
* Input: change amount
* Input: coin denomination array (i.e. [1, 5, 10, 25, 100] )
* Output: number of coins array (i.e. [1, 0, 1, 0, 0] would represent $0.11)


Examples:

	Given an expected total amount of change of 15
		And an array of valid coin values of [1, 5, 10, 25, 100]
	When the coin change calculator is executed
	Then it will return an array of number of coins per valid coin value of [0, 1, 1, 0, 0]

	Given an expected total amount of change of 40
		And an array of valid coin values of [1, 5, 10, 25, 100]
	When the coin change calculator is executed
	Then it will return an array of number of coins per valid coin value of [0, 1, 1, 1, 0]
 
Part of the challenge with this exercise is to think through your testing strategy. Do you test every possible input for the change amount, or do you test specific boundary cases?
 
Use Test Driven Development (TDD) to solve this problem. Start writing tests, write enough code to get the tests to pass, and then refactor your code. Allow your design to emerge from writing tests; don't try to solve the problem first.
 
If you prefer to return a hash instead of am array, that's ok too.  
* {1 => 1, 5 => 0, 10 => 1, 25 => 0, 100 => 0} equals $0.11
