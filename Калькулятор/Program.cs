namespace Калькулятор
{
    internal class Calculator : IMath
    {
        public delegate double Add(double a, double b);
        public delegate double Mult(double a, double b);
        public delegate double Sub(double a, double b);
        public delegate double Div(double a, double b);

        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }


        static int Move(int i, int n, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                i = (n + i - 1) % n;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                i = (i + 1) % n;
            }

            return i;
        }

        static void Main()
        {
            Calculator calculator = new Calculator();
            Add add = calculator.Addition;
            Mult mult = calculator.Multiplication;
            Sub sub = calculator.Subtraction;
            Div div = calculator.Division;

            Console.WriteLine("Введите первый операнд");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            double b = Double.Parse(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            int n = 5, i = 0;
            Console.WriteLine("Сложение");
            Console.WriteLine("Умножжжжжение");
            Console.WriteLine("Вычитание");
            Console.WriteLine("Деление");
            Console.WriteLine("Выйти");

            while (true)
            {
                Console.SetCursorPosition(30, i);
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(add(a, b));
                            break;

                        case 1:
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(mult(a, b));
                            break;

                        case 2:
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(sub(a, b));
                            break;

                        case 3:
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            if (b != 0)
                                Console.WriteLine(div(a, b));
                            else
                                Console.WriteLine("Не делай так, пожалуйста");
                            break;
                    }
                    Console.WriteLine("Всего хорошего!");
                    break;
                }
                i = Move(i, n, key);
            }
        }
    }
}