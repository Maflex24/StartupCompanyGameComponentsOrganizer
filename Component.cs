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

        public async Task Produce()
        {
            if (RequiredComponents == null)
            {
                ProductionInfo.Info(this);
                return;
            }

            foreach (var requiredComponent in RequiredComponents)
            {
                for (int i = 0; i < requiredComponent.Value; i++)
                {
                    await requiredComponent.Key.Produce();
                }
            }

            ProductionInfo.Info(this);
        }
    }
}
