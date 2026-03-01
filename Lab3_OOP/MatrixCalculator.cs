public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Matrix? add(Matrix A, Matrix B)
    {
        if (!validator.validateMatrixAddition(A, B))
        {
            return null;
        }

        Matrix result = new Matrix(A.getRows(), A.getCols());

        for (int i = 0; i < A.getRows(); i++)
        {
            for (int j = 0; j < A.getCols(); j++)
            {
                double sum = A.getValue(i, j) + B.getValue(i, j);
                result.setValue(i, j, sum);
            }
        }

        return result;
    }
}