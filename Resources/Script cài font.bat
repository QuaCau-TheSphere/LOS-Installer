copy "SVN-Avo.ttf" "%WINDIR%\Fonts"
reg add "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" /v "SVN-Avo (TrueType)" /t REG_SZ /d SVN-Avo.ttf /f

"..\LOS Installer.exe"