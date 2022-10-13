// Напишите программу, которая принимае на вход число А и выдает сумму чисел от 1 до А
/*int A = int.Parse(Console.ReadLine());
int sum=0;
for(int i=0;i<A+1;i++){
    sum+=i;
}
Console.WriteLine($"Сумма равна {sum}");
*/
// Задан список фамилий брокеров товарной биржи из N человек. Обменяйте местами фамилии брокеров: первого и последнего, второго и предпоследнего и т.д
int A = int.Parse(Console.ReadLine());
string[] names = new string[A];