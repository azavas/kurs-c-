// Напишите программу, которая принимае на вход число А и выдает сумму чисел от 1 до А
/*int A = int.Parse(Console.ReadLine());
int sum=0;
for(int i=0;i<A+1;i++){
    sum+=i;
}
Console.WriteLine($"Сумма равна {sum}");
*/
// Задан список фамилий брокеров товарной биржи из N человек. Обменяйте местами фамилии брокеров: первого и последнего, второго и предпоследнего и т.д

/*void Vivod(string[] arr){
    foreach(var i in arr)
    Console.Write(i+" ");
    Console.WriteLine();
}

string[] Perestanovka(string[] arr){
    for(int i = 0; i<arr.Length/2;i++){
        string t = arr[i];
        arr[i] = arr[arr.Length-1];
        arr[arr.Length-1] =t;
    }
    return arr;
}
int N = int.Parse(Console.ReadLine());
string[] names = new string[N];
for(int i=0;i<N;i++){
    names[i]=Console.ReadLine();
}
Vivod(names);
Perestanovka(names);
Vivod(names);
*/
/*int[] arr = {1,3,8,1,2,6,9,7,5};  //определяем массив
void PrintArray(int[] array) //приходит массив
{
    int count = array.Length;  //получение количества элиментов

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for(int i = 0; i < array.Length - 1; i++) 
   {
    int minPosition = i;
    for(int j = i+1; j < array.Length ; j++)
    {
        if(array[j]<array[minPosition]) minPosition = j;

    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;

   }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/

//Дан одномерный массив целыых чисел.Найдите сколько раз в нем 



//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
/*
void step(int A, int B){
    if(A<0||B<0){        
       Console.WriteLine("Отрицательные числа");
         }
    else {
    double res = Math.Pow(A,B);
    Console.WriteLine(res);
    }
}
Console.WriteLine("Введите число 1 ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int B = int.Parse(Console.ReadLine());

step (A,B);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int N = int.Parse(Console.ReadLine());
int sum = 0;
    while (N > 0)
        {sum=sum+N%10;
        N=N/10;
              
        }
 Console.WriteLine(sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно. Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.

/*void FillArray(int[] N)
{
    int length = N.Length;
    int index = 0;
    while (index<length)
    {
       N[index] = new Random().Next (1,100);
        
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position< count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
void SelectionSort(int[]N){
    foreach(var index in N) {
    int ind = index;
    int sum = 0;
    while (ind>0) {
       sum=sum+ind%10;
       ind=ind/10;     
    }
    Console.WriteLine(sum);
    }
}
 


int[] array = new int [8];

FillArray(array);
PrintArray(array);
Console.WriteLine();

SelectionSort(array);
*/

// Дан одномерный массив целых чисел. Найдите, сколько раз в нем повторяется самое частое число
/*int[] CreateMas(int n){
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(2,10);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr)); //объединение/ первый параметр как будем печатать, второй что именно печатать
}
int kol(int[] arr){
    int k=0;
    int max=0;
    for (int i=0;i<arr.Length;i++){
        k=1;
        for (int j=i+1;j<arr.Length;j++){
            if (arr[i]==arr[j])k++;

        }
        if (k>max){
            max=k;
        }
    }
    return max;
}
Console.WriteLine("Введите количество элементов: ");
int n= int.Parse(Console.ReadLine());
int[] array = new int[n];
array = CreateMas(n);

Print(array);
Console.WriteLine(kol(array));
*/

int[] CreateMas(){
    int kol = 12;
    int[] arr = new int[12];
    int kol_pol = 0;
    int kol_otrc = 0;
    while (kol_pol!=6 && kol_otrc!=6){
        kol_pol = 0;
        kol_otrc = 0;
        for(int i = 0;i<kol;i++){
            arr[i] = new Random().Next(-10,10);
            if (arr[i]>0)kol_pol++;
            else if(arr[i]<0)kol_otrc++;
            else i--;//РµСЃР»Рё С‡РёСЃР»Рѕ СЂР°РІРЅРѕ 0, С‚Рѕ РїСЂРѕРїСѓСЃРєР°РµРј
        }
    }
    Console.WriteLine($"Количество положительных: {kol_pol}"); 
    Console.WriteLine($"Количество отрицательных: {kol_otrc}"); 
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ",arr));
}
int[] arr = new int[12];
arr = CreateMas();
Print(arr);