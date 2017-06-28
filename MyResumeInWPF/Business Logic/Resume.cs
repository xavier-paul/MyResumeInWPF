//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Linq;

namespace MyResume
{
    public partial class Resume
    {
        private SortedList<int, SimpleResumeElement> m_civil = new SortedList<int, SimpleResumeElement>();
        private SortedList<int, ProResumeElement> m_jobs = new SortedList<int, ProResumeElement>();
        private SortedList<int, SkillsResumeElement> m_skills = new SortedList<int, SkillsResumeElement>();
        private SortedList<int, LearningResumeElement> m_learning = new SortedList<int, LearningResumeElement>();
        private SortedList<int, SimpleResumeElement> m_hobbies = new SortedList<int, SimpleResumeElement>();
        private SortedList<int, SimpleResumeElement> m_languages = new SortedList<int, SimpleResumeElement>();
        private SortedList<int, SkillsResumeElement> m_managerSkills = new SortedList<int, SkillsResumeElement>();

        public SortedList<int, SimpleResumeElement> Civil
        {
            get
            {
                return m_civil;
            }

            private set
            {
                this.m_civil = value;
            }
        }

        public SortedList<int, ProResumeElement> Jobs
        {
            get
            {
                return m_jobs;
            }

            private set
            {
                this.m_jobs = value;
            }
        }

        public SortedList<int, SkillsResumeElement> Skills
        {
            get
            {
                return m_skills;
            }

            private set
            {
                this.m_skills = value;
            }
        }

        public SortedList<int, SimpleResumeElement> Hobbies
        {
            get
            {
                return m_hobbies;
            }

            private set
            {
                this.m_hobbies = value;
            }
        }

        public SortedList<int, LearningResumeElement> Learning
        {
            get
            {
                return m_learning;
            }

            private set
            {
                this.m_learning = value;
            }
        }

        public SortedList<int, SimpleResumeElement> Languages
        {
            get
            {
                return m_languages;
            }

            private set
            {
                this.m_languages = value;
            }
        }

        public SortedList<int, SkillsResumeElement> ManagerSkills
        {
            get => m_managerSkills;
            set => this.m_managerSkills = value;
        }

        public Resume()
        {
            Speak();
            Init();
        }

        public bool CheckVoiceAvailability(SpeechSynthesizer p_speaker, string p_voice)
        {
            foreach (InstalledVoice v_allVoices in p_speaker.GetInstalledVoices()) // Je liste les voix installées
            {
                if (v_allVoices.VoiceInfo.Name == p_voice)
                    return true;
            }
            return false;
        }

        private void Speak()
        {
            //https://openclassrooms.com/courses/faites-parler-vos-applications-en-net
            SpeechSynthesizer v_speechSynthesizer = new SpeechSynthesizer();

            string v_voice = "ScanSoft Virginie_Dri40_16kHz";
            if (CheckVoiceAvailability(v_speechSynthesizer, v_voice)) // Si la voix "Virginie" est installée,
                v_speechSynthesizer.SelectVoice(v_voice); // alors on l'utilise.
            else
                v_speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); //sinon on prends la voix par défaut.

            PromptBuilder v_promptBuilder = new PromptBuilder();
            PromptStyle v_promptStyle = new PromptStyle();
            v_promptStyle.Volume = PromptVolume.Loud;
            v_promptStyle.Rate = PromptRate.Slow;
            v_promptBuilder.StartStyle(v_promptStyle);

            v_promptBuilder.AppendText("Chargement du CV en cours !", PromptEmphasis.Strong);
            v_promptBuilder.EndStyle();

            v_speechSynthesizer.SpeakAsync(v_promptBuilder);
        }

        private void Init()
        {
            InitCivil();
            InitPro();
            InitHobbies();
            InitLearning();
            InitTechSkills();
            InitLanguages();
            InitManagerSkills();
        }
        
       

        private void InitCivil()
        {
            int v_index = 1;
            Civil.Add(v_index++, new SimpleResumeElement
            {
                Description = "H1 rue des marronniers" + Environment.NewLine + "77177 Brou sur Chantereine",
                IconForElement = "Mail.png"
            });

            Civil.Add(v_index++, new SimpleResumeElement
            {
                Description = "+33614492004",
                IconForElement = "GSM.png"
            });

            Civil.Add(v_index++, new SimpleResumeElement
            {
                Description = "xavpaul@hotmail.com",
                IconForElement = "Chat.png"
            });
        }
                  
    }
}
