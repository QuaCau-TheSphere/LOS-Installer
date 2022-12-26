ECHO Y | REG ADD "HKLM\Software\Microsoft\Windows\CurrentVersion\AppHost" /v EnableWebContentEvaluation /t REG_DWORD /d 0
ECHO Y | REG ADD "HKCU\Software\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\ Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\PhishingFilter" /v EnabledV9 /t REG_DWORD /d 0

winget install notepad++ 
winget install sharex.sharex --accept-source-agreements --accept-package-agreements 
winget install VideoLAN.VLC
winget install copyq
winget install autohotkey
