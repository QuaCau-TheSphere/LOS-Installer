:: Get QuickEdit Mode setting from Windows Registry
FOR /F "usebackq tokens=3*" %%A IN (`REG QUERY "HKCU\Console" /v QuickEdit`) DO (
  set quickEditSetting=%%A %%B
)

if %quickEditSetting%==0x1 (
  :: Disable QuickEdit Mode
  reg add HKCU\Console /v QuickEdit /t REG_DWORD /d 0 /f

  :: Open script in a new Command Prompt window
  start "" "%~dpnx0" %* && exit
)

chcp 65001
title 1. Chuẩn bị

copy "SVN-Avo.ttf" "%WINDIR%\Fonts"
reg add "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" /v "SVN-Avo (TrueType)" /t REG_SZ /d SVN-Avo.ttf /f

ECHO Y | REG ADD "HKLM\Software\Microsoft\Windows\CurrentVersion\AppHost" /v EnableWebContentEvaluation /t REG_DWORD /d 0
ECHO Y | REG ADD "HKCU\Software\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\ Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\PhishingFilter" /v EnabledV9 /t REG_DWORD /d 0

winget && (
  echo winget is here
) || (
  cscript MessageBox.vbs "Bạn chưa cài winget. Vui lòng xem hướng dẫn tại trang cài đặt."
)

ECHO Y | winget install Microsoft.DotNet.DesktopRuntime.7 --accept-source-agreements --accept-package-agreements 

cd "Bộ cài chính" 
type ..\ascii.txt
"LOS Installer.exe" 
TIMEOUT /T 10