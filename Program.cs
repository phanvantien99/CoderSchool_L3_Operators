namespace CoderSchool_L3_Operators;

class Program
{
    static void Main(string[] args)
    {
        //---------------------------------------------------------------------
        // Part 1: Mathematical Operators
        // Write a C# program to print the sum of two numbers.
        // Hint: You can use the + operator to add two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int num1 = 10, num2 = 5;
        Console.WriteLine("Part 1, + Operator: " + (num1 + num2));


        //---------------------------------------------------------------------
        // Part 2: Mathematical Operators
        // Write a C# program to print the difference between two numbers.
        // Hint: You can use the - operator to subtract two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int subtract_num1 = 10, subtract_num2 = 5;
        Console.WriteLine("Part 2, - Operator: " + (subtract_num1 - subtract_num2));


        //---------------------------------------------------------------------
        // Part 3: Mathematical Operators
        // Write a C# program to print the product of two numbers.
        // Hint: You can use the * operator to multiply two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int multiply_num1 = 10, multiply_num2 = 5;
        Console.WriteLine("Part 3, * Operator: " + (multiply_num1 * multiply_num2));

        //---------------------------------------------------------------------
        // Part 4: Mathematical Operators
        // Write a C# program to print the division of two numbers.
        // Hint: You can use the / operator to divide two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int divide_num1 = 10, divide_num2 = 5;
        Console.WriteLine("Part 4, / Operator: " + (divide_num1 / divide_num2));


        //---------------------------------------------------------------------
        // Part 5: Mathematical Operators
        // Write a C# program to print the remainder of two numbers.
        // Hint: You can use the % operator to find the remainder of two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int remainder_num1 = 10, remainder_num2 = 5;
        Console.WriteLine("Part 5, % Operator: " + (remainder_num1 % remainder_num2));


        //---------------------------------------------------------------------
        // Part 6: Mathematical Operators
        // Write a C# program to calculate the square of a number.
        // Hint: You can use the * operator to multiply a number by itself.
        // Test data: int num = 5
        int square_num = 5;
        Console.WriteLine("Part 6, square Operator: " + (square_num * square_num));


        //---------------------------------------------------------------------
        // Part 7: Mathematical Operators
        // Write a C# program to calculate the average of two numbers.
        // Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
        // Test data: int num1 = 10, int num2 = 20
        int average_num1 = 10, average_num2 = 20;
        Console.WriteLine("Part 7, average Operator: " + ((average_num1 + average_num2) / 2));

        //---------------------------------------------------------------------
        // Part 8: Mathematical Operators
        // Write a C# program to calculate the average of three numbers.
        // Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
        // Test data: int num1 = 10, int num2 = 20, int num3 = 30
        int average_num3 = 10, average_num4 = 20, average_num5 = 30;
        Console.WriteLine("Part 8, average Operator: " + ((average_num3 + average_num4 + average_num5) / 3));


        //---------------------------------------------------------------------
        // Part 9: Mathematical Operators
        // Write a C# program to convert temperature from Celsius to Fahrenheit.
        // Hint: Use the formula (Celsius * 9/5) + 32.
        // Test data: double celsius = 20
        double celsius = 20;
        Console.WriteLine("Part 9, average Celsius: " + ((celsius * 9 / 5) + 32));


        //---------------------------------------------------------------------
        // Part 10: Mathematical Operators
        // Write a C# program to calculate the area of a rectangle given its length and width.
        // Hint: Use the formula area = length * width.
        // Test data: double length = 10, double width = 5
        double length = 10, width = 5;
        Console.WriteLine("Part 10,area of a rectangle: " + (length * width));


        //---------------------------------------------------------------------
        // Part 11: Mathematical Operators
        // Write a C# program to calculate the volume of a sphere given its radius.
        // Hint: Use the formula volume = (4/3) * Pi * radius^3.
        // Test data: double radius = 5
        double radius = 5;
        const float divideFourPi = 4f / 3f;
        Console.WriteLine("Part 11, volume of a sphere: " + (divideFourPi * Math.PI * Math.Pow(radius, 3)));


        //---------------------------------------------------------------------
        // Part 12: Mathematical Operators
        // Write a C# program to calculate the factorial of a given integer.
        // Hint: Use a loop to multiply the numbers from 1 to the given integer.
        // Test data: int num = 5
        int num_loop = 5;
        int result_factorial = 1;
        for (int i = 1; i <= num_loop; i++)
        {
            result_factorial *= i;
        }
        Console.WriteLine("Part 12, factorial integer of " + num_loop + ": " + result_factorial);

        //---------------------------------------------------------------------
        // Part 13: Mathematical Operators
        // Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
        // Hint: Use the formula A = P * (1 + r/n)^(nt).
        // Test data: double principal = 1000, double rate = 0.05, int time = 5
        // missing time for formula -> t: time
        double principal = 1000;
        double rate = 0.05;
        int time = 5;
        float monthInDecimal = 3f / 12f;
        double compound_interest = principal * Math.Pow(1 + rate / time, time * monthInDecimal);
        Console.WriteLine("Part 13, compound interest: " + compound_interest);

        //---------------------------------------------------------------------
        // Part 14: Mathematical Operators
        // Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
        // Hint: Use the quadratic formula.
        // Test data: double a = 1, double b = 5, double c = 6
        double a = 1;
        double b = 5;
        double c = 6;
        double numerical_solution_1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        double numerical_solution_2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        Console.WriteLine("Part 14, numerical_solution_1: " + numerical_solution_1);
        Console.WriteLine("Part 14, numerical_solution_2: " + numerical_solution_2);

        //---------------------------------------------------------------------
        // Part 15: Mathematical Operators
        // Write a C# program to calculate the nth Fibonacci number using recursion.
        // Hint: Use a recursive function to calculate Fibonacci numbers.
        // Test data: int n = 8
        int n = 8;
        Console.Write("Part 15, Fibonancci number: ");
        Fibonacci(0, 1, 1, n);


        //---------------------------------------------------------------------
        // Part 16: Mathematical Operators
        // Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
        // Hint: Use the formula nth term = first term + (n - 1) * common difference.
        // Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5
        int firstTerm = 3, commonDifference = 2, termNumber = 5;
        Console.Write("\nPart 16, term of the arithmetic sequence: ");
        for (int i = 1; i <= termNumber; i++)
        {
            Console.Write(firstTerm + (i - 1) * commonDifference + "  ");
        }


        //---------------------------------------------------------------------
        // Part 17: Relational Operators
        // Write a C# program to check if a given number is greater than another number.
        // Hint: Use the > operator to check if the first number is greater than the second number.
        // Test data: int num1 = 10, int num2 = 5

        int compare_num_1 = 10;
        int compare_num_2 = 5;
        Console.WriteLine("\nPart 17, greater than: " + (compare_num_1 > compare_num_2));



        //---------------------------------------------------------------------
        // Part 18: Relational Operators
        // Write a C# program to check if a given number is less than or equal to 100.
        // Prompt the user to enter a number and check if it is less than or equal to 100.
        // Hint: Use the <= operator to check if the number is less than or equal to 100.
        // Test data: Enter a number: 88
        Console.WriteLine("Part 18, enter number: ");
        int compare_num_3 = int.Parse(Console.ReadLine());
        Console.WriteLine("less equal 100: " + (compare_num_3 <= 100));



        //---------------------------------------------------------------------
        // Part 19: Logical Operators
        // Write a C# program to check if a given number is even AND greater than 10.
        // Prompt the user to enter a number and check if it satisfies both conditions.
        // Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
        // Test data: Enter a number: 16
        Console.WriteLine("Part 19, enter number: ");
        int evenGreaterThan10 = int.Parse(Console.ReadLine());
        Console.WriteLine(evenGreaterThan10 + " is even and greater than 10: " + (evenGreaterThan10 % 2 == 0 && evenGreaterThan10 > 10));

        //---------------------------------------------------------------------
        // Part 20: Logical Operators
        // Write a C# program to check if a given number is divisible by 3 OR 5.
        // Prompt the user to enter a number and check if it is divisible by either 3 or 5.
        // Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
        // Test data: Enter a number: 9
        Console.WriteLine("Part 20, enter number: ");
        int divisible_3_or_5 = int.Parse(Console.ReadLine());
        Console.WriteLine(divisible_3_or_5 + " is divisible for 3 or 5: " + (divisible_3_or_5 % 3 == 0 || divisible_3_or_5 % 5 == 0));
        //---------------------------------------------------------------------
        // Part 21: Initialization and Assignment Operators
        // Write a C# program to increment a variable by 5 using the shorthand assignment operator.
        // Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
        // Hint: Use the += operator to increment the variable by 5.
        // Test data: Enter a number: 7
        Console.WriteLine("Part 21, enter number: ");
        int number_increment_time = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < number_increment_time; i++)
        {
            result += 5;
        }
        Console.WriteLine("Number increment time by 5 with " + number_increment_time + " time: " + result);

        //---------------------------------------------------------------------
        // Part 22: Initialization and Assignment Operators
        // Write a C# program to remainder and update the number using the %= operator.
        // Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
        // Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
        // Test data: int number = 27

        int number = 27;
        number %= 7;
        Console.WriteLine("Part 22, remainder and update the number: " + number);
    }

    public static void Fibonacci(int a, int b, int counter, int number)
    {
        Console.Write(a + " ");
        if (counter < number) Fibonacci(b, a + b, counter + 1, number);
    }
}
