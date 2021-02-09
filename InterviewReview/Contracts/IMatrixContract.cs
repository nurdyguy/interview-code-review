namespace InterviewReview.Contracts
{
    public interface IMatrixContract
    {
        /// <summary>
        /// The Task:
        ///     Given a base grid of indeterminate size but of equal lengths (i.e. 10x10 or 20x20)
        /// calculate the greatest product of four adjacent numbers in the same direction
        /// (up, down, left, right or diagonally) within the grid.
        ///
        /// Feel free to modify this signature to better suite your needs
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        object Calculate(int[][] collection);
    }
}
