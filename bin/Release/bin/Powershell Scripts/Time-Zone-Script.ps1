#Set the time Zone
function Set-Time-Zone { param( [string]$timezone )
	try{
		Set-TimeZone -Name $timezone
		echo "Time-Zone changed to '$timezone'"
	}
	catch{
		Write-Error "Error Changing Timezone! (Timezone correct?)"
	}
}
Set-Time-Zone "Eastern Standard Time"