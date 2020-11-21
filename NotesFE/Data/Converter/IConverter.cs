namespace NotesFE.Data.Converter
{
    public interface IConverter<TSource, TResult>
    {
        TResult Convert(TSource source);
    }
}