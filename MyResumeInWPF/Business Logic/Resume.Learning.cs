namespace MyResume
{
    public partial class Resume
    {
        private void InitLearning()
        {
            int v_index = 1;

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Angular (npm, NodeJS, Gulp, etc...)",
                Year = 2017,
                Firm = "(Auto formation)"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "JQuery",
                Year = 2017,
                Firm = "(Auto formation)"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "WPF",
                Year = 2017,
                Firm = "(Auto formation)"
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Techniques avancées en C#",
                Description = "NuGet, Tests, Generics, TPL, Async/Await, Dependency Injection, LinQ, Extension Methods, JSON / REST, PowerShell, Transaction Scope…",
                Year = 2016,
                Firm = "(Interne)",
                DayLength = 12
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Introduction au Cloud Azure",
                Description = "Service Fabric, Document DB",
                Year = 2016,
                Firm = "(Interne)",
                DayLength = 2
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Oracle, optimisation d'applications",
                Year = 2015,
                Firm = "ORSYS",
                DayLength = 4
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "SCRUM",
                Description = "Utiliser efficacement la méthode SCRUM",
                Year = 2015,
                Firm = "Cegos",
                DayLength = 5
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "C# 5.0 / VS 2012",
                Description = "Mise en oeuvre des nouveautés",
                Year = 2014,
                Firm = "ORSYS",
                DayLength = 5
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Test Driven Development en .NET",
                Year = 2014,
                Firm = "ORSYS",
                DayLength = 3
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "Optimisation SQL Server",
                Description = "Développement de base de données SQL Server hautement performantes",
                Year = 2013,
                Firm = "Learning Tree",
                DayLength = 4
            });

            Learning.Add(v_index++, new LearningResumeElement
            {
                Name = "ASP.NET",
                Description = "Creation d’applications Web",
                Year = 2013,
                Firm = "Learning Tree",
                DayLength = 4
            });

        }
    }
}
