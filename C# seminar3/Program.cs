//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*void chetvert(int x, int y){
    if (x>0 && y>0)
        Console.WriteLine ("1 четверть");
    else if (x>0 && y<0)
        Console.WriteLine ("2 четверть");
    else if (x<0 && y<0)
        Console.WriteLine ("3 четверть");
    else
        Console.WriteLine ("4 четверть");
}

string chetvertV2(int x, int y){
    string name = x>0 && y>0? "1 четверть" : x>0 && y<0? "2 четверть" : x<0 && y<0? "3 четверть" : "4 четверть";
    return name;
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
chetvert (x,y);
string otvet = chetvertV2(x,y);
Console.WriteLine(otvet);
*/
//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). Мой вариант

/*Console.Write("Введите четверть: ");
string chetvertV2(int chet){
    string name = chet == 1? "x>0 и y>0" : chet ==2? "x>0 и y<0" : chet ==3? "x<0 и y<0" : chet == 4? "x<0 и y>0" : "Неизвестная четверть";
    return name;
}
int chet = int.Parse(Console.ReadLine());
string otvet = chetvertV2(chet);
Console.WriteLine(otvet);
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. Мой вариант
/*
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int sum1 = 0;
int diff1 = 0;
int diff2 =0;

diff1 = (x-x1)*(x-x1);
diff2 = (y-y1)*(y-y1);
sum1 = diff1+diff2;
double i = Math.Sqrt(sum1);

    Console.WriteLine(i);
*/
/*
double dist (int x1, int y1,int x2, int y2){
    double res = Math.Sqrt(Math.Pow(x2-x1),2)+Math.Pow(y2-y1),2)); //Math.Pow выводит степень//Math.Sqrt выделяет корень
    return res;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
double otvet = dist (x1,y1,x2,y2);
Console.WriteLine(otvet);
*/

//ДЗ.Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*double kvadr (int z){
     double res = Math.Pow(z,2);
    return res;
}
 
double n = int.Parse(Console.ReadLine());
int x=1;
while (x<=n) {
    double otvet = kvadr (x);
    x++;
Console.WriteLine(otvet);
}
*/

int[] num = new int[5];

if (
    //while (i<num.Length){
    Console.Write($"Введите {i} число массива: ");  
    num[i] = int.Parse(Console.ReadLine());
    i++;