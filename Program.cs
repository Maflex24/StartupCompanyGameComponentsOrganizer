using StartupCompanyGameComponentsOrganizer;


List<Component> RawComponents = new List<Component>();

new Component("UI Component", new TimeSpan(2, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner);
new Component("Backend Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner);
new Component("Network Component", new TimeSpan(6, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner);
new Component("Database Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner);
new Component("Video Component", new TimeSpan(14, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Beginner);
new Component("Semantic Component", new TimeSpan(3, 0, 0), null, ProfessionsEnum.Developer,
    EmployeeLevelEnum.Intermediate);
new Component("Encryption Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer,
    EmployeeLevelEnum.Intermediate);
new Component("Filesystem Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer,
    EmployeeLevelEnum.Intermediate);
new Component("Smtp Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Intermediate);
new Component("I18n Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Developer, EmployeeLevelEnum.Expert);
new Component("Search Alghorithm Component", new TimeSpan(12, 0, 0), null, ProfessionsEnum.Developer,
    EmployeeLevelEnum.Expert);
new Component("Compression Component", new TimeSpan(8, 0, 0), null, ProfessionsEnum.Developer,
    EmployeeLevelEnum.Expert);

var blueprintComponent = new Component("Blueprint Component", new TimeSpan(2, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner);
var wireFrameComponent = new Component("Wireframe Component", new TimeSpan(3, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner);
var graphicsComponent = new Component("Graphics Component", new TimeSpan(4, 0, 0), null, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner);
var documentationComponent = new Component("Documentation Component", new TimeSpan(12, 0, 0), null, ProfessionsEnum.Designer,
    EmployeeLevelEnum.Expert);

var UiElement = new Component("UI Element", new TimeSpan(12, 0, 0), new Dictionary<Component, int>() { { blueprintComponent, 1 }, { graphicsComponent, 1 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Beginner);
var UiSet = new Component("UI Set", new TimeSpan(18, 0, 0), new Dictionary<Component, int>() { { wireFrameComponent, 2 }, { UiElement, 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate);
var responsiveUI = new Component("Responsive UI", new TimeSpan(18, 0, 0), new Dictionary<Component, int>() { { wireFrameComponent, 2 }, { UiElement, 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate);
var designGuidelines = new Component("Design Guidelines", new TimeSpan(90, 0, 0), new Dictionary<Component, int>() { { documentationComponent, 3 }, { responsiveUI, 3 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Expert);

UiSet.Produce();