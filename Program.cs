using System.Runtime.CompilerServices;
using StartupCompanyGameComponentsOrganizer;

ListOfComponents listOfComponents = new ListOfComponents();
List<Component> components = listOfComponents.GetListWithFills();

ListOfFeatures listOfFeatures = new ListOfFeatures(components);
List<Feature> features = listOfFeatures.GetListWithFills();


while (true)
{
    Console.WriteLine();
    for (int i = 0; i < features.Count; i++)
    {
        Console.WriteLine($"{i.ToString().PadRight(3)} {features[i].Name.PadRight(28)}");
    }

    Console.Write("Type the number of feature to show path: ");
    var userChoice = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Producing flow for [{features[userChoice].Name}]");

    features[userChoice].Produce();
    Console.Write("Press some key to continue...");
    Console.ReadLine();
}

