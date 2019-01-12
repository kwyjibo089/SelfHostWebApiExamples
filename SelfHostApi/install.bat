sc create SelfHostApi binPath= %~dp0SelfHostApi.exe
sc failure SelfHostApi actions= restart/60000/restart/60000/""/60000 reset= 86400
sc start SelfHostApi
sc config SelfHostApi start=auto