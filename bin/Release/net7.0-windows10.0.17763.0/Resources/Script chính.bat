chcp 65001
cd %1
set clonePath=%1%
set "vaultPath=%clonePath:"=%\LandofSpheres"

winget install -e --id Git.Git 

git config --global core.quotePath false
git config --global core.longpaths true
git config --global core.autocrlf true
git config --global core.safecrlf false
git config --global --add safe.directory '*'

git clone https://github.com/QuaCau-TheSphere/LandofSpheres

winget install --accept-source-agreements --accept-package-agreements Obsidian

set "doubleSlashes=%vaultPath:\=\\%" 
echo %doubleSlashes%
set "obsidianString={"vaults":{"0123456789abcdef":{"path":"%doubleSlashes%","open":true}}}" 
echo %obsidianString%
C:
cd %appdata%
cd
echo %obsidianString% > %appdata%/obsidian/obsidian.json
%appdata%\..\Local\Obsidian\Obsidian.exe "obsidian://vault/LandofSpheres/== Bản đồ dành cho người mới =="

winget install --accept-source-agreements --accept-package-agreements gitkraken

pause 