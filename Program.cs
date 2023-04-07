// функция заполнения массива
string[] GetArray ()
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

}
    