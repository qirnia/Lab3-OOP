using System;

class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        DimensionValidator validator = new DimensionValidator();

        MatrixCalculator matrixCalc = new MatrixCalculator(validator);
        VectorCalculator vectorCalc = new VectorCalculator(validator);

        Console.WriteLine("=== Matrix Input A ===");
        Matrix A = inputHandler.inputMatrix();

        Console.WriteLine("=== Matrix Input B ===");
        Matrix B = inputHandler.inputMatrix();

        Matrix? matrixResult = matrixCalc.add(A, B);

        if (matrixResult != null)
        {
            Console.WriteLine("Matrix Addition Result:");
            matrixResult.display();
        }
        else
        {
            Console.WriteLine("Matrix dimensions not compatible.");
        }

        Console.WriteLine("=== Vector Input A ===");
        Vector v1 = inputHandler.inputVector();

        Console.WriteLine("=== Vector Input B ===");
        Vector v2 = inputHandler.inputVector();

        Vector? vectorResult = vectorCalc.add(v1, v2);

        if (vectorResult != null)
        {
            Console.WriteLine("Vector Addition Result:");
            vectorResult.display();
        }
        else
        {
            Console.WriteLine("Vector sizes not compatible.");
        }
    }
}