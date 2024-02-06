System.Console.Write("Enter number a: ");
int numa = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operator: (+,-,*,/,%)");
string operation = Console.ReadLine() ;
System.Console.Write("Enter number b: ");
int numb = Convert.ToInt32(Console.ReadLine());

string massage =
    numa >= numb
        ?"The number a is greater than or equal to the number b"
        :"The number b is greater than the number a";
System.Console.WriteLine(massage);

/*switch (operation)
{
    case "+":
        System.Console.WriteLine($"{numa} + {numb} = {numa +numb}");
            break;
    case "-":
        System.Console.WriteLine($"{numa} - {numb} = {numa -numb}");
            break;
    case "*":
        System.Console.WriteLine($"{numa} * {numb} = {numa *numb}");
            break;
    case "/":
        System.Console.WriteLine($"{numa} / {numb} = {numa /numb}");
            break;
    case "%":
        System.Console.WriteLine($"{numa} % {numb} = {numa %numb}");
            break;
    default:
        System.Console.WriteLine("Operation not found");
            break;
}*/

string result = operation switch
{
    "+" => $"{numa} + {numb} = {numa +numb}",
    "-" => $"{numa} - {numb} = {numa -numb}",
    "*" => $"{numa} * {numb} = {numa *numb}",
    "/" => $"{numa} / {numb} = {numa /numb}",
    "%" => $"{numa} % {numb} = {numa %numb}",
    _   => "Operation not found!"
};
System.Console.WriteLine(result);

int number = 0;
while(number <= numa)
{
    System.Console.WriteLine(number);
    number = number + 2;
}

for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        System.Console.WriteLine($" {i} * {j} = {i*j}");
    }
    System.Console.WriteLine("\n");
}