using ESH.Log.Parser.Engine.Services;
using ESH.Log.Parser.Engine.Services.Parser.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Engine.Tests.Moqs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Tests.Services.Parser
{
    [TestClass]
    public class ParserTests
    {
        LogParser logParser = new LogParser();

        [TestMethod]
        public void Test_MultipleLineMessage()
        {
            var logReader = new LogReader(ReaderMoqs.ReaderObject_LargeFileMoq);

            logParser.Target = new ParserObject()
            {
                Format = new MessageFormat(),
                PlainLines = logReader.Read()
            };

            var messages = logParser.Parse();

            Assert.IsTrue(messages.Count > 0);
        }
    }
}
