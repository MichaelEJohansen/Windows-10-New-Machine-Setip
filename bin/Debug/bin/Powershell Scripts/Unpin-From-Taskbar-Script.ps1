function unpin-From-Taskbar{
    $appnames = "^Microsoft Edge$|^Microsoft Store$|^Mail$"
    ((New-Object -Com Shell.Application).NameSpace('shell:::{4234d49b-0245-4df3-b780-3893943456e1}').Items() | 
      Where-Object{$_.Name -match $appnames}).Verbs() | 
      Where-Object{$_.Name.replace('&','') -match 'Unpin from taskbar|Von "Start" lösen'} | 
      ForEach-Object{$_.DoIt(); $exec = $true}
      echo "Apps unpinned from taskbar. "
}
unpin-From-Taskbar