@ECHO OFF
ECHO #######################################################
ECHO ##            WSA INSTALL TOOL - APK Shell Extension  2               
ECHO ##                                                   
ECHO ##           https://gitee.com/haoyu3/wsainstall-tool           
ECHO #######################################################

ECHO 正在注册显示APK图标插件...

REM SYSTEMINFO | FIND /i "x64-based pc"
echo %PROCESSOR_IDENTIFIER% | FIND /i "x86"

set FRAMEWORK=%windir%\Microsoft.NET\Framework
set DOTNETVERSION=v4.0.30319
IF %ERRORLEVEL%==1 (
  set FRAMEWORK=%FRAMEWORK%64
)
set REGASM="%FRAMEWORK%\%DOTNETVERSION%\regasm.exe"
%REGASM% /codebase "%~dp0\apkshellext2.dll"

ECHO 已完成
ECHO.

@ECHO ON
