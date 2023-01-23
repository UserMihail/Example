int n = 1;
void FindWords(string alphabet, char[] word, int length = 0) //метод-переданный строкой alp, масс из букв word, 
// собирается длинна слов leng из букв.  
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[1]);