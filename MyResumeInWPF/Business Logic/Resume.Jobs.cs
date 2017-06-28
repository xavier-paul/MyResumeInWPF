﻿//  AIzaSyDjX1aA6DMHg_95iTBFLvXNdJ_X6vA6NGU 

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
                Name = "Ingénieur d’études Full Stack / Dev Lead",
                Description = "Rédaction de spécifications et de plans de tests(tests unitaires, tests automatisés sous TFS 2015)."
                            + Environment.NewLine + "Développement d’applications en.Net C# 4.6 (webform (Simulateur de compteur électrique, gestionnaire d’alarmes utilisant AJAX, etc…) et winform (Serveur de fichiers, client FTP, etc…)). Utilisation des MSQueues, de WCF, de LinQ etc…"
                            + Environment.NewLine + "Utilisation des design patterns de la Factory, du Singleton, et du Provider."
                            + Environment.NewLine + "Responsable de la maintenance évolutive du MCD des bases de données(SQL Server 2000 à 2014, Oracle 8 à 12c) de l’application maison(Saturne).",
                IconForElement = @"entreprises\Asais.gif",
                FirmName = "Asaïs",
                StartingDate = new DateTime(2007, 09, 01),
                EndingDate = new DateTime(2017, 09, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Ingénieur d’études",
                Description= "Ecriture de normes de développement C# et SQL."
                                + Environment.NewLine + "Conception(méthode AGILE avec UML 2.1, Merise(MCD / MPD)) et développement d’applications en.Net 2.0 et SQL Server 2005(winform et webform)."
                                + Environment.NewLine + "Développement d’un micro - framework C# basé sur les Application Block (Enterprise Library) de Microsoft.",
                IconForElement = @"entreprises\PFG.png",
                FirmName = "OGF Courtage",
                StartingDate = new DateTime(2007, 02, 01),
                EndingDate = new DateTime(2007, 06, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Ingénieur d’études",
                Description = "Réalisation d’applications (Web et clients lourds) en C# (Framework .net 1.x et 2.0, SQL Server et DB2)."
                                + Environment.NewLine + "Documentation sous PowerPoint pour transfert de compétences(300 slides)."
                                + Environment.NewLine + "Clients : Groupe PPR(Rush Collection, Shopoon, Printemps, Surcouf), Géodis, Auto - Distribution, Nestlé, Fromageries BEL, Comité Olympique…",
                IconForElement = @"entreprises\business-interactif.png",
                FirmName = "Business Interactif",
                StartingDate = new DateTime(2003, 11, 01),
                EndingDate = new DateTime(2007, 02, 01)
            });


            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Stage de fin d’études",
                Description = "Réalisation d’applications web en C# et VB.Net(.Net 1.1 et SQL Server 2000)."
                            + Environment.NewLine + "Participation active (Maquettage C#) aux avant - ventes chez le client.",
                IconForElement = @"entreprises\sqli.png",
                FirmName = "SQLi",
                StartingDate = new DateTime(2003, 04, 01),
                EndingDate = new DateTime(2003, 09, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Stage de fin d’études",
                Description = "Portage d’une application de surveillance de centrale électrique, en Web(JSP et servlet).",
                IconForElement = @"entreprises\Alstom.png",
                FirmName = "Alstom Power",
                StartingDate = new DateTime(2002, 04, 01),
                EndingDate = new DateTime(2002, 09, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Job d'été",
                Description = "Création d’une base de données sous Access 97(Méthode Merise) pour CAPRA Prévoyance(mutuelle privée de Schneider Electric)",
                IconForElement = @"entreprises\logo_se_green.jpg",
                FirmName = "Capra Prévoyance",
                StartingDate = new DateTime(2001, 07, 01),
                EndingDate = new DateTime(2001, 09, 01)
            });

            Jobs.Add(v_index++, new ProResumeElement
            {
                Name = "Job d'été",
                Description = "Création d’un logiciel au sein d’une équipe(VBA Excel 97, Reverse Engineering Software).",
                IconForElement = @"entreprises\Opel-Logo-Blitz.png",
                FirmName = "Opel France",
                StartingDate = new DateTime(1999, 07, 01),
                EndingDate = new DateTime(1999, 09, 01)
            });
        }
    }
}
