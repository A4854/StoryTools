using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTools.Scripts.DocumentLog
{
    internal class DocumentLogManager
    {
        public delegate void UpdateLogEventHandler();
        public event UpdateLogEventHandler OnUpdateLogFinish;

        private void UpdateLog()
        {
            if (!GetLogs())
            {
                MakeLogSheet();
            }
            //todo
            OnUpdateLogFinish.Invoke();
            return;
        }

        private bool GetLogs()
        {
            return true;
        }

        private void AppendLog(DateTime logDate, string logBlame, string[] logContent = null)
        {
            DocumentLogInfo documentLogInfo = new DocumentLogInfo();
            documentLogInfo.LogDate = logDate;
            documentLogInfo.LogBlame = logBlame;
            documentLogInfo.LogContent = logContent;
        }

        private void MakeLogSheet()
        {
            //todo
            return;
        }

        event EventHandler<EventArgs> UpdateFinished;
    }
}
