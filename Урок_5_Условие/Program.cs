﻿Console.WriteLine("Введите имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, Маша");
}
else
{
    Console.Write ("Привет,");
    Console.WriteLine (username);
}
