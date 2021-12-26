# Apk Installer

![](https://img.shields.io/badge/version-v1.2.3.0-blue.svg?style=flat)

#### 介绍

Apk Installer（原名:WSAInstallTool，自1.2.3.0版本后更名）是一款Windows下自动关联APK文件且双击APK安装到任意安卓设备上的工具。该软件可以显示Apk自身的图标，详细的权限列表等。

支持Windows 11 安卓子系统，支持Windows 7、Windows 10 、Windows 11安装软件至任意安卓设备上。如软件无法运行，请安装.Net Framework 4.5.2。该软件主要服务于Windows 11 的Android子系统和Android开发者。

#### 软件架构
软件采用C# + WinForm开发。


#### 安装教程

**如果旧版本升级到1.2.3.0，打开软件后，先点击点击一键清除然后再重新点击一键安装即可**

下载解压至任意位置后，双击**ApkInstaller.exe**即可。ApkInstaller的安装和卸载需要操作注册表，请使用**管理员身份运行**此软件。

![image-20211226110111461](https://gitee.com/haoyu3/photo_gallery/raw/master/rust/other/image-20211226110111461.png)

#### 软件截图

![image-20211226105516258](https://gitee.com/haoyu3/photo_gallery/raw/master/rust/other/image-20211226105516258.png)

#### 使用说明

安装：点击一键安装。
卸载：点击卸载软件或者清除旧版本，然后删除文件夹即可。

#### 软件功能

* 支持显示APK自身图标[1.1.0.5]
* 双击APK直接安装至安卓设备[1.1.0.5]
* 显示Apk的包名，版本号，最低支持安卓版本，大小，权限等信息[1.0.3.0]
* 支持覆盖安装，降级安装[1.2.3.0]

#### 参与贡献

1.  Fork 本仓库
2.  新建 Feat_xxx 分支
3.  提交代码
4.  新建 Pull Request


#### Bug/意见/建议提交

请直接提交Issue

#### 其它版权信息

AAPT

ADBShell

ApkShellext2

#### 版本计划

* 支持APK图标显示（1.1.0.5版本已经支持）
* 支持Android所有权限提示（1.0.3.0版本已经支持）
* 支持敏感权限重点提醒
* 支持多国语言
* 支持恶意软件识别（远景计划）
* UWP版本（远景计划）
