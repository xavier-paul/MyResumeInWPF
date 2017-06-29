namespace MyResume
{
    public partial class Resume
    {
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
                Description = "Chiffrage (Poker Sizing / T-Shirt sizing)",
                Level = 3
            });
        }
    }
}
