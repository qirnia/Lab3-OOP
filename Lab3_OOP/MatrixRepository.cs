using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices;

    public MatrixRepository()
    {
        matrices = new List<Matrix>();
    }

    public void addMatrix(Matrix matrix)
    {
        matrices.Add(matrix);
    }

    public Matrix getMatrix(int index)
    {
        return matrices[index];
    }
}