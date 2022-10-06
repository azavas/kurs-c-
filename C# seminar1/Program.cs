/*Console.Write("Введите имя: ");
string name = Console.ReadLine ();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number * number}");
Console.WriteLine("Ваше имя "+name);
*/

/*int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num2*num2==num1)
    Console.WriteLine($"{num1} квадрат {num2}");
else
    Console.WriteLine("Нет, не является ");
int koren = Convert.ToInt32(Math.Sqrt(num1));
if (koren == num2){
    Console.WriteLine($"{num1} квадрат {num2}");
}
else{
    Console.WriteLine("Нет, не является ");
}
*/ 

/*3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.

int day = int.Parse(Console.ReadLine());
if (day==1){
    Console.WriteLine("Понедельник");
}
else if (day==2){
    Console.WriteLine("Вторник");
}
else if (day==3){
    Console.WriteLine("Среда");
}
else if (day==4){
    Console.WriteLine("Четверг");
}
else if (day==5){
    Console.WriteLine("Пятница");
}
else {
    Console.WriteLine("Неизвестно ");
}
*/

/*5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.

int num = int.Parse(Console.ReadLine());
for (int num1=-System.Math.Abs(num); num1<=num; num1++)
{
    Console.Write(num1.ToString()+" ");
}
*/
/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.

Console.Write("Введите цифру: ");
string str = Console.ReadLine ();
Console.WriteLine(str[2]);
*/
/*
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1>num2){
    Console.WriteLine($"{num1} = max ");
}
else{
    Console.WriteLine($"{num2} = max ");
}
*/

/*int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1>num2){
        if (num1>num3) {
            Console.WriteLine($"{num1} = max ");    
        }
        else{
            Console.WriteLine($"{num3} = max ");
        }
}
else{
        if (num2>num3) {
            Console.WriteLine($"{num2} = max ");
        }
        else{
            Console.WriteLine($"{num3} = max ");
        }
}
*/

int num = int.Parse(Console.ReadLine());
double ost = num%2;
if (ost = 0){
    Console.WriteLine(num);
}
else {
    Console.WriteLine("Нечетное");
}

