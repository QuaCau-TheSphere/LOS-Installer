cd Main installer
del "Main installer.7z" 
7z a "Main installer.7z"  ..\..\bin\Release\net7.0-windows10.0.17763.0\*
copy /b 7zSD.sfx + "7z config for Main installer.txt" + "Main installer.7z" "../Main installer.exe"
del "Main installer.7z".tmp

cd ..
del Land_of_Sphere.exe
del Land_of_Sphere.7z
7z a Land_of_Sphere.7z "Main installer.exe" "1. Chuẩn bị.bat" SVN-Avo.ttf
copy /b 7zSD.sfx + "7z config for 1. Chuẩn bị.txt" + Land_of_Sphere.7z "Land_of_Sphere.exe"
# "Land_of_Sphere.exe"