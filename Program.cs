// функция заполнения массива
string[] GetArray (int inputArraySize)
{
    Console.WriteLine("Введите элементы массива");
    string[] inputArray=new string[inputArraySize];
    for (int counter=0; counter < inputArraySize; counter++)
    {
        inputArray[counter]=Console.ReadLine();
    }
    return inputArray;
}

// main
{
    Console.Write("Введите длину исходного массива  ");
    int inputArraySize=Convert.ToInt32 (Console.ReadLine());
    string[] inputArray=GetArray(inputArraySize);
    Console.WriteLine("массив заполнен");
    int outputArraySize=0;
    for (int counter=0; counter<inputArraySize; counter++)
    {
        if (inputArray[counter].Length <= 3)
        {
            outputArraySize++;
        }
    }
    Console.WriteLine("количество подходящих элементов- {0}", outputArraySize);
    
     
}
    