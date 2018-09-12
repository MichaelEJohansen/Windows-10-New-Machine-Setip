function disable-powerSaving
{
    foreach ($NIC in (Get-NetAdapter -Physical)){
        $PowerSaving = Get-CimInstance -ClassName MSPower_DeviceEnable -Namespace root\wmi | ? {$_.InstanceName -match [Regex]::Escape($NIC.PnPDeviceID)}
        if ($PowerSaving.Enable){
            $PowerSaving.Enable = $false
            $PowerSaving | Set-CimInstance
        }
    }
    echo "Power saving for network devices disabled"
}
disable-powerSaving