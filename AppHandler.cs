using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class AppHandler
    {
        private readonly List<Feature> _features;
        private readonly List<Component> _components;
        private static bool isCreated = false;

        private AppHandler(List<Feature> features, List<Component> components)
        {
            _features = features;
            _components = components;
        }

        public static AppHandler CreateAppHandler(List<Feature> features, List<Component> components)
        {
            if (!isCreated)
            {
                AppHandler appHandler = new AppHandler(features, components);
                isCreated = true;
                return appHandler;
            }

            return null;
        }

        public void App()
        {
            while (true)
            {
                Console.WriteLine();
                for (int i = 0; i < _features.Count; i++)
                {
                    Console.WriteLine($"{i.ToString().PadRight(3)} {_features[i].Name.PadRight(28)}");
                }

                Console.Write("Type the number of feature to show path: ");
                var userChoice = int.TryParse(Console.ReadLine(), out int userChoiceNumber);

                if (!userChoice || userChoiceNumber >= _features.Count || userChoiceNumber < 0)
                {
                    Console.WriteLine("\nYour choice is not valid! Choose correct number of feature");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine($"Producing flow for [{_features[userChoiceNumber].Name}]");
                Console.WriteLine(new string('-', 80));

                _features[userChoiceNumber].Produce();
                Console.Write("Press some key to continue, or type \"exit\" to turn off application.. ");

                var secondChoice = Console.ReadLine();
                if (secondChoice == "exit")
                    return;
            }
        }
    }
}
