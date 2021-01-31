using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VoiceTheme
    {
        public VoiceTheme()
        {
            Answer = new HashSet<Answer>();
        }

        public int VoiceThemeId { get; set; }
        public int Psyid { get; set; }
        public string Name { get; set; }
        public bool IsHaveNullVoice { get; set; }
        public bool IsDefault { get; set; }
        public bool IsClose { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateModify { get; set; }

        public ICollection<Answer> Answer { get; set; }
    }
}
