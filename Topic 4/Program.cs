// See https://aka.ms/new-console-template for more information
int age; 
Console.WriteLine("Enter your age");
Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));

Console.WriteLine("Your age is: " + age);
Console.ReadLine();

double price;
Console.WriteLine("What is the price? ");
Double.TryParse(Console.ReadLine(), out price);
Console.WriteLine("The price is " + price.ToString("C"));

string topping;
string name;
Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("What's you favorite pizza topping?");
topping = Console.ReadLine();
Console.WriteLine("My favorite pizza topping is " + topping + " too!");

double prices;
Console.WriteLine("What's the price?");
Double.TryParse(Console.ReadLine(),out prices);
Console.WriteLine("The price of three of them would be " + (prices * 3).ToString("C"));

double diameter;
Console.WriteLine("Enter the diameter of a circle");
diameter = Double.Parse(Console.ReadLine());
Console.WriteLine("The radius is " + diameter / 2);















