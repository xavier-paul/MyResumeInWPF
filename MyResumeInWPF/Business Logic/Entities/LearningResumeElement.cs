using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public sealed class LearningResumeElement : SimpleResumeElement
    {
        private string m_firm;
        private ushort m_year;

        public string Firm
        {
            get
            {
                return m_firm;
            }

            set
            {
                this.m_firm = value;
            }
        }

        public ushort Year
        {
            get
            {
                return m_year;
            }

            set
            {
                this.m_year = value;
            }
        }
    }
}
