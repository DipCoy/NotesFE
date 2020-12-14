using System.Collections.Generic;
using Domain.Models;

namespace Domain.ViewModels
{
    public class BoardContentModel
    {
        public IEnumerable<StickerModel> Stickers { get; set; }
    }
}