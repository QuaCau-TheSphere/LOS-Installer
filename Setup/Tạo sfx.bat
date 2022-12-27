cd "SFX" 
rmdir /s/q "Bộ cài chính"
del Land_of_Sphere.7z
xcopy ..\..\bin\Release\net7.0-windows10.0.17763.0\* "Bộ cài chính" /h /i /c /k /e /r /y
7z a Land_of_Sphere.7z *

cd ..
del Land_of_Sphere.exe
copy /b 7zSD.sfx + "7z config.txt" + "SFX\Land_of_Sphere.7z" "Land_of_Sphere.exe"
