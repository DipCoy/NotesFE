namespace Domain
{
    public class Board//entity
    {
        public int Id { get; private set;}
        public BoardContent Content { get; private set; }
        
        public Board(int id, BoardContent content)
        {
            Id = id;
            Content = content;
        }
    }
}