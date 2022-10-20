//Задача 39: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*int num = int.Parse(Console.ReadLine());
int osn = 2;

string num2 = Convert.ToString(num,2); //2,8,16,32

Console.WriteLine(num2);
Console.WriteLine(perevod(num,osn));

string perevod (int num, int osn){
    string res = "";
    string nums = "0123456789ABCDEF";
    while(num>0){
        int del = num/osn;
        res = nums[num-del*osn] + res;
        num/=osn; //num=num/osn
    }
    return res;
}
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Торема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a+b>c&& a+c>b&& b+c>a){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}
*/

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*int n = int.Parse(Console.ReadLine());
int  first = 0;
int second = 1;
Console.Write(first+ " " + second +" ");
for(int i=3; i<=n;i++){
    int Next=first + second;
    Console.Write(Next +" ");
    first=second;
    second=Next;
}
*/

/*void PrintArray(int[,] matr){

for(int i =0; i<matr.GetLength(0); i++){
    for(int j =0; j<matr.GetLength(1); j++){
        Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr){
    for(int i =0; i<matr.GetLength(0); i++){
        for(int j =0; j<matr.GetLength(1); j++){
           matr[i,j] = new Random().Next(1,10); 
        }
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int[] CreateMas(int M){
  int[] arr = new int[M];
    for(int i=0;i<M;i++)  
arr[i] = int.Parse(Console.ReadLine());
return arr;
}

void summa(int[]arr){
        int sum=0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i]>0){
                sum++;
                }
        }
        
           Console.WriteLine($"Количество положительных чисел = {sum}");
       
        
}
Console.Write("Введите числа: ");
int[] array = new int[3];
array = CreateMas(3);

summa(array);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x,y;


if((k1==k2)&&(b1==b2)){
   Console.WriteLine("Совпадают");
}
else if(k1==k2){
    Console.WriteLine("Параллельны");
}
else {
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine(x+" "+y);
}

*/

/*int n =int.Parse(Console.ReadLine());
int [,] matr = new int [n,n];
int b=1;
for(int i =0; i<matr.GetLength(1); i++){
    for(int j =0; j<matr.GetLength(0); j++){
         matr[i,j] = i+1;    
        Console.Write(matr[i,j] + " ");    
    }
    Console.WriteLine();
}
 
*/