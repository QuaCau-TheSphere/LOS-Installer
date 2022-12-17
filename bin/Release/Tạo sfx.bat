del net7.0-windows10.0.17763.0.7z
7z a net7.0-windows10.0.17763.0.7z .\net7.0-windows10.0.17763.0\*
copy /b 7zSD.sfx + "7z config.txt" + net7.0-windows10.0.17763.0.7z "Land_of_Sphere.exe"
"Land_of_Sphere.exe"
del net7.0-windows10.0.17763.0.7z.tmp