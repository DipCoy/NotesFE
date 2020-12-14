using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class BoardContentModel
    {
        public IEnumerable<StickerModel> Stickers { get; set; }
    }
}