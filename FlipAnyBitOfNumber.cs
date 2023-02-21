        //Input
            int n = 64, b = 2;
            Console.WriteLine(FlipAnyBitOfNumber(n, b));
            Console.ReadKey();
        
        public static int FlipAnyBitOfNumber(int number , int b)
        {
            //right shift 1 to b-1 place and X-OR with the number will Flip the bit on that position
            return number^ (1<<b-1);
        }
