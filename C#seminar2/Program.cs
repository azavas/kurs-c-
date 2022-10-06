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

/*int num = new Random().Next(10,9999);
Console.WriteLine(num);
int max=0;
while(num!=0){
    int s=num%10;
    if (s>max) max = s;    
    num=num/10;
    
}
Console.WriteLine(max);
*/
