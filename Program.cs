// написать программу, которая из имеющегося массива строк
// формирует массив строк, длина которых
// меньше либо равна трем символам. 
{
    // ввод исходного массива
    Console.Write("Введите длину исходного массива  ");
    int inputArraySize=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите элементы массива");
    string[] inputArray=new string[inputArraySize];
    for (int counter=0; counter < inputArraySize; counter++)
    {
        inputArray[counter] =Console.ReadLine();
    }
    // выборка подходящих элементов через методы класса System.Array
    // и формирование результирующего массива
    string[] outputArray=Array.FindAll(inputArray, element => element.Length <=3);
    // вывод результата
    Console.Write("Результирующий массив:  ");
    for (int counter=0; counter<outputArray.Length; counter++)
    {
        Console.Write ("   {0}", outputArray[counter]);
    }
}
    