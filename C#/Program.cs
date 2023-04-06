// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array = { "4", "House", "Три", "Один" };

string[] UpToThree(string[] Array)
{
    int SizeArray = 0;
    int SizeText = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        string Text = Array[i];
        SizeText = Text.Length;
        if (SizeText <= 3)
        {
            SizeArray++;
        }
    }

    string[] NewArray = new string[SizeArray];
    int Trigger = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        string Text = Array[i];
        SizeText = Text.Length;
        if (SizeText <= 3)
        {
            NewArray[Trigger] = Array[i];
            Trigger++;
        }
    } 
    return NewArray;
}

string[] NewArray = UpToThree(Array);
for (int i = 0; i < NewArray.Length; i++)
{
    Console.WriteLine($"{i+1}й элемент: {NewArray[i]}");
}
