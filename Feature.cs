using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class Feature
    {
        public string Name { get; set; }
        public Dictionary<Component, int>? RequiredComponents;

        public Feature(string name, Dictionary<string, int> requiredComponents, List<Component> components)
        {
            Name = name;
            RequiredComponents = new Dictionary<Component, int>();

            foreach (var requiredComponent in requiredComponents)
            {
                string componentName = requiredComponent.Key;
                int requierComponentQty = requiredComponent.Value;
                Component requireComponent = components.SingleOrDefault(c => c.Name == componentName);

                RequiredComponents.Add(requireComponent, requierComponentQty);
            }
        }

        public void Produce()
        {
            foreach (var requiredComponent in RequiredComponents)
            {
                for (int i = 0; i < requiredComponent.Value; i++)
                {
                    requiredComponent.Key.Produce();
                    Console.WriteLine(new string('-', 80));
                }
            }
        }
    }
}
