//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Linq;

namespace MyResume
{
    public partial class Resume
    {
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

    }
}
