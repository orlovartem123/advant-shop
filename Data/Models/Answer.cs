using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public int Fkidtheme { get; set; }
        public string Name { get; set; }
        public int CountVoice { get; set; }
        public int Sort { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateModify { get; set; }

        public VoiceTheme FkidthemeNavigation { get; set; }
    }
}
