// на вход принимает число N и выводит все числа от -N до N


//Вариант1
/*System.Console.Write("Ведите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;

while (count <= N)
{
    Console.Write(count + " ");
    count = count + 1;
}*/


//Вариант2
System.Console.Write("Ведите число N:");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}