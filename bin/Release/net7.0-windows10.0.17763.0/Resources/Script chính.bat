chdir
chdir %1
winget install --id Git.Git -e --source winget 
winget install Obsidian

git config --global core.quotePath false
git config --global core.longpaths true
git config --global core.autocrlf true
git config --global core.safecrlf false
git config --global --add safe.directory '*'

git clone https://github.com/QuaCau-TheSphere/LandofSpheres

set "doubleSlashes=%path:\=\\%" 
set "obsidianString={"vaults":{"0123456789abcdef":{"path":"%doubleSlashes%","open":true}}}" 
C:
cd %appdata%
echo %obsidianString% > %appdata%/obsidian/obsidian.json
%appdata\..\Local\Obsidian\Obsidian.exe obsidian
://open?vault=Land%20of%20Spheres&file=%3D%3D%20B%E1%BA%A3n%20%C4%91%E1%BB%93%20d%C3%A0nh%20cho%20ng%C6%B0%E1%BB%9Di%20m%E1%BB%9Bi%20%3D%3D   

winget install gitkraken

echo Đã cài xong 🎆