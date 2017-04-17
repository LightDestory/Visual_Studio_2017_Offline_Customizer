namespace VS2017OfflineCustomizer
{
    class DataContainer
    {
        private const string foldername = "vs_files";

        private readonly string[,] Langs =
        {
            {"cs-CZ","Czech"},
            {"de-DE","German"},
            {"en-US","English"},
            {"es-ES","Spanish"},
            {"fr-FR","French"},
            {"it-IT","Italian"},
            {"ja-JP","Japanese"},
            {"ko-KR","Korean"},
            {"pl-PL","Polish"},
            {"pt-BR","Portuguese-Brazil"},
            {"ru-RU","Russian"},
            {"tr-TR","Turkish"},
            {"zh-CN","Chinese-Simplified"},
            {"zh-TW","Chinese-Traditional"}
        };

        private readonly string[,] Workloads =
        {
            {"Microsoft.VisualStudio.Workload.CoreEditor", "The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management."},
            {"Microsoft.VisualStudio.Workload.Azure", "Azure SDK, tools, and projects for developing cloud apps and creating resources."},
            {"Microsoft.VisualStudio.Workload.Data", "Connect, develop and test data solutions using SQL Server, Azure Data Lake, Hadoop or Azure ML."},
            {"Microsoft.VisualStudio.Workload.ManagedDesktop", "Build WPF, Windows Forms and console applications using the .NET Framework."},
            {"Microsoft.VisualStudio.Workload.ManagedGame", "Create 2D and 3D games with Unity, a powerful cross-platform development environment."},
            {"Microsoft.VisualStudio.Workload.NativeCrossPlat", "Create and debug applications running in a Linux environment."},
            {"Microsoft.VisualStudio.Workload.NativeDesktop", "Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI."},
            {"Microsoft.VisualStudio.Workload.NativeGame", "Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d."},
            {"Microsoft.VisualStudio.Workload.NativeMobile", "Build cross-platform applications for iOS, Android or Windows using C++."},
            {"Microsoft.VisualStudio.Workload.NetCoreTools", "Build cross-platform applications using .NET Core, ASP.NET Core, HTML, JavaScript, and CSS."},
            {"Microsoft.VisualStudio.Workload.NetCrossPlat", "Build cross-platform applications for iOS, Android or Windows using Xamarin."},
            {"Microsoft.VisualStudio.Workload.NetWeb", "Build web applications using ASP.NET, ASP.NET Core, HTML, JavaScript, and CSS."},
            {"Microsoft.VisualStudio.Workload.Node", "Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime."},
            {"Microsoft.VisualStudio.Workload.Office", "Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript."},
            {"Microsoft.VisualStudio.Workload.Universal", "Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿++."},
            {"Microsoft.VisualStudio.Workload.VisualStudioExtension", "Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows."},
            {"Microsoft.VisualStudio.Workload.WebCrossPlat", "Build Android, iOS and UWP apps using Tools for Apache Cordova."}
        };

        private readonly string[,] files =
        {
            {"vs_Community.exe","https://download.microsoft.com/download/5/2/1/521C52A7-EFCC-46CE-A890-4F317732ABA3/vs_Community.exe"},
            {"vs_Professional.exe","https://download.microsoft.com/download/C/5/0/C5092724-4FFE-4DD3-9EE7-0AE31BF17620/vs_Professional.exe"},
            {"vs_Enterprise.exe","https://download.microsoft.com/download/A/A/3/AA372A6A-C137-474D-95B6-865AF23DF0E1/vs_Enterprise.exe"}
        };

        public string getFoldername()
        {
            return foldername;
        }

        public string[,] getData(string type)
        {
            switch (type)
            {
                case "Language":
                    return Langs;
                case "Workload":
                    return Workloads;
                case "files":
                    return files;
                default:
                    return null;
            }
        }
    }
}
