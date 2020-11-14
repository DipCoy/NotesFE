using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public class StickerContentRecord : IRecord
    {
        public string Text;
        public IHaveRecord FromRecord()
        {
            throw new System.NotImplementedException();
        }
    }
}