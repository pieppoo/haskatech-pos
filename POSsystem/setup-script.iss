
[Setup]
AppName=HaskaTech POS
AppVersion=1.0.0.10
DefaultDirName={pf}\HaskaTech\HaskaTech POS
DefaultGroupName=HaskaTech
UninstallDisplayIcon={app}\POSsystem.exe
Compression=lzma2
SolidCompression=yes
OutputBaseFilename=setup
VersionInfoVersion=1.0

[Files]
Source: "*"; DestDir: "{app}"; Excludes: "*.iss"; Flags: ignoreversion
Source: "de\*"; DestDir: "{app}\de"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\HaskaTech POS"; Filename: "{app}\POSsystem.exe"
Name: "{commondesktop}\HaskaTech POS"; Filename: "{app}\POSsystem.exe";

[Run]
Filename: "{app}\POSsystem.exe"; Description: "Launch application"; Flags: postinstall nowait skipifsilent unchecked