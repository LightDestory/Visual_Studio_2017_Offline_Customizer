namespace VS2017OfflineCustomizer
{
    class DataContainer
    {
        private const string VersionOnline = "https://raw.githubusercontent.com/LightDestory/Visual_Studio_2017_Offline_Customizer/master/version.txt";

        private const string Github = "https://github.com/LightDestory/Visual_Studio_2017_Offline_Customizer";

        private const string MyWebsite = "http://lightdestoryweb.altervista.org/";

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

        private const string Workload_prefix = "Microsoft.VisualStudio.Workload.";

        private readonly string[,] Workloads =
        {
            {"CoreEditor", "The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management."},
            {"Azure", "Azure SDK, tools, and projects for developing cloud apps and creating resources."},
            {"Data", "Connect, develop and test data solutions using SQL Server, Azure Data Lake, Hadoop or Azure ML."},
            {"ManagedDesktop", "Build WPF, Windows Forms and console applications using the .NET Framework."},
            {"ManagedGame", "Create 2D and 3D games with Unity, a powerful cross-platform development environment."},
            {"NativeCrossPlat", "Create and debug applications running in a Linux environment."},
            {"NativeDesktop", "Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI."},
            {"NativeGame", "Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d."},
            {"NativeMobile", "Build cross-platform applications for iOS, Android or Windows using C++."},
            {"NetCoreTools", "Build cross-platform applications using .NET Core, ASP.NET Core, HTML, JavaScript, and CSS."},
            {"NetCrossPlat", "Build cross-platform applications for iOS, Android or Windows using Xamarin."},
            {"NetWeb", "Build web applications using ASP.NET, ASP.NET Core, HTML, JavaScript, and CSS."},
            {"Node", "Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime."},
            {"Office", "Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript."},
            {"Universal", "Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿++."},
            {"VisualStudioExtension", "Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows."},
            {"WebCrossPlat", "Build Android, iOS and UWP apps using Tools for Apache Cordova."}
        };

        private readonly string[,] files =
        {
            {"vs_Community.exe","https://download.microsoft.com/download/A/6/B/A6B03A5D-808D-4E21-9CF7-532D16240AD7/vs_Community.exe"},
            {"vs_Professional.exe","https://download.microsoft.com/download/7/B/0/7B0534FD-DCE5-46D5-8771-91FD32AFC51D/vs_Professional.exe"},
            {"vs_Enterprise.exe","https://download.microsoft.com/download/F/3/4/F3478590-7B38-48B1-BB6E-3141A9A155E7/vs_Enterprise.exe"}
        };

        public string Getfoldername()
        {
            return foldername;
        }

        public string GetWorkload_prefix()
        {
            return Workload_prefix;
        }

        public string GetVersionOnline()
        {
            return VersionOnline;
        }

        public string GetGitHub()
        {
            return Github;
        }

        public string GetMyWebsite()
        {
            return MyWebsite;
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
