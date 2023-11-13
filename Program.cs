Console.WriteLine("введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] num = new int[N];
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($" введите {i} элемент");
    num[i] = Convert.ToInt32(Console.ReadLine());

}
int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    sum += i;
}
Console.WriteLine(sum);