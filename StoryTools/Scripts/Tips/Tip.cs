using System;
using WindowsForm = System.Windows.Forms;

namespace StoryTools.Scripts.Tips
{
    enum TipType
    {
        Normal,
        Alert,
        Error
    }

    internal class Tip : WindowsForm.CommonDialog
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
            this.Title = "111111";
        }

        public void Close()
        {
            OnTipClosed?.Invoke();
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            throw new NotImplementedException();
        }
    }
}
