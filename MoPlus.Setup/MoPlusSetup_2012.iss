; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Mo+ Solution Builder"
#define MyAppVersion "1.0"
#define MyAppPublisher "Mo+"
#define MyAppURL "https://moplus.codeplex.com"
#define MyAppExeName "MoPlusSolutionBuilder.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{25A52A22-9129-422F-A89F-CA292FF22D7E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=.\License.txt
InfoBeforeFile=.\Intro.txt
InfoAfterFile=.\Exit.txt
OutputBaseFilename=MoPlusSetup
SetupIconFile=Product.ico
UninstallDisplayIcon={app}\Product.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "..\MoPlus.SolutionUpdater.CommandUI\bin\Release\*.*"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\MoPlus.SolutionBuilder.VSPackage\bin\x86\Release\*.*"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\MoPlus.SolutionBuilder.WpfUI\bin\Release\*.*"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\MoPlus.SolutionBuilder.WpfUI\Product.ico"; DestDir: "{app}"; Flags: ignoreversion
; add items to GAC
Source: "..\MoPlus.SolutionBuilder.VSPackage\bin\x86\Release\AvalonDock.dll"; DestDir: "{app}"; StrongAssemblyName: "AvalonDock, Version=2.0.1746.0, Culture=neutral, PublicKeyToken=AD3D1BD6-0E64-4DF5-9596-C8805114DC6D, ProcessorArchitecture=MSIL"; Flags: "gacinstall sharedfile uninsnosharedfileprompt"
Source: "..\MoPlus.SolutionBuilder.VSPackage\bin\x86\Release\Irony.dll"; DestDir: "{app}"; StrongAssemblyName: "Irony, Version=1.0.0.0, Culture=neutral, PublicKeyToken=7A9A1929-3018-4279-97E8-88F40956DAA0, ProcessorArchitecture=MSIL"; Flags: "gacinstall sharedfile uninsnosharedfileprompt"
Source: "..\MoPlus.SolutionBuilder.VSPackage\bin\x86\Release\ICSharpCode.AvalonEdit.dll"; DestDir: "{app}"; StrongAssemblyName: "ICSharpCode.AvalonEdit, Version=4.3.1.9429, Culture=neutral, PublicKeyToken=9600A30E-6597-4114-87C5-73714F4D9D5C, ProcessorArchitecture=MSIL"; Flags: "gacinstall sharedfile uninsnosharedfileprompt"
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
; VS Package
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\InstalledProducts\Mo+ Solution Builder; ValueType: none; Flags: uninsdeletekey
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\InstalledProducts\Mo+ Solution Builder; ValueType: string; ValueName: Package; ValueData: {{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\InstalledProducts\Mo+ Solution Builder; ValueType: dword; ValueName: UseInterface; ValueData: 1
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: none; Flags: uninsdeletekey
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: ; ValueData: MoPlus.SolutionBuilder.VSPackage.MoPlusPackage, MoPlus.SolutionBuilder.VSPackage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f4d94ac959d59ec3
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: InprocServer32; ValueData: {sys}\MSCOREE.DLL
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: Class; ValueData: MoPlus.SolutionBuilder.VSPackage.MoPlusPackage
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: CodeBase; ValueData: {app}\MoPlus.SolutionBuilder.VSPackage.dll
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: dword; ValueName: ID; ValueData: $000003E9
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: MinEdition; ValueData: Standard
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: ProductVersion; ValueData: 1.0
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: ProductName; ValueData: Mo+ Solution Builder
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Packages\{{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueType: string; ValueName: CompanyName; ValueData: Mo+
; menu
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\Menus; ValueType: string; ValueName: {{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}; ValueData: , Menus.ctmenu, 1
; Solution Builder tool window
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{b2a086f1-775d-4f60-bb81-202c23fea3af}; ValueType: none; Flags: uninsdeletekey
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{b2a086f1-775d-4f60-bb81-202c23fea3af}; ValueType: string; ValueName: ; ValueData: {{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{b2a086f1-775d-4f60-bb81-202c23fea3af}; ValueType: string; ValueName: Name; ValueData: MoPlus.SolutionBuilder.VSPackage.SolutionBuilderWindow
; Solution Designer tool window
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{D02CD70D-1F36-45cb-B837-BE33C62B5839}; ValueType: none; Flags: uninsdeletekey
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{D02CD70D-1F36-45cb-B837-BE33C62B5839}; ValueType: string; ValueName: ; ValueData: {{8fe4675c-3156-4a6a-9b35-d7cc6f4ee432}
Root: HKLM; SubKey: Software\Microsoft\VisualStudio\11.0\ToolWindows\{{D02CD70D-1F36-45cb-B837-BE33C62B5839}; ValueType: string; ValueName: Name; ValueData: MoPlus.SolutionBuilder.VSPackage.SolutionDesignerWindow

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

