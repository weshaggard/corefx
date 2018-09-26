@echo off
powershell -ExecutionPolicy ByPass -NoProfile %~dp0common\msbuild.ps1 %~dp0..\src\tests.builds /p:Performance=false -warnaserror:0 -nodereuse:0 %*
echo build-test.cmd ErrorLevel=%ERRORLEVEL%
exit /b %ERRORLEVEL%
