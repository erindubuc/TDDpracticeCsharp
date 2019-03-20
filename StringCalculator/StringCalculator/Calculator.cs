namespace StringCalculator
{
    public class Calculator
    {
        public int Add(int num)
        {
            if (num == ' ')    
                return 0;
            return num;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        
    }
}