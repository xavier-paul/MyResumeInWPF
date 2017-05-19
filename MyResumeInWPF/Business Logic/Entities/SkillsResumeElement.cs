using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public class SkillsResumeElement : SimpleResumeElement
    {
        private byte m_level;
        public enum Category {Langage, Outil, Méthode};

        private Category m_group;

        public byte Level
        {
            get
            {
                return m_level;
            }

            set
            {
                this.m_level = value;
            }
        }

        public Category Group
        {
            get
            {
                return m_group;
            }

            set
            {
                this.m_group = value;
            }
        }
    }
}
