function unpin-All-Apps{
    (New-Object -Com Shell.Application).
        NameSpace('shell:::{4234d49b-0245-4df3-b780-3893943456e1}').
        Items() |
      %{ $_.Verbs() } |
      ?{$_.Name -match 'Un.*pin from Start'} |
      %{$_.DoIt()}
      echo "Apps unpinned from start"
}
unpin-All-Apps

Get-AppxPackage *MinecraftUWP* | Remove-AppxPackage