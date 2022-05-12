using System.Runtime.CompilerServices;
using StartupCompanyGameComponentsOrganizer;

ComponentsList componentsList = new ComponentsList();
List<Component> components = componentsList.GetListWithData();

FeaturesList featuresList = new FeaturesList(components);
List<Feature> features = featuresList.GetListWithData();

AppHandler appHandler = AppHandler.CreateAppHandler(features, components);
appHandler.App();




