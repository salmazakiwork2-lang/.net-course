
Console.Write("enter your name:") ;
string firstName  = Console.ReadLine() ;

Console.Write("enter your city : ");
string city = Console.ReadLine() ;

Console.Write("enter your age : ");
string ageInput = Console.ReadLine() ;
//int age = Convert.ToInt32(ageInput);
int age = int.parse(ageInput);

Console.Write($"hello, {firstName} , your city is {city} ! ") ;
Console.Write($"your age is {age} ! , and your age after 5 years is {age + 5}");