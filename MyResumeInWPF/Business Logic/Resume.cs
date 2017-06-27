//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

namespace MyResume
{
    public class Resume
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
            get
            {
                return m_managerSkills;
            }

            set
            {
                this.m_managerSkills = value;
            }
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
            if (CheckVoiceAvailability(v_speechSynthesizer, v_voice)) // Si la voix est installée
                v_speechSynthesizer.SelectVoice(v_voice); // Alors on l'utilise
            else
                v_speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            PromptBuilder promptBuilder = new PromptBuilder();
            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Loud;
            promptStyle.Rate = PromptRate.Slow;
            promptBuilder.StartStyle(promptStyle);

            promptBuilder.AppendText("Chargement du CV en cours !", PromptEmphasis.Strong);
            promptBuilder.EndStyle();

            v_speechSynthesizer.SpeakAsync(promptBuilder);
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

        private void InitManagerSkills()
        {
            int v_index = 1;
            ManagerSkills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Pédagogie explicative",
                Level = 3
            });

            ManagerSkills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Résolution de problématique",
                Level = 4
            });
            ManagerSkills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Chiffrage",
                Level = 3
            });
        }

        private void InitLanguages()
        {
            int v_index = 1;
            Languages.Add(v_index++, new SimpleResumeElement
            {
                Description = "Français : langue maternelle"
            });

            Languages.Add(v_index++, new SimpleResumeElement
            {
                Description = "Anglais : courant"
            });

            Languages.Add(v_index++, new SimpleResumeElement
            {
                Description = "Japonais : Débutant (JLPT N5 obtenu en 2014) : lu, écrit, parlé"
            });
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

        private void InitPro()
        {
            int v_index = 1;
            Jobs.Add(v_index++, new ProResumeElement
            {
                Description = "Developpeur",
                IconForElement = @"entreprises\Asais.gif",
                FirmName = "Asaïs",
                StartingDate = new DateTime(2007, 09, 01),
                EndingDate = new DateTime(2017, 09, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Description = "Developpeur",
                IconForElement = @"entreprises\PFG.png",
                FirmName = "OGF Courtage",
                StartingDate = new DateTime(2007, 02, 01),
                EndingDate = new DateTime(2007, 06, 01)
            });
        }

        private void InitHobbies()
        {
            int i = 1;
            AddHobby(i++, "Natation");
            AddHobby(i++, "Running");
            AddHobby(i++, "Piano");
            AddHobby(i++, "Langues étrangères");
            AddHobby(i++, "Voyages (Nigéria (1 an), Bahreïn (1 an), Japon (6 fois), Etats-Unis...)");
        }

        private void AddHobby(int p_index, string p_hobby)
        {
            Hobbies.Add(p_index, new SimpleResumeElement
            {
                Description = p_hobby
            });
        }

        private void InitLearning()
        {
            int v_index = 1;
            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "Techniques avancées en C#",
                Year = 2016,
                Firm = "(Interne)"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "Introduction au Cloud Azure",
                Year = 2016,
                Firm = "(Interne)"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "Optimisation Oracle",
                Year = 2015,
                Firm = "ORSYS"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "SCRUM",
                Year = 2015,
                Firm = "Cegos"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "C# 5.0 / VS 2012",
                Year = 2014,
                Firm = "ORSYS"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "Test Driven Development en .NET",
                Year = 2014,
                Firm = "ORSYS"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "Optimisation SQL Server",
                Year = 2013,
                Firm = "Learning Tree"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Description = "ASP.NET",
                Year = 2013,
                Firm = "Learning Tree"
            });

        }

        private void InitTechSkills()
        {
            int v_index = 1;
            #region Languages
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "C#",
                Level = 5,
                Group = SkillsResumeElement.Category.Langage
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Azure (Cloud)",
                Level = 1,
                Group = SkillsResumeElement.Category.Langage
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "T-SQL (SQL Server)",
                Level = 5,
                Group = SkillsResumeElement.Category.Langage
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "PL-SQL (Oracle)",
                Level = 5,
                Group = SkillsResumeElement.Category.Langage
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Java",
                Level = 2,
                Group = SkillsResumeElement.Category.Langage
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "C / C++",
                Level = 2,
                Group = SkillsResumeElement.Category.Langage
            });
            #endregion

            #region Methods
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Merise",
                Level = 4,
                Group = SkillsResumeElement.Category.Méthode
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "UML",
                Level = 3,
                Group = SkillsResumeElement.Category.Méthode
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Agile / SCRUM",
                Level = 2,
                Group = SkillsResumeElement.Category.Méthode
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "TDD",
                Level = 2,
                Group = SkillsResumeElement.Category.Méthode
            });
            #endregion

            #region Tools
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Visual Studio 2015",
                Level = 5,
                Group = SkillsResumeElement.Category.Outil
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "TFS",
                Level = 5,
                Group = SkillsResumeElement.Category.Outil
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "VSS",
                Level = 5,
                Group = SkillsResumeElement.Category.Outil
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Power AMC 15",
                Level = 4,
                Group = SkillsResumeElement.Category.Outil
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Android Studio",
                Level = 2,
                Group = SkillsResumeElement.Category.Outil
            });
            #endregion
        }
    }
}
