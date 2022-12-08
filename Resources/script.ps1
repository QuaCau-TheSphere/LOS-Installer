chdir
chdir %1

echo "=== Tải Git === "
 winget install --id Git.Git -e --source winget 
echo "=== Cài Git === "
.\Git-*.exe /SILENT

"git config --global core.quotePath false" 
git config --global core.quotePath false

"git config --global core.longpaths true" 
git config --global core.longpaths true

"git config --global core.autocrlf true" 
git config --global core.autocrlf true

"git config --global core.safecrlf false" 
git config --global core.safecrlf false

"git config --global --add safe.directory '*'" 
git config --global --add safe.directory '*'

"git clone https://github.com/QuaCau-TheSphere/LandofSpheres" 
git clone https://github.com/QuaCau-TheSphere/LandofSpheres

echo "=== Tải Obsidian ===" 
winget install Obsidian

echo "=== Cài Obsidian ===" 
.\Obsidian*.exe /S

"Cài GitKraken" 
.\GitKrakenSetup.exe -s

"Dữ liệu đã được lưu thành công. Hãy " 