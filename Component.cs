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

            if (requiredComponents == null) return;

            RequiredComponents = new Dictionary<Component, int>();

            foreach (var requiredComponent in requiredComponents)
            {
                var componentName = requiredComponent.Key;
                var componentQty = requiredComponent.Value;
                var component = components.SingleOrDefault(c => c.Name == componentName);

                RequiredComponents.Add(component, componentQty);
            }
        }

        public void Produce()
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
                    requiredComponent.Key.Produce();
                }
            }

            PrintInfo();
        }

        private void PrintInfo()
        {
            string timeInfo = $"{CreatingTime.Hours.ToString(),-2} hours";

            string spaces = "";
            if (RequiredComponents != null)
                spaces = new string(' ', RequiredComponents.Count);

            string info = $"{(spaces + Name).PadRight(30)} will be produced in {timeInfo} by [{EmployeeLevel} {Profession}]";
            Console.WriteLine(info);
        }
    }
}
