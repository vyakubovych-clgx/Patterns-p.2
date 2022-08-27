namespace Task1_3.Filters;

public interface IFilter
{
    IEnumerable<Trade> Match(IEnumerable<Trade> trades);
}