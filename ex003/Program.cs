//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void Func(){
    
    
    int[] array = new int[8];
    int count = 0;
    int size = 8;

    while (count < size){
        int random = new Random().Next(-100,100);
        
        array[count] = random;
        count++;
    }
    Console.WriteLine();
    Console.WriteLine("Был созан массив: ");
    foreach (int i in array){
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    
}

Func();
Func();
Func();
Func();