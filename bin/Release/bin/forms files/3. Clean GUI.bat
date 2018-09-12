@echo off
START /wait "Clean GUI" /D "%~dp0.\..\Batch Files" Taskbar-Module.bat
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\Unpin-From-Taskbar-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\Unpin-From-Start-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\People-Off-Taskbar-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\Make-Default-Folder-Home-Script.ps1""' -Verb RunAs}"