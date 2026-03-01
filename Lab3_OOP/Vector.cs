using System;

public class Vector
{
    private int size;
    private double[] data;

    public Vector(int size)
    {
        this.size = size;
        data = new double[size];
    }

    public double getValue(int i)
    {
        return data[i];
    }

    public void setValue(int i, double value)
    {
        data[i] = value;
    }

    public int getSize()
    {
        return size;
    }

    public void display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }
}