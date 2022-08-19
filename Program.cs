//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
//Создание переменных
int numA, numB;

//Ввод данных
Console.WriteLine("Введите два числа: ");
numA = Convert.ToInt32(Console.ReadLine());
numB = Convert.ToInt32(Console.ReadLine());

//Сравнение чисел
Console.Write("Наибольшее число: ");
if(numA > numB){
    Console.WriteLine(numA);
}
else{
    Console.WriteLine(numB);
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
//Создание переменных
int numA, numB, numC;

//Ввод данных
Console.WriteLine("Введите три числа: ");
numA = Convert.ToInt32(Console.ReadLine());
numB = Convert.ToInt32(Console.ReadLine());
numC = Convert.ToInt32(Console.ReadLine());

//Сравнение чисел
Console.Write("Наибольшее число: ");
if((numA > numB) & (numA > numC)){
    Console.WriteLine(numA);
}
else if ((numB > numA) & (numB > numC)){
    Console.WriteLine(numB);
}
else{
    Console.WriteLine(numC);
}
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
//Создание переменных
int num, div;

//Ввод данных
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

//Вычисления
div = num % 2;

//Вывод данных
if(div == 0){
    Console.WriteLine("Число четное.");
}
else {
    Console.WriteLine("Число нечетное.");
}
*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Создание переменных
int N, div, count;

//Ввод данных
Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

//Организация цикла
count = 1;

if (N <= count){
    Console.WriteLine("Задача не имеет решения.");
}
else{
    Console.Write("Четные числа: ");
    while (count <= N){
        //Вычисления
        div = count % 2;
        if(div == 0){
            Console.Write(count);
        }
        Console.Write("  ");
        count = count + 1;
    }
}

