// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Func(int A, int B){
    int C = A;
    if(A == 0 && B == 0){
        Console.WriteLine($"Число {C} в степени {B} - выражение не имеет смысла");
    }
    else if(B == 0){
        Console.WriteLine($"Число {C} в степени {B} - равно 1");
    }
    else if(B != 0){
        int count = 1;
        while(count < B){
        A = A * C;
        count++;
        }
    Console.WriteLine($"Число {C} в степени {B} равно {A}");
    }    
    
}

Func(4, 2);
Func(3, 6);
Func(12, 2);
Func(11, 0);
Func(0, 0);
Func(0, 2);