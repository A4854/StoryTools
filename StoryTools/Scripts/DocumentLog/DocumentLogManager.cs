using System;

namespace StoryTools.Scripts.DocumentLog
{
    internal class DocumentLogManager
    {

        private void UpdateLog()
        {
            if (!GetLogs())
            {
                MakeLogSheet();
            }
            //todo
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
    }
}
