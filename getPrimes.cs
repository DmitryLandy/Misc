class Program
    {
        static void Main(string[] args)
        {
            //find all primes 0-100

            solution1(0,100); //O(n^2)                       
            
        }
        private static void solution1(int start, int end)
        {
            bool isPrime = true;
            for (int current = start; current <= end; current++)
            {
                isPrime = true;

                if (current == 0 || current == 1) continue;
                
                for (int testing = start; testing < current; testing++)
                {
                    if (testing != 0 && testing != 1)
                    {
                        if (current % testing == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }                    
                }
                if(isPrime)
                {
                    Console.WriteLine(current);
                }
                    
            }
        }
               
    }
