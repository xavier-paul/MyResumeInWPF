using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        private readonly string TICKS_LANGUAGE = Path.Combine(AppLocationFinder.Current, @"Logos\puces\AQUA.png");
        private readonly string TICKS_TOOLS = Path.Combine(AppLocationFinder.Current, @"Logos\puces\GREEN.png");
        private readonly string TICKS_METHODS = Path.Combine(AppLocationFinder.Current, @"Logos\puces\YELLOW.png");

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

        private string TICKS
        {
            get
            {
                if (Group == Category.Langage)
                    return TICKS_LANGUAGE;
                else if (Group == Category.Méthode)
                    return TICKS_METHODS;
                else
                    return TICKS_TOOLS;
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
