using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCMon.Control
{
    class RPCServerInfo
    {
        private string m_Module;
        private string m_ModulePath;
        private string m_InterfaceId;
        private long m_InterfaceStructOffset;
        private int m_ProceduresCount;
        private List<string> m_Procedures;
        private string m_Service;
        private bool m_IsServiceRunning;

        public RPCServerInfo(string i_Module, string i_ModulePath, string i_InterfaceId, 
            long i_InterfaceStructOffset, int i_ProceduresCount, List<string> i_Procedures, string i_Service, bool 
            i_IsServiceRunning)
        {
            m_Module = i_Module;
            m_ModulePath = i_ModulePath;
            m_InterfaceId = i_InterfaceId;
            m_InterfaceStructOffset = i_InterfaceStructOffset;
            m_ProceduresCount = i_ProceduresCount;
            m_Procedures = i_Procedures;
            m_Service = i_Service;
            m_IsServiceRunning = i_IsServiceRunning;
        }

        public string Module
        {
            get
            {
                return m_Module;
            }

            set
            {
                m_Module = value;
            }
        }

        public string ModulePath
        {
            get
            {
                return m_ModulePath;
            }

            set
            {
                m_ModulePath = value;
            }
        }

        public string InterfaceId
        {
            get
            {
                return m_InterfaceId;
            }

            set
            {
                m_InterfaceId = value;
            }
        }

        public long InterfaceStructOffset
        {
            get
            {
                return m_InterfaceStructOffset;
            }

            set
            {
                m_InterfaceStructOffset = value;
            }
        }

        public int ProceduresCount
        {
            get
            {
                return m_ProceduresCount;
            }

            set
            {
                m_ProceduresCount = value;
            }
        }

        public List<string> Procedures
        {
            get
            {
                return m_Procedures;
            }

            set
            {
                m_Procedures = value;
            }
        }
        
        public string Service
        {
            get
            {
                return m_Service;
            }

            set
            {
                m_Service = value;
            }
        }

        public bool IsServiceRunning
        {
            get
            {
                return m_IsServiceRunning;
            }

            set
            {
                m_IsServiceRunning = value;
            }
        }
    }
}
