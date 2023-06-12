int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18, };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    //index = index + 1;
    index++;
}







/* Имеется одномерный массив array из n элементов, 
требуется найти элемент массива, равный finde

1. установить счетчик index в позиции 0
2. Если array [index]=finde, алгоритм завершает работу усп.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном 
случае алгоритм завершил работу безуспешно.*/