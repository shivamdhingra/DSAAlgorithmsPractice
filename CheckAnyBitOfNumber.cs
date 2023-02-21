            int n = 64, b = 3;
            Console.WriteLine(CheckAnyBitOfNumber(n, b));
            Console.ReadKey();

      public static int CheckAnyBitOfNumber(int number , int b)
        {

            //right shift the number to b-1 place and & the number with 1 gives the ith bit value
            return number >>b -1 &1;
        }
