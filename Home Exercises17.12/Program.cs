namespace Home_Exercises17._12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        #region 1-ci tapshiriq
            //    Console.WriteLine("Ededi daxil edin:");
            //    long n = long.Parse(Console.ReadLine());
            //    long count = 0;
            //    if (n == 0)
            //    {
            //        Console.Write("Reqemlerin sayi= 0");
            //        return;
            //    }
            //    while (n > 0)
            //    {
            //        n = n / 10;
            //        count = count + 1;
            //    }
            //    Console.Write("Reqemlerin sayi= " + count);
            //}
            #endregion
        #region 2 -ci tapshiriq
            //    int n, sum = 0, m;
            //    Console.Write("Enter a number: ");
            //    n = int.Parse(Console.ReadLine());
            //    while (n > 0)
            //    {
            //        m = n % 10;
            //        sum += m;
            //        n = n / 10;
            //    }
            //    Console.Write("Sum is= " + sum);
            //}
            #endregion
        #region 3-cu tapshiriq
        //    int n;
        //    Console.Write("Ededlerin sayin daxil edin:");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    int[] arr = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"arr[{i}]=");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    int max = arr[0];
        //    int min = arr[0];
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (max < arr[i])
        //        {
        //            max = arr[i];
        //        }
        //        if (min > arr[i])
        //        {
        //            min = arr[i];
        //        }
        //    }
        //    Console.WriteLine("max:" + max + " " + "min:" + min);
        //    max = max + min;
        //    min = max - min;
        //    max = max - min;
        //    Console.WriteLine(max + " " + min);
        //}
        #endregion
        #region 4-cu tapshiriq
        //    int n, a;
        //    Console.Write("Ededlerin sayin daxil edin:");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    int[] arr = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"arr[{i}]=");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int i = 0; i < n; i ++)
        //    {
        //        a = arr[i];
        //        if (a % 2 == 0 && a > 0)
        //        {
        //            a = a * (-1);
        //            Console.WriteLine("Cut ededir: " + a);
        //        }
        //        else if (a % 2 == 0 && a < 0)
        //        {
        //            a = a * (-1);
        //            Console.WriteLine("Cut ededir: " + a);
        //        }
        //    }
        //}
        #endregion
        #region 5-ci tapshiriq
        //    int n, r, m;
        //    Console.WriteLine("Ededi daxil edin:");
        //    n = int.Parse(Console.ReadLine());
        //    r = n % 10;
        //    n = n / 10;
        //    m = n % 10;
        //    if (m > r)
        //    {
        //        Console.WriteLine("Onlug boyukdur:" + m);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Teklik boyukdur:" + r);
        //    }
        //}
        #endregion
        #region 6-ci tapshiriq
        //    int n, r, digit = 0;
        //    Console.Write("Enter a number:");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    while (n > 0)
        //    {
        //        r = n % 10;
        //        if (digit < r)
        //        {
        //            digit = r;
        //        }
        //        n = n / 10;
        //    }
        //    Console.WriteLine("Largest digit:" + digit);
        //}
        #endregion
        #region Elave tapshiriq
        //    int n, result = 0;
        //    Console.Write("Ededi daxil edin: ");
        //    n = Int32.Parse(Console.ReadLine());
        //    while (n > 0)
        //    {
        //        result = result * 10;
        //        result = result + (n % 10);
        //        n = n / 10;
        //    }
        //    Console.WriteLine(result);
        //}
        #endregion
    }
}

