using ESH.Log.ParserEngine.Services.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Tests.Moqs
{
    public static class ReaderMoqs
    {

        public static ReaderObject ReaderObject_LargeFileMoq { get; set; } = new ReaderObject()
        {
            FileName = @"C:\x\logs\Tamam.Attendance.Capture.logs_20180101.txt",
            PageIndex = 1,
            PageSize = 99,
        };
        public static ReaderObject ReaderObject_SmallFileMoq { get; set; } = new ReaderObject()
        {
            FileName = @"C:\x\logs\Tamam.Web.logs_20171231.txt",
            PageIndex = null,
            PageSize = null,
        };
    }
}
