using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public interface IRecord
    {
        public IHaveRecord FromRecord();
    }
}