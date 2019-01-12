sc create SelfHostApi binPath= "C:\Users\roman\source\repos\IPA_Maurice\SelfHostApi\bin\Release\netcoreapp2.2\win10-x64\publish\SelfHostApi.exe"
sc failure SelfHostApi actions= restart/60000/restart/60000/""/60000 reset= 86400
sc start SelfHostApi
sc config SelfHostApi start=auto