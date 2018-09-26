@echo off
powershell -ExecutionPolicy ByPass -NoProfile %~dp0eng\Build.ps1 -restore -build -warnaserror:0 -nodereuse:0 %*
echo Build.cmd ErrorLevel=%ERRORLEVEL%
exit /b %ERRORLEVEL%
