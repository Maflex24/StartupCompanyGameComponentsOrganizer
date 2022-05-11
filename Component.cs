using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class Component
    {
        public string Name { get; set; }
        public TimeSpan CreatingTime { get; set; }
        public Dictionary<Component, int>? RequiredComponents;

        public ProfessionsEnum Profession { get; set; }
        public EmployeeLevelEnum EmployeeLevel { get; set; }

        public Component(string name, TimeSpan creatingTime, Dictionary<Component, int> requiredComponents, ProfessionsEnum professionEnum, EmployeeLevelEnum employeeLevelEnum)
        {
            Name = name;
            CreatingTime = creatingTime;
            RequiredComponents = requiredComponents;
            Profession = professionEnum;
            EmployeeLevel = employeeLevelEnum;
        }

        public Component(string name, int hours, Dictionary<string, int> requiredComponents, ProfessionsEnum professionEnum, EmployeeLevelEnum employeeLevelEnum, List<Component> components)
        {
            Name = name;
            CreatingTime = new TimeSpan(hours, 0, 0);
            Profession = professionEnum;
            EmployeeLevel = employeeLevelEnum;

            if (requiredComponents != null)
            {
                RequiredComponents = new Dictionary<Component, int>();

                foreach (var requiredComponent in requiredComponents)
                {
                    string componentName = requiredComponent.Key;
                    int requierComponentQty = requiredComponent.Value;
                    Component requireComponent = components.SingleOrDefault(c => c.Name == componentName);

                    RequiredComponents.Add(requireComponent, requierComponentQty);
                }
            }
        }

        public async Task Produce()
        {
            if (RequiredComponents == null)
            {
                PrintInfo();
                return;
            }

            foreach (var requiredComponent in RequiredComponents)
            {
                for (int i = 0; i < requiredComponent.Value; i++)
                {
                    await requiredComponent.Key.Produce();
                }
            }

            PrintInfo();
        }

        private void PrintInfo()
        {
            string timeInfo = $"{CreatingTime.Hours.ToString().PadRight(2)} hours";

            string spaces = "";
            if (RequiredComponents != null)
                spaces = new string('-', RequiredComponents.Count);

            string info =
                $"{(spaces + Name).PadRight(30)} will be produced in {timeInfo} by [{EmployeeLevel} {Profession}]";
            Console.WriteLine(info);
        }
    }
}
