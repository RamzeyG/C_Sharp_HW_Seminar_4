// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



void Func(){
    int a = new Random().Next(0, 999999);
    string text = Convert.ToString(a);
    
    int count = 0;
    int x = 0;
    while(count < text.Length){
        x = x + Convert.ToInt32(Convert.ToString(text[count]));
        count++;
    }
    Console.WriteLine($"Сумма цифр числа {a} равна {x}");
}

Func();
Func();
Func();
Func();

