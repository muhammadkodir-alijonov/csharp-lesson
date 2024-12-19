class Program
{
    public static void Main()
    {
        /*//arry example.
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++) 
        {
            int t = int.Parse(Console.ReadLine());
            arr[i] = DateTime.Now.Millisecond;
            Console.WriteLine(arr[i]);
        }*/

        // n*m matritsani random tarzda to'ldirish
        /*int[,] arr = new int[10, 10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                arr[i, j] = random.Next(1, 10);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0,5}", arr[i, j]);
            }
            Console.WriteLine("\n");
        }*/

        // sort function body
        /*  int[] arrr = new int[10] {1,2,3,5,7,5,3,2,6,9};

        int[] arrrnew = Sort(arrr);

        for (int i = 0; i < arrrnew.Length; i++)
        {
            Console.WriteLine(arrrnew[i]);
        }*/

        /*// params bu umumiy qiymatlarni 1 ta array deb hisoblab ketadi
        Console.WriteLine(Sum(2,3,4,5,6));
        Console.WriteLine(Sum(1,2));
        Console.WriteLine(Sum(3,4,6));
        Console.WriteLine(Sum(3,44,4,5,6,7));
        Console.WriteLine(Sum(6,7,90,6,4,3,5));*/

        // foreach indekssiz ishlaydi for esa idex bln ishlaydi
        /*int[] arr = new int[] { 1, 2, 3, 5, 6, 8, 9, 11, 76,99};
        foreach (int i in arr)
        {
            if(i%2 == 0) Console.WriteLine(i);
        }*/
    }
    /*//sort function
    public static int[] Sort(int[] arr) 
    {
        return arr.OrderByDescending(x=>x).ToArray();
    }*/

    /*//params funcstion
    public static int Sum(params int[] s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            sum += s[i];
        }
        return sum;
    }*/
}
