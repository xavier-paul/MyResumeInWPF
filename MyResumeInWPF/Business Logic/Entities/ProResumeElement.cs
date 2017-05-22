using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public class ProResumeElement : SimpleResumeElement
    {
        private DateTime m_startingDate;
        private DateTime m_endingDate;
        private TimeSpan m_jobLength;
        private string m_firmName;

        public DateTime StartingDate
        {
            get
            {
                return m_startingDate;
            }

            set
            {
                this.m_startingDate = value;
            }
        }

        public DateTime EndingDate
        {
            get
            {
                return m_endingDate;
            }

            set
            {
                this.m_endingDate = value;
            }
        }

        public TimeSpan JobLength
        {
            get
            {
                return EndingDate - StartingDate;
            }
        }

        public string FirmName
        {
            get
            {
                return m_firmName;
            }

            set
            {
                this.m_firmName = value;
            }
        }
    }
}
