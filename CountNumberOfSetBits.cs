            //Input
            int n = 9;
            Console.WriteLine(CountNumberOfSetBits(n));
            Console.ReadKey();
        
        public static int CountNumberOfSetBits(int number )
        {
            int count = 0;
            //we can interate on each bit of number and then count the 1 bits
            while(number!=0)
            {
                count += number & 1;
                number = number >> 1;
            }
            return count;
        }
