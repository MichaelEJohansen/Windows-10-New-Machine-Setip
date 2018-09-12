@echo off
title New Machine Setup - All

echo Starting Bloatware Removal Utility...
START /wait "BRU" /D "E:\Windows 10 NMS 2.0\bin\Batch Files" Bloatware-Module.bat
echo IMPORTANT: Please allow the bloatware removal tool to completely finish running before continuing.
pause

echo Creating new user...
START /wait "Create New User" /D "E:\Windows 10 NMS 2.0\bin\Batch Files" New-User-Module.bat
pause

echo Starting Ninite...
START /wait "Ninite" /D "E:\Windows 10 NMS 2.0\bin\Batch Files" Ninite-Module.bat
echo IMPORTANT: Please allow the Ninite to completely finish running before continuing.
pause

echo Starting software installation script...
START /wait "Choco" /D "E:\Windows 10 NMS 2.0\bin\Batch Files" Chocolatey-Boxstarter-Module.bat
echo IMPORTANT: Please allow the software install script to completely finish running before continuing.
pause

echo Cleaning windows GUI... (Warning: double check start menu, chances are there will still be tiles to unpin)
START /wait "Clean GUI" /D "E:\Windows 10 NMS 2.0\bin\Batch Files" Taskbar-Module.bat
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Unpin-From-Taskbar-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Unpin-From-Start-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\People-Off-Taskbar-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Make-Default-Folder-Home-Script.ps1""' -Verb RunAs}"
pause

Echo Changing time zone...
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Time-Zone-Script.ps1""' -Verb RunAs}"
Echo Disabling UAC...
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Disable-UAC-Script.ps1""' -Verb RunAs}"
Echo Removing power saving from network drivers...
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Disable-Power-Saving-Script.ps1""' -Verb RunAs}"
echo Renaming PC...
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""E:\Windows 10 NMS 2.0\bin\Powershell Scripts\Rename-PC-Script.ps1""' -Verb RunAs}"

echo New Machine Setup utility complete
pause
