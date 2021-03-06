﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESH.Log.Parser.Engine.Services.Support.Filter;
using ESH.Log.Parser.Engine.Services;
using ESH.Log.Parser.Engine.Tests.Moqs;
using System.Text;
using ESH.Log.Parser.Engine.Services.Support.Parser;

namespace ESH.Log.Parser.Engine.Tests.Services.Filter
{
    [TestClass]
    public class FilterTests
    {
        LogFilter filter = new LogFilter();
        [TestMethod] public void Test_NoFilter()
        {
            filter.Target = FilterMoqs.FilterObject_NoFilter_Moq;
            var filtered = filter.Filter();
            Assert.AreEqual(FilterMoqs.Messages.Count, filtered.Count);
        }
        [TestMethod] public void Test_ErrorsOnly()
        {
            filter.Target = FilterMoqs.FilterObject_ErrorsOnly_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Error).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_InfoOnly()
        {
            filter.Target = FilterMoqs.FilterObject_InfoOnly_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Info).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_TraceOnly()
        {
            filter.Target = FilterMoqs.FilterObject_TraceOnly_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Trace).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_WarningOnly()
        {
            filter.Target = FilterMoqs.FilterObject_WarningOnly_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Warning).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_Errors_Info()
        {
            filter.Target = FilterMoqs.FilterObject_Errors_Info_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Error || x.Type == Shared.LogType.Info).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_Errors_Info_Trace()
        {
            filter.Target = FilterMoqs.FilterObject_Errors_Info_Trace_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x => x.Type == Shared.LogType.Error || x.Type == Shared.LogType.Info || x.Type == Shared.LogType.Trace).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_Errors_Info_Warning()
        {
            filter.Target = FilterMoqs.FilterObject_Errors_Info_Warning_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = FilterMoqs.Messages.Where(x =>   x.Type == Shared.LogType.Error || 
                                                                    x.Type == Shared.LogType.Info || 
                                                                    x.Type == Shared.LogType.Warning).ToList();
            Assert.AreEqual(filteredExpected.Count, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected.Any(x => x.TextMessage == item.TextMessage));
            }
        }
        [TestMethod] public void Test_SelectedDates()
        {
            filter.Target = FilterMoqs.FilterObject_SelectedDates_Moq;
            var filteredActual = filter.Filter();
            var filteredExpected = "AttendanceHandler.GetScheduleEventCurrentlyIn ... ";
            Assert.AreEqual(1, filteredActual.Count);
            foreach (var item in filteredActual)
            {
                Assert.IsTrue(filteredExpected == item.TextMessage);
            }
        }
        [TestMethod] public void Test_SelectedRange()
        {
            filter.Target = FilterMoqs.FilterObject_SelectedRange_Moq;
            var filteredActual = filter.Filter();
            Assert.AreEqual(18, filteredActual.Count);
        }
        [TestMethod] public void Test_MessageCriteria_Broker()
        {
            filter.Target = FilterMoqs.FilterObject_MessageCriteria_Broker_Moq;
            var filteredActual = filter.Filter();
            Assert.AreEqual(5, filteredActual.Count);
        }
        [TestMethod] public void Test_MessageCriteria_Exception()
        {
            filter.Target = FilterMoqs.FilterObject_MessageCriteria_Exception_Moq;
            var filteredActual = filter.Filter();
            Assert.AreEqual(2, filteredActual.Count);
        }
    }
}
