public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Vector? add(Vector A, Vector B)
    {
        if (!validator.validateVectorAddition(A, B))
        {
            return null;
        }

        Vector result = new Vector(A.getSize());

        for (int i = 0; i < A.getSize(); i++)
        {
            double sum = A.getValue(i) + B.getValue(i);
            result.setValue(i, sum);
        }

        return result;
    }
}