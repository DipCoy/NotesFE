namespace Application.Converters
{
    public interface IConverter<TSource, TResult>
    {
        TResult Convert(TSource source);
    }
}