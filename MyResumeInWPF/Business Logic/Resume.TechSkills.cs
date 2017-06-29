namespace MyResume
{
    public partial class Resume
    {
        private void InitTechSkills()
        {
            int v_index = 1;
            SkillsResumeElement.Category v_currentCat = SkillsResumeElement.Category.Langages;
            #region Languages
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "C#",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "WPF",
                Level = 2,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Azure (Cloud)",
                Level = 1,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "T-SQL (SQL Server 2000 à 2016)",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "PL-SQL (Oracle 8 à 12c)",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Java",
                Level = 2,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "C / C++",
                Level = 2,
                Group = v_currentCat
            });
            #endregion

            #region Methods
            v_currentCat = SkillsResumeElement.Category.Méthodes;
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Merise",
                Level = 4,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "UML",
                Level = 3,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Agile / SCRUM",
                Level = 2,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "TDD (Test-Driven Development)",
                Level = 2,
                Group = v_currentCat
            });
            #endregion

            #region Tools
            v_currentCat = SkillsResumeElement.Category.Outils;
            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Visual Studio 2017",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "TFS",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "VSS",
                Level = 5,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Power AMC 15",
                Level = 4,
                Group = v_currentCat
            });

            Skills.Add(v_index++, new SkillsResumeElement
            {
                Description = "Android Studio",
                Level = 2,
                Group = v_currentCat
            });
            #endregion
        }
    }
}
