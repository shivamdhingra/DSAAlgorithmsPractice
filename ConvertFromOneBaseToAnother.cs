            //Input 
            int n = 12, b = 5;
            int numberInDecimal = convertToDecimal(n, b);
            Console.WriteLine(numberInDecimal);
            Console.WriteLine(convertToBase(numberInDecimal, 2));
            Console.ReadKey(); 
            
        public static int convertToDecimal(int number , int b)
         {
            int ans = 0, multiple = 1;
            while(number!=0)
            {
                int digit = number % 10;
                ans = ans + digit * multiple;
                number= number / 10;
                multiple = multiple * b;
            }
            return ans;
         }

        public static int convertToBase(int number, int b)
        {
            int ans = 0, multiple = 1;
            while(number!=0)
            {
                int remainder = number % b;
                ans = ans + remainder * multiple;
                number = number / b;
                multiple = multiple * 10;
            }
            return ans;
        }
