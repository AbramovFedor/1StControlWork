
string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int i2 = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i2] = array1[i];
        i2++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArray(array1, array2);
PrintArray(array2);

//https://drive.google.com/file/d/15IvywINh-G4_pGtPj2bQAMhnjZit8Bp6/view?usp=sharing ссылка на блок-схему.