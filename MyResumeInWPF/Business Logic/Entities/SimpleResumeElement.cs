﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public class SimpleResumeElement
    {
        private string m_description;
        private string m_iconForElement;

        public string Description
        {
            get
            {
                return m_description;
            }

            set
            {
                this.m_description = value;
            }
        }

        public string IconForElement
        {
            get
            {
                string v_normalPath = Path.Combine(Directory.GetCurrentDirectory(), @"\Logos\" + m_iconForElement);

                if (!File.Exists(v_normalPath))
                    return @"C:\Users\xpaul\Documents\Visual Studio 2015\Projects\MyResume\MyResume\Logos\" + m_iconForElement;
                else
                    return v_normalPath;
            }

            set
            {
                this.m_iconForElement = value;
            }
        }
    }
}
