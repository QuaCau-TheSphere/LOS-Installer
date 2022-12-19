cd temp
del temp.7z
7z a temp.7z ..\..\bin\Release\net7.0-windows10.0.17763.0\*
copy /b 7zSD.sfx + "7z config for temp.txt" + temp.7z "../temp.exe"
del temp.7z.tmp

cd ..
del Land_of_Sphere.exe
7z a Land_of_Sphere.7z temp.exe Pre-open.bat SVN-Avo.ttf
copy /b 7zSD.sfx + "7z config for pre-open.txt" + Land_of_Sphere.7z "Land_of_Sphere.exe"
# "Land_of_Sphere.exe"