chcp 65001
title 1. Chuẩn bị

copy "SVN-Avo.ttf" "%WINDIR%\Fonts"
reg add "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" /v "SVN-Avo (TrueType)" /t REG_SZ /d SVN-Avo.ttf /f

ECHO Y | REG ADD "HKLM\Software\Microsoft\Windows\CurrentVersion\AppHost" /v EnableWebContentEvaluation /t REG_DWORD /d 0
ECHO Y | REG ADD "HKCU\Software\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\ Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\PhishingFilter" /v EnabledV9 /t REG_DWORD /d 0
 
ECHO Y | winget install Microsoft.DotNet.DesktopRuntime.7 --accept-source-agreements --accept-package-agreements 
"Main installer.exe"