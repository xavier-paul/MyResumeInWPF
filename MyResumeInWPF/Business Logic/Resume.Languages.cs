//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Linq;

namespace MyResume
{
    public partial class Resume
    {
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
    }
}
