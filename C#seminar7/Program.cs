//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*Random rnd = new Random();
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(rnd.Next(-10, 10) / 10.0);
        }

    }

}

double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Задача 46: Задайте двумерный массив размером m×n,заполненный случайными целыми числами.

/*void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * 5)); // округление
    }
}

void PrintList(List<List<double>> mylist){
    for (int i = 0; i < mylist.Count; i++){
        for (int j = 0; j < mylist[i].Count; j++)
            Console.Write(mylist[i][j]+" ");
            Console.WriteLine();
    }
        
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
*/

//Задача 48: Задайте двумерный массив размера m на n,каждый элемент в массиве находится по формуле: Aₙₙ = m+n.Выведите полученный массив на экран.
/*
void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * 5)); // округление
    }
}

void PrintList(List<List<double>> mylist){
    for (int i = 0; i < mylist.Count; i++){
        for (int j = 0; j < mylist[i].Count; j++)
            Console.Write(mylist[i][j]+" ");
            Console.WriteLine();
    }
        Console.WriteLine();
}

void Zapolnenie(List<List<double>> mylist){
    for (int i = 0; i < 5; i++)
    {
                for (int j = 0; j < 5; j++)
            mylist[i][j]=i+j;}
}


List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);
*/
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


//Задача 49:Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * 5)); // округление
    }
}

void PrintList(List<List<double>> mylist){
    for (int i = 0; i < mylist.Count; i++){
        for (int j = 0; j < mylist[i].Count; j++)
            Console.Write(mylist[i][j]+" ");
            Console.WriteLine();
    }
        Console.WriteLine();
}

void Zapolnenie(List<List<double>> mylist){
    for (int i = 0; i < 5; i++)
    {
                for (int j = 0; j < 5; j++)
           // mylist[i][j]=i+j;}
                if(i%2==0 && j%2==0)
                mylist[i][j]=Math.Pow(mylist[i][j],2);
}
}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);
*/

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * 5)); // округление
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist[i].Count; j++)
            Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Zapolnenie(List<List<double>> mylist)
{
    double sum=0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        

            if (i == j)
                sum+=mylist[i][j];
    }
    Console.WriteLine(sum);
}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);

*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            //mylist[i].Add(Math.Round(new Random().NextDouble() * 5));
            mylist[i].Add(new Random().NextDouble() * 5);
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SearchPozition(List<List<double>> mylist)
{
    Console.WriteLine("Введите позиции элементов: ");
    int i = int.Parse(Console.ReadLine());
    int j = int.Parse(Console.ReadLine());

    if (i <= 4 && j <= 4)
        Console.Write($"Значение элемента массива -> {mylist[i][j]}");

    else
    {
        Console.WriteLine($"{i} {j} -> такого числа в массиве нет ");
    }
}


List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
SearchPozition(numbers);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] matr){

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

void Average(int[,] matr){
    
    for(int j =0; j<matr.GetLength(1); j++){
        double sum=0;
        for(int i =0; i<matr.GetLength(0); i++)
        
        {
            sum=sum+matr[i,j];
            
         }
        sum=Math.Round(sum/matr.GetLength(0),1) ;
      Console.Write(sum+" ");          
}
}
int[,] matrix = new int[3,4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Average(matrix);
