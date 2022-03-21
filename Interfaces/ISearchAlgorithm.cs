namespace ALGORY
{
    public interface ISearchAlgorithm
    {
        (int iterationCount, bool isElementFound) Search();
    }
}