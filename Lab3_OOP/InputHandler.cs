using System;

public class InputHandler
{
    public Matrix inputMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine()!);

        Matrix matrix = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter value for [" + i + "," + j + "]: ");
                double value = double.Parse(Console.ReadLine()!);
                matrix.setValue(i, j, value);
            }
        }

        return matrix;
    }

    public Vector inputVector()
    {
        Console.Write("Enter vector size: ");
        int size = int.Parse(Console.ReadLine()!);

        Vector vector = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value for index " + i + ": ");
            double value = double.Parse(Console.ReadLine()!);
            vector.setValue(i, value);
        }

        return vector;
    }
}