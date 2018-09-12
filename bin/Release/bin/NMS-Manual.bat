@echo off
title New Machine Setup - Manual

set _powerShellWait=start "PowerShell" /wait %SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe

::starting at bloatware, iterate through setup options
goto Bloatware

:Bloatware
set /p runBloatware=Remove bloatware [y/n]?

IF /i "%runBloatware%"=="y" (
	echo IMPORTANT: Let the bloatware removal utility completely finish before coninuing with NMS.
	START /wait "BRU" /D "%~dp0.\Batch Files" Bloatware-Module.bat
	pause
	goto newUser
)
IF /i "%runBloatware%"=="n" goto NewUser
echo Unrecognized response
goto Bloatware

:NewUser
set /p createNewUser=Create new end user as a local administrator [y/n]?

IF /i "%createNewUser%"=="y" (
	START /wait "Create New User" /D "%~dp0.\Batch Files" New-User-Module.bat
	goto Ninite
)
IF /i "%createNewUser%"=="n" goto Ninite
echo Unrecognized response
goto NewUser

:Ninite
set /p useNiniteChoco=Install web browsers, runtimes, MalwareBytes, and Adobe Reader [y/n]?

IF /i "%useNiniteChoco%"=="y" (
	ECHO Waiting for software installation to finish before continuing.
	START /wait "Ninite" /D "%~dp0.\Batch Files" Ninite-Module.bat
	START /wait "Choco" /D "%~dp0.\Batch Files" Chocolatey-Boxstarter-Module.bat
	ECHO Software installation complete.
	GOTO CleanGUI
)
IF /i "%useNiniteChoco%"=="n" goto CleanGUI
echo Unrecognized response
goto Ninite

:CleanGUI
set /p cleanGUI=Clean up taskbar, start menu, and set default explorer folder to this PC [y/n]?

IF /i "%cleanGUI%"=="y" (
	START /wait "Clean GUI" /D "%~dp0.\Batch Files" Taskbar-Module.bat
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Unpin-From-Taskbar-Script.ps1""' -Verb RunAs}"
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Unpin-From-Start-Script.ps1""' -Verb RunAs}"
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\People-Off-Taskbar-Script.ps1""' -Verb RunAs}"
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Make-Default-Folder-Home-Script.ps1""' -Verb RunAs}"
	goto TimeZone
)
IF /i "%cleanGUI%"=="n" goto TimeZone
echo Unrecognized response
goto CleanGUI

:TimeZone
set /p setTimeZone=Change timezone to U.S. East [y/n]?

IF /i "%setTimeZone%"=="y" (
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Time-Zone-Script.ps1""' -Verb RunAs}"
	goto UAC
)
IF /i "%setTimeZone%"=="n" goto UAC
echo Unrecognized response
goto TimeZone

:UAC
set /p disableUAC=Disable UAC [y/n]?

IF /i "%disableUAC%"=="y" (
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Disable-UAC-Script.ps1""' -Verb RunAs}"
	goto PowerSaving
)
IF /i "%disableUAC%"=="n" goto PowerSaving
echo Unrecognized response
goto UAC

:PowerSaving
set /p disablePowerSaving=Disable power saving for network adapters [y/n]?

IF /i "%disablePowerSaving%"=="y" (
	%_powerShellWait% -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Disable-Power-Saving-Script.ps1""' -Verb RunAs}"
	goto RenamePC
)
IF /i "%disablePowerSaving%"=="n" goto RenamePC
echo Unrecognized response
goto PowerSaving

:RenamePC
set /p renamePC=Rename PC [y/n]?

IF /i "%renamePC%"=="y" (
	PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\Powershell Scripts\Rename-PC-Script.ps1""' -Verb RunAs}"
	goto exitProgram
)
IF /i "%renamePC%"=="n" goto exitProgram
echo Unrecognized response


::End of Program
:exitProgram

::Exit explorer and restart it to apply changes
taskkill /f /im explorer.exe
start explorer.exe
echo New Machine Setup has finished.
pause
