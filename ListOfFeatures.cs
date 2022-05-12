using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class ListOfFeatures
    {
        private readonly List<Component> _components;

        public ListOfFeatures(List<Component> components)
        {
            _components = components;
        }

        public List<Feature> GetListWithData()
        {
            List<Feature> features = new List<Feature>();

            features.Add(new Feature("Landing Page", new Dictionary<string, int>() { { "UI Component", 1 }, { "Backend Component", 1 }, { "Blueprint Component", 1 }, { "Graphics Component", 1 } }, _components));
            features.Add(new Feature("Live streaming", new Dictionary<string, int>() { { "Backend Module", 1 }, { "Frontend Module", 1 }, { "Network Component", 4 } }, _components));
            features.Add(new Feature("Sharing Functionality", new Dictionary<string, int>() { { "Backend Module", 2 }, { "Frontend Module", 1 }, { "Input Module", 1 }, { "Email Module", 2 }, { "UI Set", 1 } }, _components));
            features.Add(new Feature("Offline Content", new Dictionary<string, int>() { { "Backend Module", 2 }, { "Frontend Module", 1 }, { "Storage Module", 2 }, { "Database Layer", 2 }, { "UI Set", 1 } }, _components));
            features.Add(new Feature("Payment System", new Dictionary<string, int>() { { "Database Layer", 2 }, { "Frontend Module", 1 }, { "Payment Gateway Module", 1 }, { "Email Module", 1 }, { "Design Guidelines", 1 } }, _components));
            features.Add(new Feature("Chat System", new Dictionary<string, int>() { { "Database Layer", 1 }, { "Input Module", 1 }, { "Notification Module", 2 }, { "Network Component", 3 }, { "API Client Module", 2 }, { "Design Guidelines", 1 } }, _components));

            return features;
        }
    }
}
