/*string pash = "Users/User/Desktop/ГигБрейнс/2. Знакомство с языками рограммиорования/Лекция _1/Examples/Example-2";
DirectoryInfo di = new DirectoryInfo(pash);
System.Console.WriteLine(di.CreationTime); //получение инф. о дате созд.

FileInfo[] fi = di.GetFiles();      // обращение к папкам
for (int i = 0; i < fi.Length; i++)     //перебор папок 
{
    System.Console.WriteLine(fi[i].Name);   //выводим по name
}*/

// Рекурсивный метод перебора всех папок

void CatalogInfo(string pash, string index = "") // pash путь к текущей папке, и в качестве второго
                                                // аргумента будем использовать отсупы =""
{
    DirectoryInfo catalog = new DirectoryInfo(pash); // получаеи инфо. куда зашли по "pash"

    DirectoryInfo[] catalogs = catalog.GetDirectories(); //получаем массив всех файлов
    for (int i = 0; i < catalogs.Length; i++)           // пробегаем по ним
    {
        Console.WriteLine($"{index}{catalogs[i].Name}");  //вывододя инфо
           CatalogInfo(catalogs[i].FullName, index + " "); //рекрсивно проверяем все папки
    }

    FileInfo[] files = catalog.GetFiles(); // получаем весь список файлов текущего каталога
    {
        for (int i = 0; i < files.Length; i++)
        Console.WriteLine($"{index}{files[i].Name}");
    }
}
string pash = "C:/Users/User/Desktop/ГигБрейнс/2. Знакомство с языками рограммиорования/Лекция _1/Examples";
CatalogInfo(pash);


