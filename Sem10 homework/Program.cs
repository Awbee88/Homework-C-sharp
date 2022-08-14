

// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

string [] words = {"qwe", "wer", "ert", "rty", "tyu"};
char [] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};

int SearchVowel(string [] word, char [] alphabet)
{
    int count = 0;
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < alphabet.Length; j++)
        {
            if(word[i][0] == alphabet[j])
            {
                count++;
            }
        }
    }
    return count;
}

for (int k = 0; k < words.Length; k++)
{
    if(k==words.Length-1) Console.Write(words[k]);
    else Console.Write(words[k] + ", ");
}

Console.Write(" -> " + SearchVowel(words, vowels));




// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

/*

string [] words1 = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

string [] TogetherStrings(string[] word)
{
    string [] words2 = new string [word.Length/2];

    int temp=0;

    for (int i = 0; i < word.Length; i+=2)
    {
        words2[temp] = word[i]+word[i+1];
        temp++;
    }

    return words2;
}

string [] result = TogetherStrings(words1);

for (int k = 0; k < result.Length; k++)
{
    if(k==result.Length-1) Console.Write(result[k]);
    else Console.Write(result[k] + ", ");
}

*/