namespace Task1_1.Filters;

public interface IFilter
{
    IEnumerable<Trade> Match(IEnumerable<Trade> trades);
}