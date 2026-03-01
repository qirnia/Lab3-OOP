public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public double getValue(int j)
    {
        return values[j];
    }

    public void setValue(int j, double value)
    {
        values[j] = value;
    }

    public int length()
    {
        return values.Length;
    }
}