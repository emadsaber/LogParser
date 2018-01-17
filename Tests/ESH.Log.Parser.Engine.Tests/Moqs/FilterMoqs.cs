using ESH.Log.Parser.Engine.Services.Support.Filter;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Engine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Tests.Moqs
{
    public static class FilterMoqs
    {
        #region properties
        public static string CurrentFormat => "dd.MM.yyyy HH:mm:ss";

        #region Messages
        public static List<Message> Messages => new List<Message>()
            {
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:11:54",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("Broker..cctor ... ServiceBroker ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:11:54",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("Broker..cctor ... ServiceBroker ... loading basic configuration handler ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:11:56",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("Broker..cctor ... ServiceBroker ... loading data handler for configuration handler ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:01",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("Broker.Initialize ... ServiceBroker ... the handler with the key [ConfigurationDataHandler] started successfully.") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:01",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("Broker..cctor ... ServiceBroker ... loading configuration handler ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:01",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("RuntimeTypeHandle.CreateInstance ... ConfigurationHandler ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:01",CurrentFormat, null), Type = LogType.Error, MessageBuilder = new StringBuilder().Append("RuntimeType.CreateInstanceDefaultCtor ... PersonnelHandler ... Initializing ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:02",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("RuntimeType.CreateInstanceDefaultCtor ... AttendanceHandler ... Initializing ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:02",CurrentFormat, null), Type = LogType.Error, MessageBuilder = new StringBuilder().Append("RuntimeType.CreateInstanceDefaultCtor ... LeavesHandler ... Initializing ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:07",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("PresenceStateHandler.Authenticate ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:07",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("AuthenticationService.Authenticate ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Error,
                    MessageBuilder = new StringBuilder()
                                        .AppendLine(" RuntimeMethodHandle.InvokeMethod ... Exception : System.Threading.ThreadAbortException: Thread was being aborted.")
                                        .AppendLine(" at System.Threading.Thread.AbortInternal()")
                                        .AppendLine(" at System.Threading.Thread.Abort(Object stateInfo)")
                                        .AppendLine(" at System.Web.HttpResponse.AbortCurrentThread()")
                                        .AppendLine(" at System.Web.HttpResponse.Redirect(String url, Boolean endResponse, Boolean permanent)")
                                        .AppendLine(" at ADS.Tamam.Clients.Web.Common.Handlers.PresenceStateHandler.GoToLogin()")
                                        .AppendLine(" at ADS.Tamam.Clients.Web.Global.HandleAuthentication()")
                                        .AppendLine(" at ADS.Tamam.Clients.Web.Global.Application_AcquireRequestState()") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Error, MessageBuilder = new StringBuilder().Append("OrganizationHandler+<>c__DisplayClass13_0.<GetDepartmentsByPerson>b__0 ... Cache Service : couldn't reach the caching service (connection to service is down, please check the network), skipping it ...") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Warning,
                    MessageBuilder = new StringBuilder()
                                        .AppendLine("CacheClient.Get ... Exception : System.ArgumentException: token")
                                        .AppendLine("at ProtoBuf.ProtoReader.EndSubItem(SubItemToken token, ProtoReader reader)")
                                        .AppendLine("at ProtoBuf.Meta.TypeModel.TryDeserializeAuxiliaryType(ProtoReader reader, DataFormat format, Int32 tag, Type type, Object& value, Boolean skipOtherFields, Boolean asListItem, Boolean autoCreate, Boolean insideList)")
                                        .AppendLine("at ProtoBuf.Meta.TypeModel.TryDeserializeList(TypeModel model, ProtoReader reader, DataFormat format, Int32 tag, Type listType, Type itemType, Object& value)")
                                        .AppendLine("at ProtoBuf.Meta.TypeModel.TryDeserializeAuxiliaryType(ProtoReader reader, DataFormat format, Int32 tag, Type type, Object& value, Boolean skipOtherFields, Boolean asListItem, Boolean autoCreate, Boolean insideList)")
                                        .AppendLine("at ProtoBuf.Meta.TypeModel.DeserializeCore(ProtoReader reader, Type type, Object value, Boolean noAutoCreate)")
                                        .AppendLine("at ProtoBuf.Meta.TypeModel.Deserialize(Stream source, Object value, Type type, SerializationContext context)")
                                        .AppendLine("at ProtoBuf.Serializer.Deserialize[T](Stream source)")
                                        .AppendLine("at ADS.Common.Handlers.Serialization.ProtobufSerializerHandler.Deserialize[T](Byte[] data)")
                                        .AppendLine("at ADS.Common.Utilities.XSerialize.DeserializeFromBinaryArrayProtobuf[T](Byte[] data)") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("SecurityHandler.Authorize ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("SecurityHandler.Authorize ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.11.2017 07:12:08",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("SecurityHandler.Authorize ... ") },
                new Message { TimeStamp = DateTime.ParseExact("27.11.2017 07:12:09",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("SecurityHandler.Authorize ... ") },
                new Message { TimeStamp = DateTime.ParseExact("28.11.2017 07:12:09",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("SecurityHandler.Authorize ... ") },
                new Message { TimeStamp = DateTime.ParseExact("21.11.2017 07:12:09",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("OrganizationDataHandler.GetDepartmentsByPersonScalar ... ") },
                new Message { TimeStamp = DateTime.ParseExact("21.11.2017 07:12:09",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("AttendanceDataHandler.GetScheduleEventsHighLight ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.12.2017 07:12:10",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("DashboardController.GetNotifications ... ") },
                new Message { TimeStamp = DateTime.ParseExact("23.12.2017 07:12:10",CurrentFormat, null), Type = LogType.Trace, MessageBuilder = new StringBuilder().Append("DashboardController.GetNotifications ... ") },
                new Message { TimeStamp = DateTime.ParseExact("14.01.2018 07:12:11",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("OrganizationHandler.GetDepartments ... ") },
                new Message { TimeStamp = DateTime.ParseExact("15.01.2018 07:12:11",CurrentFormat, null), Type = LogType.Info, MessageBuilder = new StringBuilder().Append("AttendanceHandler.GetScheduleEventCurrentlyIn ... ") },
        };
        #endregion

        public static FilterObject FilterObject_NoFilter_Moq = new FilterObject() { Messages = Messages, };
        public static FilterObject FilterObject_ErrorsOnly_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Error }, };
        public static FilterObject FilterObject_InfoOnly_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Info }, };
        public static FilterObject FilterObject_TraceOnly_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Trace }, };
        public static FilterObject FilterObject_WarningOnly_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Warning }, };
        public static FilterObject FilterObject_Errors_Info_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Error, LogType.Info }, };
        public static FilterObject FilterObject_Errors_Info_Trace_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Error, LogType.Info, LogType.Trace }, };
        public static FilterObject FilterObject_Errors_Info_Warning_Moq = new FilterObject() { Messages = Messages, SelectedTypes = new List<LogType>() { LogType.Error, LogType.Info, LogType.Warning }, };
        public static FilterObject FilterObject_SelectedDates_Moq = new FilterObject() { Messages = Messages, SelectedTimeStamps = new List<DateTime>() { DateTime.ParseExact("23.11.2017 00:00:00", CurrentFormat, null), DateTime.ParseExact("15.01.2018 00:00:00", CurrentFormat, null) } };
        public static FilterObject FilterObject_SelectedRange_Moq = new FilterObject() { Messages = Messages, SelectedRange = new DateRange() { From = DateTime.ParseExact("23.11.2017 00:00:00", CurrentFormat, null), To = DateTime.ParseExact("28.11.2017 00:00:00", CurrentFormat, null) } };
        public static FilterObject FilterObject_MessageCriteria_Broker_Moq = new FilterObject() { Messages = Messages, MessageCriteria = "Broker" };
        public static FilterObject FilterObject_MessageCriteria_Exception_Moq = new FilterObject() { Messages = Messages, MessageCriteria = "Exception" };

        #endregion


    }
}