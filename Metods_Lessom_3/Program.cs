//Какие бывают методы:

// Вид 1- ни принимают, ни возвращают
void Method1() //название методва
{
    Console.WriteLine("Автор "); //тело метода, 
}                               //которое мжоет что-то показывать на экран.
Method1(); //вызов метода

// Вид 2- принимают, не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); //или
Method21(count: 4, msg: "Текст");  //именованные переменные можно записывать не по порядку

// Вид 3-не принимают, что-то возвращают (обязательно указываем тип данных
// значение которых мы ожидаем)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);            

// Вид 4- что-то принимают, что-то возвращают

string Method4(int count, string text)
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