﻿using StoryTools.Scripts.DataHelper;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using StoryTools.Scripts.Global;

namespace StoryTools.Scripts.DocumentLog
{
    internal static class DocumentLogManager
    {

        private static void UpdateLog()
        {
            if (!GetLogs())
            {
                MakeLogSheet();
            }
            //todo
            return;
        }

        private static bool GetLogs()
        {
            return true;
        }

        private static void AppendLog(DateTime logDate, string logBlame, string[] logContent = null)
        {
            DocumentLogInfo documentLogInfo = new DocumentLogInfo
            {
                LogDate = logDate,
                LogBlame = logBlame,
                LogContent = logContent
            };
        }

        public static void MakeLog(Excel.Workbook workbook)
        {
            var currentUser = Config.ConfigManager.Get().GetConfig(Defination.UserName);
            var logSheet = workbook.Worksheets.Add() as Excel._Worksheet;
            logSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
            logSheet.Name = "log";
            logSheet.Columns.ColumnWidth = 30;
            logSheet.Rows.RowHeight = 18.75;

            DoExcel.InitRange(workbook, logSheet.Range["A1", "C1"], "LogTitle", "日期", "修改人", "修改内容");
            DoExcel.InitRange(workbook, logSheet.Range["A2", "C2"], "LogContent", DateTime.Today.ToShortDateString(), currentUser, "");
            DoExcel.InitRange(workbook, logSheet.Range["A3", "C10"], "LogContent", null);
        }

        private static void MakeLogSheet()
        {
            //todo
            return;
        }
    }
}
