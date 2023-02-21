            //Input
            int n = 64, b = 2;
            Console.WriteLine(SetAnyBitOfNumber(n, b));
            Console.ReadKey(); 
 
        public static int SetAnyBitOfNumber(int number , int b)
        {
            //right shift 1 to b-1 place and Or with the number will set the bit on that position
            return number| (1<<b-1);
        }
