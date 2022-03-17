using System.Collections.Generic;

namespace StoryTools.Scripts.Tips
{
    internal class TipsManager
    {
        bool _isShow = false;
        List<Tip> Tips = new List<Tip>();

        public void ShowTip(string title, TipType tipType, string description)
        {
            InitTip(title, tipType, description);
            if (_isShow == false)
            {
                PopTip().Show();
                _isShow = true;
            }
        }

        private void InitTip(string title, TipType tipType, string description)
        {
            if (Tips == null)
            {
                Tips = new List<Tip>(); ;
            }
            Tip tip = new Tip();
            tip.Title = title;
            tip.Description = description;
            tip.Type = tipType;
            Tips.Add(tip);
        }

        private Tip PopTip()
        {
            Tip _tip = Tips[Tips.Count - 1];
            Tips.RemoveAt(Tips.Count - 1);
            return _tip;
        }

    }
}
