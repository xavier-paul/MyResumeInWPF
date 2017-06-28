//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Linq;

namespace MyResume
{
    public partial class Resume
    {
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
    }
}
