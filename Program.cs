void Program()
{
    Console.Clear();
    string? Yes = "";    
    Console.WriteLine("Желаете ввести массив вручную (yes/no)?");
    Yes = Console.ReadLine();    
    string[] ArrayStr = new string[] {};
    if (Yes.ToLower() == "yes") 
    {
        int size = InputMessage("Введите длинну массива: ");
        ArrayStr = new string[size];
        Console.WriteLine("Заполните массив:"); 
        FillArray(ArrayStr);
        Console.WriteLine("Ваш массив:");
        PrintArray(ArrayStr);               
    }
    else 
    {
        Console.WriteLine();
        Console.WriteLine("Случайный массив:");
        int sizeLetters = InputRandom();
        ArrayStr = new string[InputRandom()];       
        char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();        
        Random rand = new Random();        
        for (int i = 1; i <= ArrayStr.Length; i++)
        {            
            string Word = "";
            for (int j = 1; j <= sizeLetters; j++)
            {                
                int LetterCHR = rand.Next(0, letters.Length - 1);                
                Word += letters[LetterCHR];
                sizeLetters = InputRandom();
            }
            ArrayStr[i-1] += Word;            
            Console.Write(ArrayStr[i-1] + " ");
        }
        Console.WriteLine();        
    }      
    string[] ArrayRes = new string[ArrayStr.Length];    
    Sorted(ArrayStr, ArrayRes);
    if (ArrayRes[0] != null)
    {
        Console.WriteLine("Итоговый массив из 3х и менее символов:");
        PrintArray(ArrayRes);
    }
    else
    {
        Console.WriteLine("Нет подходящих строк в массиве");
    }
}
Program();

int InputRandom()
{
    Random random = new Random();
    return random.Next(1, 10);
}

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string[]Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
}

void PrintArray(string[]Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}

void Sorted(string[]ArrayStr, string[]ArrayRes)
{
    int count = 0;
    for (int i = 0; i < ArrayStr.Length; i++)
    {
        if (ArrayStr[i].Length <= 3)
        {
            ArrayRes[count] = ArrayStr[i];
            count++;
        }        
    }
    Console.WriteLine();
}