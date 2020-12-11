using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Domain.Models
{
    public class Board//entity
    {
        public Guid Id { get; private set;}
        public BoardContent Content { get; private set; }

        private HashSet<Guid> whoHasAccess;

        public HashSet<Guid> WhoHasAccess => whoHasAccess?.ToHashSet();
        
        public Board(BoardContent content, IEnumerable<Guid> whoHasAccess = null)
        {
            Content = content;
            
            if (whoHasAccess != null)
                this.whoHasAccess = whoHasAccess.ToHashSet();
        }

        public bool HasAccess(User user)
        {
            return whoHasAccess is null || whoHasAccess.Contains(user.Id);
        }
    }
}