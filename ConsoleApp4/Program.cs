// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;


//int[] array1 = { 1,5,5,5,5};
//int[] array2 = { 4,8,6,2,4 };
//int sum1 = 0;
//int sum2 = 0;
//for (int i=0;i<array1.Length; i++)
//{
//    sum1 += array1[i];
//    sum2 += array2[i];
//}
//Console.WriteLine((sum1*sum2)/(array1.Length*array2.Length));

int n;
int [] aray =new int [20];
do
{
    Console.Write("n=");
    n = Convert.ToInt32(Console.ReadLine());
} while (n < 1 && n > 20);
for(int i = 0; i < n; i++)
{
    Console.Write("  aray["+i+"]=");
    aray[i]=  Convert.ToInt32(Console.ReadLine());
    
}
for (int i = 0; i < n; i++)
{
    if (aray[i] > 0)
    {
        Console.WriteLine("  aray[" +i+"[=" +aray[i]);
    }
}