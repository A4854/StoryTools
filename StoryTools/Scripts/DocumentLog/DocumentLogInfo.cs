using System;

namespace StoryTools.Scripts.DocumentLog
{
    internal class DocumentLogInfo
    {
        private DateTime _logDate;
        private string _logBlame;
        private string[] _logContent;

        public DateTime LogDate { get => _logDate; set => _logDate = value; }
        public string LogBlame { get => _logBlame; set => _logBlame = value; }
        public string[] LogContent { get => _logContent; set => _logContent = value; }
    }
}
