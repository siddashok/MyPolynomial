using System;

namespace MyPolynomial
{  
      public class program
    { 
         public static void Main(string[] args)
        {
            double[] polynomial1 = { 2, 1, -3, 0, 3 };       //3x^4 - 3x^2 + 1x^1 + 2x^0
            double[] polynomial2 = { 4, -1, 1, -4,  2 };    //2x^4 - 4x^3 + 1x^2 - 1x^1 + 4x^0
            MyPolynomial p1 = new MyPolynomial(polynomial1);
            MyPolynomial p2 = new MyPolynomial(polynomial2);
            
            Console.WriteLine("First Polynomial: ");
            Console.WriteLine(p1 + "\n");
            Console.WriteLine("Second Polynomial: ");
            Console.WriteLine(p2 + "\n");

            Console.WriteLine("Provide the Value of X for Evaluation");
            int x_val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Evaluated Value of Polynomial 1:");
            Console.WriteLine(p1.Evaluate(x_val));
            Console.WriteLine("Evaluated Value of Polynomial 2:");
            Console.WriteLine(p2.Evaluate(x_val));

            Console.WriteLine("Polynomial Addition: ");
            MyPolynomial polynomial_add = p1.Add(p2);
            Console.WriteLine(polynomial_add + "\n");
            Console.WriteLine("Polynomial Multiplication: ");
            MyPolynomial polynomial_mul = p1.Multiply(p2);
            Console.WriteLine(polynomial_mul + "\n");
        }
    }
}
