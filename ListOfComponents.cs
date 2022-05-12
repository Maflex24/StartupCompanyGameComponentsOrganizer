using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class ListOfComponents
    {
        List<Component> components = new List<Component>()
        {
            new Component("UI Component", new TimeSpan(2, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner),
            new Component("Backend Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner),
            new Component("Network Component", new TimeSpan(6, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner),
            new Component("Database Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner),
            new Component("Video Component", new TimeSpan(14, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner),
            new Component("Semantic Component", new TimeSpan(3, 0, 0), null, ProfessionsEnum.Developer,
            EmployeeLevelEnum.Intermediate),
            new Component("Encryption Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer,
            EmployeeLevelEnum.Intermediate),
            new Component("Filesystem Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer,
            EmployeeLevelEnum.Intermediate),
            new Component("Smtp Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Intermediate),
            new Component("I18n Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Expert),
            new Component("Search Algorithm Component", new TimeSpan(12, 0, 0), null, ProfessionsEnum.Developer,
            EmployeeLevelEnum.Expert),
            new Component("Compression Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer,
            EmployeeLevelEnum.Expert),
            new Component("Blueprint Component", new TimeSpan(2, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner),
            new Component("Wireframe Component", new TimeSpan(3, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner),
            new Component("Graphics Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner),
            new Component("Documentation Component", new TimeSpan(12, 0, 0), null, ProfessionsEnum.Designer,
                EmployeeLevelEnum.Expert),
        };

        public List<Component> GetListWithData()
        {
            List<Component> components = this.components;

            components.Add(new Component("UI Element", new TimeSpan(6, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Blueprint Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Graphics Component"), 1 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner));
            components.Add(new Component("UI Set", new TimeSpan(18, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Wireframe Component"), 2 }, { components.SingleOrDefault(c => c.Name == "UI Element"), 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate));
            components.Add(new Component("Responsive UI", new TimeSpan(18, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Wireframe Component"), 2 }, { components.SingleOrDefault(c => c.Name == "UI Element"), 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate));
            components.Add(new Component("Design Guidelines", new TimeSpan(90, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Documentation Component"), 3 }, { components.SingleOrDefault(c => c.Name == "Responsive UI"), 3 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Expert));


            components.Add(new Component("Interface Module", new TimeSpan(15, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "UI Element"), 2 }, { components.SingleOrDefault(c => c.Name == "Wireframe Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));
            components.Add(new Component("Frontend Module", new TimeSpan(21, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "UI Element"), 1 }, { components.SingleOrDefault(c => c.Name == "Interface Module"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Backend Module", new TimeSpan(10, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Backend Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Network Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Input Module", new TimeSpan(6, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "UI Element"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Storage Module", new TimeSpan(8, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Filesystem Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Content Managment Module", new TimeSpan(37, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Frontend Module"), 1 }, { components.SingleOrDefault(c => c.Name == "Input Module"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Module"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Video Playback Module", new TimeSpan(45, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Video Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Frontend Module"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Module"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Beginner));

            components.Add(new Component("Seo Module", new TimeSpan(24, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Frontend Module"), 1 }, { components.SingleOrDefault(c => c.Name == "Semantic Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Intermediate));

            components.Add(new Component("Authentication Module", new TimeSpan(22, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Database Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Encryption Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Module"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Intermediate));

            components.Add(new Component("Email Module", new TimeSpan(12, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Smtp Component"), 1 }, { components.SingleOrDefault(c => c.Name == "Backend Component"), 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Intermediate));

            components.Add(new Component("Database Layer", 14, new Dictionary<string, int>() { { "Database Component", 1 }, { "Backend Component", 1 }, { "Network Component", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Intermediate, components));

            components.Add(new Component("Notification Module", 18, new Dictionary<string, int>() { { "UI Component", 1 }, { "Backend Component", 1 }, { "Email Module", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Intermediate, components));

            components.Add(new Component("API Client Module", 40, new Dictionary<string, int>() { { "Backend Module", 1 }, { "Database Layer", 1 }, { "Compression Component", 2 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            components.Add(new Component("Payment Gateway Module", 76, new Dictionary<string, int>() { { "API Client Module", 1 }, { "Database Layer", 1 }, { "Authentication Module", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            components.Add(new Component("Localization Module", 25, new Dictionary<string, int>() { { "I18n Component", 1 }, { "Frontend Module", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            components.Add(new Component("Search Module", 20, new Dictionary<string, int>() { { "Database Component", 1 }, { "Search Algorithm Component", 1 }, { "Backend Component", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            components.Add(new Component("Bandwidth Compression Module", 18, new Dictionary<string, int>() { { "Compression Component", 1 }, { "Network Component", 1 }, { "Backend Component", 1 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            components.Add(new Component("Code Optimization Module", 90, new Dictionary<string, int>() { { "Backend Module", 2 }, { "Database Layer", 2 }, { "Frontend Module", 2 } }, ProfessionsEnum.LeadDeveloper, EmployeeLevelEnum.Expert, components));

            return components;
        }
    }
}
