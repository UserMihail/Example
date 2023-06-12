/*  string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;


    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл "for" (задача стала компактней)

string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0;i < count; i++)

    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);                   

// Использование цыкла в в цыкле.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}                                               */


// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С"
// зменить маленькими "с".

 string text ="- Я думаю, - сказал князь, улыбаясь, - что,"
             +"ежели бы вас послали вместо нашего милого Винценгероде,"
             +"вы бы взяли приступом согласие прусскго короля."
             +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123                
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);            //26:36