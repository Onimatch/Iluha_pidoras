/*double Factorial(int n)
{
    //1! =1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i =1; i< 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3=6
}*/


// f(1)= 1 f(2)= 1 f(n) = f(n-1)+ f(n-2)

double Fib(int n )
{
    if( n ==1 || n ==2) return 1;
    else return Fib(n-1) + Fib(n-2);
}

for (int i =1; i < 50; i++)
{
    Console.WriteLine($"f({i}) {Fib(i)}");
}