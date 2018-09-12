@Echo OFF
::Ask if a new local user should be made, if so make them

set /p userName=Enter username:
set /p passWord=Enter Password:

net user "%userName%" "%passWord%" /add
net localgroup Administrators "%userName%" /add

:userEnd