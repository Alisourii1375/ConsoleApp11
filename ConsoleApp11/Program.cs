using ArghamNegarLibrary;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
Console.WriteLine("Please Enter Number 1");
double X = double.Parse(Console.ReadLine());
Console.WriteLine("Please Enter Number2");
Double g = double.Parse(Console.ReadLine());


Console.WriteLine("Please Enter operator");
char op = char.Parse(Console.ReadLine());
if (op == '*')
{
    var R = calssmath.zarb(X, g);
    Console.WriteLine(R);
}
else if (op == '/')
{
    var R = calssmath.taqsim;
    Console.WriteLine(R);
}
else if (op == '+')
{
    var R = calssmath.jam(X, g);
    Console.WriteLine(R);
}
else if (op == '-')
{
    var R = calssmath.minees(X, g);
    Console.WriteLine(R);


}




