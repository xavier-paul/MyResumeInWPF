using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private const string TICKS = @"G:\temp\Projets .Net\MyResumeInWPF\MyResumeInWPF\Logos\puces\AQUA.png";

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

        public ObservableCollection<String> AllImagesLevel
        {
            get
            {
                ObservableCollection<String> v_result = new ObservableCollection<String>();
                for (int i = 0; i < Level; i++)
                    v_result.Add(TICKS);

                return v_result;
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
