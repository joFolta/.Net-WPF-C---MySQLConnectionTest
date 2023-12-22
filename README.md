# MySQLConnectionTest
#### .Net WPF app written with C#
![Preview](https://github.com/joFolta/.Net-WPF-C---MySQLConnectionTest/assets/40876495/953bd5e4-fb4a-4466-a720-30fc18785986)

A C# App to check that a MySQL connection is going through 

## Background on WPF
WPF (Windows Presentation Foundation) is an easy-to-work-with UI framework for building awesome Windows desktop applications <img src="https://github.com/joFolta/.Net-WPF-C---MySQLConnectionTest/assets/40876495/9c569098-1b29-4b57-b603-41e8f3dcbcaa" width="25">. Great for building Enterprise Level Applications (used by AutoDesk, Telerik). It was released in 2006.

WPF encourages separations of concenns with the MVVM (Model-View-ViewModel)
https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern

Great for multimedia applications (audio, video, animations - vector graphics that scale)
Machine learning (https://github.com/gerardo-lijs/MachineLearning-ObjectDetect-WPF)

WPF's Open source repo: https://github.com/dotnet/wpf

The extensive .Net package mananger NuGet was used to install the "MySql.Data" package by Oracle. 

Alternatives to WPF:
- Win Forms .Net (easier to learn, but lacks modern features and customizations)
- .Net Maui (.Net Multi-platform App UI, but not as much community support yet)
- Blazor (not optimized for building desktop client applications)
- ReactiveUI (functional programming version of WPF)

### MessageBox: "Connecting to MySQL..."
![Screenshot (6)](https://github.com/joFolta/.Net-WPF-C---MySQLConnectionTest/assets/40876495/5e52a217-324d-4e22-9751-bc0f18344a03)

### MessageBox: "Connected to " + server + "/" + database + " as user (" + username + ")"
![Screenshot (7)](https://github.com/joFolta/.Net-WPF-C---MySQLConnectionTest/assets/40876495/ee51c48c-a524-472d-a36d-b71677fc588c)

### Mutate login_button's Content to "Close Connection"
![Screenshot (8)](https://github.com/joFolta/.Net-WPF-C---MySQLConnectionTest/assets/40876495/23c32130-f621-4d90-84d0-81883819eac9)

## Resources
"Is LEARNING WPF still WORTH it in 2023?" https://youtu.be/6BsyG9HII84?si=Qo9SlVVxIlb5LAMy 
