namespace Domain.Models
{
    public class StickerContent
    {
        public string Text { get; set; }
        public TimeTable TimeTable { get; set; }

        public StickerContent(string text, TimeTable timeTable)
        {
            Text = text;
            TimeTable = timeTable;
        }
    }
}