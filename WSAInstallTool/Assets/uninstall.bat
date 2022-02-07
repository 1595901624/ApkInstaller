@ECHO OFF
ECHO #######################################################
ECHO ##            WSA INSTALL TOOL - APK Shell Extension  2                    
ECHO ##                                                  
ECHO ##           https://gitee.com/haoyu3/wsainstall-tool     
ECHO ##        
ECHO #######################################################
ECHO 正在注销APK图标显示插件，如果报错请忽略无视.....

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
