function rename-PC
{
    $input = Read-Host “Enter new PC name: ”
    Rename-Computer -newname “$input”
}
rename-PC