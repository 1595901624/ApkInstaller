@ECHO OFF
ECHO #######################################################
ECHO ##            ApkInstaller - APK Shell Extension  2                    
ECHO ##                                                  
ECHO ##           https://gitee.com/haoyu3/wsainstall-tool     
ECHO ##        
ECHO #######################################################
ECHO ����ע��APKͼ����ʾ���������������������.....

REM SYSTEMINFO | FIND /i "x64-based pc"
echo %PROCESSOR_IDENTIFIER% | FIND /i "x86"

set FRAMEWORK=%windir%\Microsoft.NET\Framework
set DOTNETVERSION=v4.0.30319
IF %ERRORLEVEL%==1 (
  set FRAMEWORK=%FRAMEWORK%64
)
set REGASM="%FRAMEWORK%\%DOTNETVERSION%\regasm.exe"
%REGASM% /unregister "%~dp0\apkshellext2.dll"

ECHO.
REM ECHO The apkshellext.dll may can't be deleted before explorer restart.

ECHO.

#PAUSE
@ECHO ON
