chcp 65001
cd %1
set clonePath=%1%
set "vaultPath=%clonePath:"=%\LandofSpheres"

set "doubleSlashes=%vaultPath:\=\\%" 
echo %doubleSlashes%
set "obsidianString={"vaults":{"0123456789abcdef":{"path":"%doubleSlashes%","open":true}}}" 
echo %obsidianString%
C:
cd %appdata%
cd
echo %obsidianString% > %appdata%/obsidian/obsidian.json
%appdata%\..\Local\Obsidian\Obsidian.exe "obsidian://vault/LandofSpheres/== Bản đồ dành cho người mới =="

pause >NUL