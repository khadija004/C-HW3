
#region Task1
//static int ReturnNum()
//{
//    Console.WriteLine("Please enter your number");
//    int.TryParse(Console.ReadLine(), out int num);

//    int count = 10;
//    int tempNum = num;

//    while (num >= 10)
//    {
//        num /= 10;
//        count *= 10;
//    }

//    int result = tempNum + (3 * count);
//    return result;
//}

//Console.WriteLine(ReturnNum());
#endregion

#region Task2


Console.WriteLine("Enter your sentence");
string sentence = Console.ReadLine();

sentence = sentence.ToLower();
string[] words = sentence.Split(' ');

foreach (string word in words)
{
    //str = char.ToUpper(str[0]) + str.Substring(1);
    word = char.ToUpper(word[0]) + word.Substring(1);
}

for (int i = 0; i < words.Length; i++)
{
    words[i] = char.ToUpper(words[i][0])
}
 

//Tam yaza bilmedim ve qeydleri silmedim

#endregion