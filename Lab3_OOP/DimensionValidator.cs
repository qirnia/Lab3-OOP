public class DimensionValidator
{
    public bool validateMatrixAddition(Matrix A, Matrix B)
    {
        return A.getRows() == B.getRows() &&
               A.getCols() == B.getCols();
    }

    public bool validateVectorAddition(Vector A, Vector B)
    {
        return A.getSize() == B.getSize();
    }
}