// Exercise 1

Console.WriteLine("Hi user. Enter some text and I'll repeat it back to you.");
string userText = Console.ReadLine();
Console.WriteLine(userText);

// Exercise 2

Console.WriteLine("Please enter a number");
string userNumberString = Console.ReadLine();
int userNumber = 0;
bool isNumberValid = int.TryParse(userNumberString, out userNumber);
int userAdd = userNumber + 1;
Console.WriteLine(userAdd);

// Exercise 3

Console.WriteLine("Please enter a number");
string userNumberStringTwo = Console.ReadLine();
bool isNumberValidTwo =decimal.TryParse(userNumberStringTwo, out decimal userNumberTwo);
decimal result = userNumberTwo + 0.5m;
Console.WriteLine(result);

// Exercise 4

Console.WriteLine("Please enter a number");
string userNumberStringThree = Console.ReadLine();
int userNumberThree = 0;
bool isNumberValidThree = int.TryParse(userNumberStringThree, out userNumberThree);
Console.WriteLine("Please enter a second number");
string userNumberStringFour = Console.ReadLine();
int userNumberFour = 0;
bool isValidNumberFour = int.TryParse(userNumberStringFour, out userNumberFour);
int numberTotals = userNumberThree + userNumberFour;
Console.WriteLine($"The sum of your two numbers is {numberTotals}");

// Exercise 5

Console.WriteLine("Please enter a number");
string userNumberStringFive = Console.ReadLine();
int userNumberMultiplyOne = 0;
bool isValidNumberFive = int.TryParse(userNumberStringFive, out userNumberMultiplyOne);
Console.WriteLine("Please enter a second number");
string userNumberStringSix = Console.ReadLine();
int userNumberMultiplyTwo = 0;
bool isValidNumberSix = int.TryParse(userNumberStringSix, out userNumberMultiplyTwo);
Console.WriteLine($"The product of your two numbers is {userNumberMultiplyOne * userNumberMultiplyTwo}");

