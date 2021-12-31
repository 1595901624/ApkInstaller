# Apk Installer

![](https://img.shields.io/badge/version-v1.2.3.0-blue.svg?style=flat)    ![](https://img.shields.io/badge/license-GPL%203.0-brightgreen.svg?style=flat)

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

#### 多语言包支持

自`1.2.5.0`开始将支持多语言配置。该软件默认集成了**中国-简体中文**、**中國-繁体中文（香港）**、**中國-繁体中文（台灣）**。

##### 如何支持更多语言？

说实话，本地化工作是一项非常劳累的工作。作者能力和时间有限，如果您想支持其它语言，可参照下面的方法进行本地化操作。

软件的语言包在**软件安装目录 / lang**目录下。其中`lang.json`是存放目前支持的所有语言包信息（如下所示）。`id`表示序号，`name`表示语言包的名称，`file`表示语言包的文件名。这三个字段是必须的。

```json
[
    {
        "id": 0,
        "name": "中国-简体中文",
        "file": "zh_CN.json"
    },
    {
        "id": 1,
        "name": "中國-繁體中文(香港)",
        "file": "zh_HK.json"
    }
]

```

另外，目录下的其它文件则是真正的语言包了，通过键值对的形式一一对应。其结构如下所示：

```json
{
    "launchTip": "部分設置項需要操作註冊表，請使用管理員身份運行此軟體！",
    "ok": "確定",
    "associateApk": "關聯APK",
    "oneKeyInstall": "一鍵安裝",
    "oneKeyUninstall": "卸載軟體/清除舊版本",
    "about": "關於"
}
```

PS：语言包必须保存为**UTF8**字符编码的`.json`格式。您也可以在gitee上提交您的语言包。或者发送邮件至`haoyu3@163.com`。

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
* 支持多国语言（内测中...）
* 支持恶意软件识别（远景计划）
* UWP版本（远景计划）

#### 软件下载

* 通过gitee的发行版下载
* [蓝奏云网盘下载，密码：52pj](https://wwi.lanzouj.com/b04c1p59c)

