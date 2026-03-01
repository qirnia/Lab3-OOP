using System;

public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];

        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public double getValue(int i, int j)
    {
        return rowData[i].getValue(j);
    }

    public void setValue(int i, int j, double value)
    {
        rowData[i].setValue(j, value);
    }

    public int getRows()
    {
        return rows;
    }

    public int getCols()
    {
        return cols;
    }

    public void display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(getValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
}