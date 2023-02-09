using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsRPC;

namespace RPCMon.Control
{
    class EventWrapper
    {
        private RpcClientCallStartArgs_V1TraceData m_ClientCallEvent;
        private RpcServerCallStartArgs_V1TraceData m_ServerCallEvent;

        private int m_ProcessID;
        private string m_ThreadID;
        private string m_InterfaceUuid;
        private string m_NetworkAddress;
        private string m_Protocol;
        private string m_Endpoint;
        private string m_TimeStamp;
        private string m_Options;
        private string m_AuthenticationLevel;
        private string m_AuthenticationService;
        private string m_ImpersonationLevel;
        private string m_ProcessName;
        private int m_ProcNum;
        private string m_TaskName;


        public EventWrapper(RpcClientCallStartArgs_V1TraceData ClientCallEvent)
        {
            this.m_ClientCallEvent = ClientCallEvent;
            this.m_ServerCallEvent = null;
            this.m_ProcessID = ClientCallEvent.ProcessID;
            this.m_ThreadID = ClientCallEvent.ThreadID.ToString();
            this.m_InterfaceUuid = ClientCallEvent.InterfaceUuid.ToString();
            this.m_NetworkAddress = ClientCallEvent.NetworkAddress.ToString();
            this.m_Protocol =  ClientCallEvent.Protocol.ToString();
            this.m_Endpoint = ClientCallEvent.Endpoint.ToString();
            this.m_TimeStamp = ClientCallEvent.TimeStamp.ToString("dd/MMM/yyyy hh:mm:ss.fff tt");
            this.m_Options = ClientCallEvent.Options.ToString();
            this.m_AuthenticationLevel = ClientCallEvent.AuthenticationLevel.ToString();
            this.m_AuthenticationService = ClientCallEvent.AuthenticationService.ToString();
            this.m_ImpersonationLevel = ((ImpersonationLevels)ClientCallEvent.ImpersonationLevel).ToString();
            this.m_ProcessName = ClientCallEvent.ProcessName;
            this.m_ProcNum = ClientCallEvent.ProcNum;
            this.m_TaskName = ClientCallEvent.TaskName.ToString() + ClientCallEvent.OpcodeName;

        }
        public EventWrapper(RpcServerCallStartArgs_V1TraceData ServerCallEvent)
        {
            this.m_ServerCallEvent = ServerCallEvent;
            this.m_ServerCallEvent = null;
            this.m_ProcessID = ServerCallEvent.ProcessID;
            this.m_ThreadID = ServerCallEvent.ThreadID.ToString();
            this.m_InterfaceUuid = ServerCallEvent.InterfaceUuid.ToString();
            this.m_NetworkAddress = ServerCallEvent.NetworkAddress.ToString();
            this.m_Protocol = ((ProtocolSequences)ServerCallEvent.Protocol).ToString();
            this.m_Endpoint = ServerCallEvent.Endpoint.ToString();
            this.m_TimeStamp = ServerCallEvent.TimeStamp.ToString("dd/MMM/yyyy hh:mm:ss.fff tt");
            this.m_Options = ServerCallEvent.Options.ToString();
            this.m_AuthenticationLevel = ServerCallEvent.AuthenticationLevel.ToString();
            this.m_AuthenticationService = ServerCallEvent.AuthenticationService.ToString();
            this.m_ImpersonationLevel = ServerCallEvent.ImpersonationLevel.ToString();
            this.m_ProcessName = ServerCallEvent.ProcessName;
            this.m_ProcNum = ServerCallEvent.ProcNum;
            this.m_TaskName = ServerCallEvent.TaskName.ToString() + ServerCallEvent.OpcodeName;
        }

        public EventWrapper(RpcClientCallStop7Args_V1TraceData ClinetCallEvent)
        {
            this.m_ProcessID = ClinetCallEvent.ProcessID;
            this.m_ThreadID = ClinetCallEvent.ThreadID.ToString();
            this.m_ProcessID = ClinetCallEvent.ProcessID;

            this.m_InterfaceUuid = "";
            this.m_NetworkAddress = "";
            this.m_Protocol = "";
            this.m_Endpoint = "";
            this.m_TimeStamp = ClinetCallEvent.TimeStamp.ToString("dd/MMM/yyyy hh:mm:ss.fff tt");
            this.m_Options = "";
            this.m_AuthenticationLevel = "";
            this.m_AuthenticationService = "";
            this.m_ImpersonationLevel = "";
            this.m_ProcessName = ClinetCallEvent.ProcessName;
            this.m_ProcNum = -1;

            this.m_TaskName = ClinetCallEvent.TaskName.ToString() + ClinetCallEvent.OpcodeName;
        }
        
        public int ProcessID { get => m_ProcessID;}
        public string ThreadID { get => m_ThreadID;}
        public string InterfaceUuid { get => m_InterfaceUuid;}
        public string NetworkAddress { get => m_NetworkAddress; }
        public string Protocol { get => m_Protocol; }
        public string Endpoint { get => m_Endpoint; }
        public string TimeStamp { get => m_TimeStamp; }
        public string Options { get => m_Options; }
        public string AuthenticationLevel { get => m_AuthenticationLevel; }
        public string AuthenticationService { get => m_AuthenticationService; }
        public string ImpersonationLevel { get => m_ImpersonationLevel; }
        public int ProcNum { get => m_ProcNum; }
        public string ProcessName { get => m_ProcessName; }
        public string TaskName { get => m_TaskName; }
    }
}
