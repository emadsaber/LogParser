using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESH.Log.Parser.Engine.Tests.Moqs;
using System.Diagnostics;
using ESH.Log.Parser.Engine.Services;

namespace ESH.Log.Parser.Engine.Tests.Services.Reader
{
    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void TestReadWholeFile()
        {
            var reader = new LogReader(ReaderMoqs.ReaderObject_SmallFileMoq);
            var output = reader.Read();

            Assert.AreNotEqual(null, output);
            Assert.AreEqual(56531, output.Count);

            output.ForEach(x => Debug.WriteLine(x));
        }

        [TestMethod]
        public void TestReadPages()
        {
            var reader = new LogReader(ReaderMoqs.ReaderObject_LargeFileMoq);
            var output = reader.Read();

            Assert.AreNotEqual(null, output);
            Assert.AreEqual(ReaderMoqs.ReaderObject_LargeFileMoq.PageSize, output.Count);
            output.ForEach(x => Debug.WriteLine(x));
        }
    }
}
