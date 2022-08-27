namespace Task1_2.Filters;

public interface IFilter
{
    IEnumerable<Trade> Match(IEnumerable<Trade> trades);
}