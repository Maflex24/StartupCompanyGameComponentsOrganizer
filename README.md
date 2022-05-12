# Startup Company Game Component Organizer

## What and why?
I think everybody who played the game [Startup Company](https://store.steampowered.com/app/606800/Startup_Company/) had problem of understand flow of components/modules to update some feature, me too! Before you can hire a manager and make it little easier, it can be a real nightmare. This is why this simple console app is for.

## How to use?
When you run app you will have a list of features, which can be add to your game webpage. It's sorted like in a game. When you choose correct number of feature you will get a list with informations of component creating flow. 

![workflow console](https://github.com/Maflex24/StartupCompanyGameComponentsOrganizer/blob/master/ReadmeFiles/workflow.png)

Like you see you will get information about every needed component, from most basic components, like "backend component" and "network component" to create "backend module". You also have information how long it will be (it's standard time, if your employee is faster it will be faster), and which type of employee (and skill level) is required.
I know it's only simple console app, I did what I can do right now, but I still hope it will help you!



## Technical things
### Why Component class has two constructors?
After filled up some data to Program class (before refactoring) I had a mess, and much work with repeatable syntax. I was looking for better solution, this is why I created second constructor which get not `Timespan`, but just `int` of hours, and it's not in every `components.Add()` method syntax like this: 
```cs
components.Add(new Component("UI Set", new TimeSpan(18, 0, 0), new Dictionary<Component, int>() { { components.SingleOrDefault(c => c.Name == "Wireframe Component"), 2 }, { components.SingleOrDefault(c => c.Name == "UI Element"), 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate));
```
I chanded it to:
```cs
components.Add(new Component("UI Set", 8, new Dictionary<Component, int>() { {"Wireframe Component", 2 }, {"UI Element", 2 } }, ProfessionsEnum.Designer, EmployeeLevelEnum.Intermediate, _components));
```
Maybe still long, but much easier for me to handle. 
So after creating new solution to add new components I didn't wanted to edit whis what I already had filled up. That's all.

### What problems I see?
- Fixed objects in application. I need to edit `ComponentsList` or `FeaturesList` to add something. Maybe at some free time I will try to change this, to keep it in .json file for example. It will need serialization, I don't want to write every position once again :)
- Searching requiered components by them names. It's easy to make a typo and exception will happen. This is why I used every component and feature object method `Produce()` after almost every changed. If something bad happened I can find a reason. 

### Why only one branch?
It's simple app. It's not too much to screw up, so I just focused to code. 

If you have any questions, or suggestions - write to me, I'll be glad!
