using System.Collections;
using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class BoardModel
    {
        public string AccessType { get; set; }
        public string[] AccessTypes = new[] {"Public", "Private"};
        public string[] StickersText { get; set; }
        public string AccessedUsers { get; set; }

        public IEnumerable<string> GetLoginsOfAccessedUsers()
        {
            return AccessedUsers.Split(' ');
        }
    }
}