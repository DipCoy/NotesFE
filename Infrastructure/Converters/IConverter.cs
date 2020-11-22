namespace Infrastructure.Converter
{
    public interface IConverter<TSource, TResult>
    {
        TResult Convert(TSource source);
    }
}