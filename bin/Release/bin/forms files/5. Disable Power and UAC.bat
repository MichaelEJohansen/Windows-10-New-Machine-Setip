@echo off
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\Disable-UAC-Script.ps1""' -Verb RunAs}"
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\..\Powershell Scripts\Disable-Power-Saving-Script.ps1""' -Verb RunAs}"