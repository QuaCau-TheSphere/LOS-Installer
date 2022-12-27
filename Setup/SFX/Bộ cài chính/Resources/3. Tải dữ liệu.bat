chcp 65001
title 3. Tải dữ liệu
set "clonePath=%1"
set "vaultPath=%clonePath:"=%\Land of Spheres"
set path=C:\Program Files\Git\cmd
cd "%clonePath%"

git config --global core.quotePath false
git config --global core.longpaths true
git config --global core.autocrlf true
git config --global core.safecrlf false

git clone https://github.com/QuaCau-TheSphere/LandofSpheres "Land of Spheres"
git config --global --add safe.directory *

set "doubleSlashes=%vaultPath:\=\\%" 
set "obsidianString={"vaults":{"0123456789abcdef":{"path":"%doubleSlashes%","open":true}}}" 

C:
mkdir "%appdata%\obsidian"
cd "%appdata%\obsidian"
echo %obsidianString%>obsidian.json
