@echo off

net user %1 %2 /add
net localgroup Administrators %1 /add

echo Create New User
pause