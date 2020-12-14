using System.Collections;
using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class BoardModel
    {
        public BoardContentModel Content { get; set; }
        public string AccessType { get; set; }
        
        public string[] AccessTypes = new[] {"Public", "Private"};
        public string AccessedUsers { get; set; }

        public IEnumerable<string> GetLoginsOfAccessedUsers()
        {
            return AccessedUsers.Split(' ');
        }
    }
}