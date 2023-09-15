// Перебор слов
/*
В некотором машинном алфавите имеются четыре буквы "а" "и" "с" "в". Покажите все слова, состоящие из T букв,
Которые можно посторить из букв этого алфавита.
*/
/*
char [] s = { 'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) //1 буквенные слова
{
    System.Console.WriteLine($"{n++, -5}{s[i]}");

    for (int j = 0; j < count; j++) //2 буквы
    {
        System.Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
        for (int k = 0; k < count; k++) //3 буквы
        {
            System.Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}");
            // и т.д
        }
    } 
}
*/
// Решение рекурсии
int n = 1;
void FindWords(string alphabet, char [] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[1]);