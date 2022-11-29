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

//int n;
//int [] aray =new int [20];//291
//do
//{
//    Console.Write("n=");
//    n = Convert.ToInt32(Console.ReadLine());
//} while (n < 1 && n > 20);
//for(int i = 0; i < n; i++)
//{
//    Console.Write("  aray["+i+"]=");
//    aray[i]=  Convert.ToInt32(Console.ReadLine());

//}
//for (int i = 0; i < n; i++)
//{
//    if (aray[i] > 0)
//    {
//        Console.WriteLine("  aray[" +i+"]=" +aray[i]);
//    }
//}


NewMethod();

static void NewMethod()
{
    int[] array1 = new int[20];
    int[] array2 = new int[40];
    int n;
    int j = -1;
    do
    {
        n = Convert.ToInt32(Console.ReadLine());
    } while (n < 1 || n > 20);
    for (int i = 0; i < n; i++) 
    {

        Random rand = new Random();
        array1[i]=rand.Next(-100,0);

    }
    for (int i = 0; i < n; i++)
    {
        j++;
        array2[j] = array1[i];
        if (array1[i] < 0)
        {
            j++;
            for (int k = 0; k <= j; k++)
            {
                array2[k] = 0;
            }
        }
    }
    for(int i=0; i<=j; i++)
    {
        Console.WriteLine(array2[i]);
    }
    Console.ReadKey();
}