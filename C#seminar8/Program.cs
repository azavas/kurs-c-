//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


/*void FillArray(int[,] arr){
    for(int i =0; i<arr.GetLength(0); i++){
        for(int j =0; j<arr.GetLength(1); j++){
           arr[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] arr){

for(int i =0; i<arr.GetLength(0); i++){
    for(int j =0; j<arr.GetLength(1); j++){
        Console.Write(arr[i, j]+" ");
    }
Console.WriteLine();
}
Console.WriteLine();
}
int[,] Swap(int[,] arr){
    int LastIndex = arr.GetLength(0)-1;
    for (int j=0;j<arr.GetLength(1);j++){
        int temp = arr[0,j];
        arr[0,j] = arr[LastIndex,j];
        arr[LastIndex,j] = temp;
    }
    return arr;
}
int[,] array = new int[5,5];

FillArray(array);
PrintArray(array);
int[,] newArr = new int[5,5];
newArr = Swap(array);
PrintArray(newArr);
*/


//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*void FillArray(int[,] arr){
    for(int i =0; i<arr.GetLength(0); i++){
        for(int j =0; j<arr.GetLength(1); j++){
           arr[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] arr){

for(int i =0; i<arr.GetLength(0); i++){
    for(int j =0; j<arr.GetLength(1); j++){
        Console.Write(arr[i, j]+" ");
    }
Console.WriteLine();
}
Console.WriteLine();
}
int[,] FullSwap(int[,] array){
    int[,] rArr = new int[array.GetLength(0),array.GetLength(1)];
   for(int i =0; i<array.GetLength(1); i++)
    for(int j =0; j<array.GetLength(0); j++)
    rArr[j,i] = array[i,j];
 // PrintArray(rArr);
    return rArr;
}

int[,] array = new int[5,5];

FillArray(array);
PrintArray(array);
int[,] newArr = new int[5,5];
newArr = FullSwap(array);
PrintArray(newArr);
//PrintArray(FullSwap(newArr));
*/

//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*void FillArray(int[,] arr){
    for(int i =0; i<arr.GetLength(0); i++){
        for(int j =0; j<arr.GetLength(1); j++){
           arr[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] arr){

for(int i =0; i<arr.GetLength(0); i++){
    for(int j =0; j<arr.GetLength(1); j++){
        Console.Write(arr[i, j]+" ");
    }
Console.WriteLine();
}
Console.WriteLine();
}


int[,] FullSwap(int[,] array){
    int[,] rArr = new int[array.GetLength(0),array.GetLength(1)];
   for(int i =0; i<array.GetLength(1); i++)
    for(int j =0; j<array.GetLength(0); j++)
    rArr[j,i] = array[i,j];
 // PrintArray(rArr);
    return rArr;
}

int[] GetArray(int[,] array){
    int[] ArrayOne = new int[array.GetLength(0)*array.GetLength(1)];
    int k=0;
    for(int i =0; i<array.GetLength(1); i++)
    for(int j =0; j<array.GetLength(0); j++){
ArrayOne[k]=array[i,j];
k++;
    }
    
    foreach(var el in ArrayOne){
        Console.Write(el + " ");
    }
   return ArrayOne;
}
void SortMas(int[] array){
    for(int i=0;i<array.Length;i++){
        for(int j=i+1;j<array.Length;j++)
        if(array[i]>array[j]){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            //Console.Write(temp);
        }

    }
}

int[,] array = new int[5,5];

FillArray(array);
PrintArray(array);
int[,] newArr = new int[5,5];
newArr = FullSwap(array);
PrintArray(newArr);
//PrintArray(FullSwap(newArr));

GetArray(newArr);
int[] arr1 = GetArray(newArr);
SortMas(arr1);

*/
//ДЗ.Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Decrease(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Decrease(array);
PrintArray(array);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumLine(int[,] arr)
{int temp=0;
  int stroka = 0;
    for (int i = 0; i < arr.GetLength(0); i++){
            temp = temp+arr[0,i];
            
        }
   for (int j = 1; j < arr.GetLength(1); j++)
    {
        int sum=0;
        for (int i = 0; i < arr.GetLength(0); i++){
            sum = sum+arr[j,i];
            
        }
        //Console.WriteLine(sum);
              if (sum<temp){
                temp=sum;
                stroka = j;
              }
        } 
        //Console.WriteLine(temp);
        //Console.WriteLine(stroka+1);
        Console.WriteLine($"\n{stroka+1} строкa с наименьшей суммой ({temp}) элементов ");
}
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SumLine(array);


