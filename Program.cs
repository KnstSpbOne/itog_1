// функция заполнения массива
string[] GetArray (int inputArraySize)
{
    Console.WriteLine("Введите элементы массива");
    string[] inputArray=new string[inputArraySize-1];
    for (counter=0; counter<(inputArraySize-1); counter++)
    {
        inputArray[counter]=Console.ReadLine();
    }
    return inputArray;
}

// main
{
    Console.Write("Введите длину исходного массива");
    int inputArraySize=Console.ReadLine();
    string[] inputArray=GetArray(inputArraySize);


}
    