// Задача 9. Напишите программу, которая выводит числа из отрезка [10,99] и показывает наибольшую цифру числа

/*int num = new Random().Next(10,99);
Console.WriteLine(num);
int s1 = num/10;
int s2 = num%10;
Console.WriteLine(s1+" "+s2);
if (s1>s2) Console.WriteLine(s1);
else Console.WriteLine(s2);
*/

// Напишите программу, которая выводит числа из отрезка [10,9999] и показывает наибольшую цифру числа. Мой вариант

/*int num = new Random().Next(10,9999);
Console.WriteLine(num);
int s = 0;
int max=0;
while(num!=0){
    s=num%10;
    num=num/10;
    if (s>max){
        max = s;
    }
    
}
Console.WriteLine(max);
*/

// Напишите программу, которая выводит числа из отрезка [10,9999] и показывает наибольшую цифру числа. Вариант преподавателя

/*int num = new Random().Next(10,9999); //рандомное число
Console.WriteLine(num); // выводим на экран
int max=num%10; //,берем последнюю цифру числа
while(num!=0){
    int s=num%10;
    if (s>max) max = s;    
    num=num/10;
    
}
Console.WriteLine(max);
*/

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 
/*int num = new Random().Next(100,999);
Console.WriteLine(num);
int rezult = (num/100)*10 + num% 10;

        Console.WriteLine(rezult);
*/
//ДЗ
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100,999);
Console.WriteLine(num);
int rezult = (num/10)%10;
Console.WriteLine(rezult);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Сделала строкой, использование чисел не получилось, никак не могу понять как вести отсчет справа, а не слева. Если использовать массив, то не известен размер массива...
Console.Write("Введите цифру: ");
string str = Console.ReadLine ();
if (str.Length<3){
    Console.WriteLine("третьей цифры нет");
}
else{
    Console.WriteLine(str[2]);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*Console.WriteLine("Введите число  ");
int num = int.Parse(Console.ReadLine());
int sat = 6;
int san = 7;
if (num == 6) {
    Console.WriteLine($"{sat} = Да ");
    if (num == 7){
       Console.WriteLine($"{san} = Да "); 
    }
}
else {
    if (num < 5){
        Console.WriteLine($"{num} = Нет ");
    }
    else{
        Console.WriteLine($"{num} = Нет такого дня");
    }
}
*/
/*
//Напишите программу , которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток деления
/*Console.WriteLine("Введите число 1 ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int num2 = int.Parse(Console.ReadLine());
if (num1%num2==0) {
    Console.WriteLine($"{num1} = кратно ");
}
else
{
    Console.WriteLine($"{num1} = не кратно, остаток = {num1%num2}");
}
