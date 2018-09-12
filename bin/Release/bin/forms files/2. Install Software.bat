@echo off
START /wait "Ninite" /D "%~dp0.\..\Batch Files" Ninite-Module.bat
START /wait "Choco" /D "%~dp0.\..\Batch Files" Chocolatey-Boxstarter-Module.bat