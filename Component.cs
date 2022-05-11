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
        public ProfessionsEnum ProfessionEnum { get; }
        public EmployeeLevelEnum EmployeeLevelEnum { get; }
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
            ProfessionEnum = professionEnum;
            EmployeeLevelEnum = employeeLevelEnum;

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
                PrintInfo(this);
                return;
            }

            foreach (var requiredComponent in RequiredComponents)
            {
                for (int i = 0; i < requiredComponent.Value; i++)
                {
                    await requiredComponent.Key.Produce();
                }
            }

            PrintInfo(this);
        }

        private void PrintInfo(Component component)
        {
            string timeInfo = $"{component.CreatingTime.Hours.ToString().PadRight(2)} hours";

            string info =
                $" {component.Name.PadRight(30)} will be produced in {timeInfo} by [{component.EmployeeLevel} {component.Profession}]";
            Console.WriteLine(info);
        }
    }
}
