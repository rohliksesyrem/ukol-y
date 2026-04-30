// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEJ mi čislo");
var a =  Int32.Parse(Console.ReadLine());
Console.WriteLine("Dej mi druhé číslo");
var b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Co chces to sečíst, vydělit, vynásobit nebo odečíst");

string znam = Console.ReadLine();

 
if (znam == "+") 
{
    Console.WriteLine(a + b);
}

 else if (znam == "-") ;
{
    Console.WriteLine(a - b);
}
 else if (znam == "*") ;
{
    Console.WriteLine(a * b);
}
  else if (znam == "/") ;
{
    Console.WriteLine(a / b);
} 