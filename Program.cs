namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operation;
            double A, B, res = 0;

            GetInputAsNumber(nameof(A), out A);

            do Console.Write("Введите операцию: ");
            while (!char.TryParse(Console.ReadLine(), out operation) || (operation != '+' && operation != '-' && operation != '*' && operation != '/'));
            
            GetInputAsNumber(nameof(B), out B);

            switch (operation)
            {
                case '+':
                    res = A + B;
                    break;
                case '-':
                    res = A - B;
                    break;
                case '/':
                    res = A / B;
                    break;
                case '*':
                    res = A * B;
                    break;
            }
            Console.WriteLine($"\n{A} {operation} {B} = {res}");
        }

        public static void GetInputAsNumber(string inputName, out double input)
        {
            do Console.Write($"Введите {inputName}: ");
            while (!double.TryParse(Console.ReadLine(), out input));
        }
    }
}