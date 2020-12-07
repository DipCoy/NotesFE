using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotesFETelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://notesfe.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "notesfe_bot";

        public static string Key { get; set; } = "1431072841:AAHaN_sgHNCkZgueophfUTPO0qiYJ__RSeA";

    }
}