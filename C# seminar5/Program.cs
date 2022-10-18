/*int[] CreateMas(int n){             //заполнение рандомными числами
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(2,10);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void CreateList(List<int> numb){
    for(int i=0;i<10;i++)
    numb.Add(new Random().Next(2,10));
}

List<int> numbers = new List<int>();
int[] array = new int[10];
array = CreateMas(10);
Print(array);


array.ToList();
numbers.AddRange(array);
foreach (var n in numbers){
    Console.Write(n + " ");
}
*/

//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот. Мой вариант


/*int[] arr = {-4,-8,8,2};  
void PrintArray(int[] array) 
{
    int count = array.Length;  
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++) 
   {    
    
        count++; array[i] = -1*array[i];
    }
    
    }    
    

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

*/
//Задача 32: решение преподавателя

/*int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(-10,10);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}
int[] zamena(int[] arr){
    for(int i = 0; i < arr.Length; i++)
    arr[i] = -1*arr[i];
    return arr;
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
zamena(array);
Print(array);
*/

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*int[] CreateMas(int n){             //заполнение рандомными числами
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(2,10);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void poisk(int[] arr, int k){
    bool f = false;
    for(int i = 0; i < arr.Length; i++)
    if (arr[i]==k){
                f = true;
        break;
    }
    if (f)
    Console.WriteLine("Найден");
    else
    Console.WriteLine("Не найден");
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
List<int> numbers = new List<int>();
numbers.AddRange(array);
var b = numbers.Contains(5);
Console.WriteLine(b);
poisk(array,5);
*/

//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

/*int[] CreateMas(int n){             //заполнение рандомными числами
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(1,1000);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}
void summa(int[]arr){
        int K=0;
        for(int i = 0; i < arr.Length; i++)
            if(arr[i]>9&&arr[i]<100){
                K++;
            }
           Console.WriteLine(K);
       
        
}
int[] array = new int[123];
array = CreateMas(123);
Print(array);
summa(array);
*/

//ДЗ. Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(100,999);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}
void summa(int[]arr){
        int rezult=0;
            for(int i = 0; i < arr.Length; i++){
            int div = arr[i]%2;
          
            if(div==0){
                rezult++;
            }
        }
        
           Console.WriteLine(rezult);
       
        
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
summa(array);

*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(1,20);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void summa(int[]arr){
        int sum=0;
            for(int i = 0; i < arr.Length; i++){
            int div = arr[i]%2;
            if(div!=0){
                sum=sum + arr[i];
                }
        }
        
           Console.WriteLine(sum);
       
        
}

int[] array = new int[10];
array = CreateMas(10);
Print(array);
summa(array);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*double[] CreateMas(int n){             
    
    double[] arr = new double[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().NextDouble()*100;
    return arr;
}
void Print(double[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void razniza(double[]arr){
    double max=arr[0];
    double min=arr[0];
    double Diff = 0;
    for(int i = 1; i < arr.Length; i++){
       
        if(arr[i] >= max){
            max=arr[i];
        }
        else if (arr[i]<=min) {
            min=arr[i];
        }
        
    }        
   
   Console.WriteLine(max);
   Console.WriteLine(min);

    Diff  = max-min;

    Console.WriteLine(Diff);
}


double[] array = new double[10];
array = CreateMas(10);
Print(array);
razniza(array);
*/
