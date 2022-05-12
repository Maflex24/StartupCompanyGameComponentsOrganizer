using System.Runtime.CompilerServices;
using StartupCompanyGameComponentsOrganizer;

ListOfComponents listOfComponents = new ListOfComponents();
List<Component> components = listOfComponents.GetListWithData();

ListOfFeatures listOfFeatures = new ListOfFeatures(components);
List<Feature> features = listOfFeatures.GetListWithData();

AppHandler appHandler = AppHandler.CreateAppHandler(features, components);
appHandler.App();


