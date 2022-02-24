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

        public string Title { get => _title; set => _title = value; }
        internal TipType Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }

        public delegate void TipEventHandle();
        public event TipEventHandle OnTipClosed;

        public void Show()
        {
        }

        public void Close()
        {
            OnTipClosed?.Invoke();
        }
    }
}
