using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTools.Scripts.Tips
{
    enum TipType
    {
        Normal,
        Alert,
        Error
    }

    internal class Tip
    {
        private string _title;
        private TipType _type;
        private string _description;
        private bool _show;  
    }
}
