//вид 1
void Metod1()//Ничего не принимает ничего не возращает
{
    Console.WriteLine("Кузнецов");

}
//Metod1();

//Вид2

void Metod2(string msg)
{
    Console.WriteLine(msg);
}
//Metod2("Текст");
void Metod21(string msg, int count)// принимает значение но не возращает 
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Metod21(msg: "Текст", 4);
//Вид3
 int Metod3()//Ничего не принимает но возращает
 {
    return DateTime.Now.Year;
 }
 int year = Metod3();
//Console.WriteLine(year);


//Вид4 Получают и возвращают

/*string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;


while(i<count)
{
     result= result +c;
    i++;
}
return result;
}

string res = Metod4(10, "asdf");
Console.WriteLine(res);*/

//Цикл for

string Metod4(int count, string c)
{
        string result = String.Empty;
for( int i =0; i < count; i++ )
{
     result= result +c;
   
}
return result;
}

string res = Metod4(10, "asdf");
//Console.WriteLine(res);


for (int i =2; i <= 10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}