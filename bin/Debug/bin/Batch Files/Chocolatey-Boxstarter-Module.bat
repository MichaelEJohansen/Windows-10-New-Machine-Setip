@ECHO OFF
:: Chocolatey/ Boxatarter install script
:: Also installs Adobe Reader, MalwareBytes, and Logmein

@powershell -NoExit -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

choco install adobereader -fy
:: Took out logmein because it's just easier to use the installer through the website
::choco install logmein.client -fy

CINST Boxstarter -fy