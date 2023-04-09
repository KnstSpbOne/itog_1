// main
{
    // ввод исходного массива
    Console.Write("Введите длину исходного массива  ");
    int inputArraySize=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите элементы массива");
    string[] inputArray=new string[inputArraySize];
    for (int counter=0, int outputArraySize=0; counter < inputArraySize; counter++)
    {
        inputArray[counter]=Console.ReadLine();
        if (inputArray[counter] <=3)
        {
            int outputArraySize++;
        }
    }
    Console.WriteLine("массив заполнен");
    
    // выборка подходящих элементов 1-й способ через методы класса System.Array
    string[] outputArray=Array.FindAll(inputArray, element => element.length <=3);
    Console.Write("Результирующий массив:  ");
    for (int counter=0; counter<outputArray.Length, counter++)
    {
        Console.Write (outputArray[counter]);
    }

}
    