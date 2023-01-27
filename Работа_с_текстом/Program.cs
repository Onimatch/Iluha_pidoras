//Дан текст.Нужно заменить К на к и С на с

string text = "- Я думаю сказать - сказал князь улыбаясь - что,"
+ "ежели бы вас послали вместо нашего милого Винценгкроде,"
+ "вы бы взяли приступом согласие прусского короля."
+"Вы так  красноречивы.Вы дадите мне чаю?";


//string s = "qwerty"
//            012345
// s[3] // r

string Replace(string text, char old, char newV)
{
    string result = String.Empty;
    int lenght = text.Length;
    for( int i = 0; i < lenght; i ++)
    {
        if (text[i] == old) result = result + $"{newV}";
        else result = result + $"{text[i]}";
        }
    
return result;
    }

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
 newText = Replace(text,'к', 'К');
 Console.WriteLine(newText);
 Console.WriteLine();
 string nepText = Replace(newText, 'с', 'С');
 Console.WriteLine(nepText);