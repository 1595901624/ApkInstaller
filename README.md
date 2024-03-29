# Apk Installer——Apk 安装工具

<img src="https://img.shields.io/badge/latest%20version-v1.7.0.0-blue.svg?style=flat" title="" alt="" data-align="inline">  ![](https://img.shields.io/badge/license-GPL%203.0-brightgreen.svg?style=flat)  ![](https://img.shields.io/badge/downloads-2,000+-brightgreen.svg?style=flat)

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
* 新增**实验室功能-恶意软件识别**[1.4.0.0]。该功能为Beta功能，如果遇到软件崩溃请停用此功能。如有误报，请提交issue或者发邮件至haoyu3@163.com

![](https://gitee.com/haoyu3/photo_gallery/raw/master/rust/other/image-20220208124851234.png)

开启此功能后，如果遇到恶意软件会展示**疑似恶意应用**的红色标签。正常应用会显示**安全**的绿色标签。如下图。

![某恶意APP](https://gitee.com/haoyu3/photo_gallery/raw/master/rust/other/image-20220208125041089.png)

![image-20220208125552323](https://gitee.com/haoyu3/photo_gallery/raw/master/rust/other/image-20220208125552323.png)

#### 多语言包支持``

自`1.3.0.0`开始将支持多语言配置。该软件默认集成了**中国-简体中文**、**中國-繁体中文（香港）**、**中國-繁体中文（台灣）**。

`1.4.0.0`新增**英文**支持。

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

1. Fork 本仓库
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request

#### Bug/意见/建议提交

请直接提交Issue

#### 其它版权信息

AAPT

ADBShell

ApkShellext2

#### 版本计划

- [x] 支持APK图标显示（1.1.0.5版本已经支持）
- [x] 支持Android所有权限提示（1.0.3.0版本已经支持）
- [x] 支持多国语言（1.3.0.0 Beta）
- [x] 支持恶意软件识别（1.5.0.0版本已经支持）
- [ ] 支持敏感权限重点提醒
- [ ] WinUI版本（远景计划）
- [ ] 使用 Rust 重构跨平台（进行中...）
- [ ] 支持 .aab/.apks 等文件的安装（远景计划）

#### 开源仓库

* Gitee：[ApkInstaller: windows下自动关联APK文件且双击即可安装到手机上。多个手机连接电脑时会弹窗提示选择设备。 (gitee.com)](https://gitee.com/haoyu3/wsainstall-tool)

* Github：[ApkInstaller: 一款可以在Windows上双击安装APK的软件 (github.com)](https://github.com/1595901624/ApkInstaller)

#### 软件下载

* 通过gitee的发行版下载
* 通过github发行版下载
* [蓝奏云网盘下载，密码：52pj](https://wwi.lanzouj.com/b04c1p59c)

#### 更新日志

##### [1.6.0.0 2023-02-24]
更新内容：

* 【新增】支持显示最低版本为“Android 12L”和“Android 13”的Apk
* 【修复】在Edge和Chrome等浏览器下载.apk/.ipa/.aapx文件时，导致浏览器Crash的问题
* 【更新】adb 版本由 33.0.2-8557947 更新至 33.0.3-8952118
* 【更新】aapt 版本由 v0.2-6966805 更新至 v0.2-9306103
* 【更新】ApkShellext2 更新至 ApkShellext2_hy 3.0.0 版本

##### [1.5.0.0 2022-07-31]

**【重要】此次更新将.Net Framework 升级到了4.8，可能会影响到Windows 7 和 Windows 8 的用户，请使用上面两个系统的用户安装.Net Framework 4.8的运行时**

* 【优化】提前启动 adb 服务，提升首次安装 Apk 的时间 

* 【优化】只连接一个手机时，却弹窗提示多手机的问题

* 【优化】清除卸载软件时，主动停止adb服务

* 【优化】部分电脑已经连接了手机却提示未连接的问题

* 【更新】 adb 版本由`29.0.5-5949299`更新至 `33.0.2-8557947`

* 【更新】aapt 版本由 `v0.2-4913185` 更新至 `v0.2-6966805` 

* 【更新】ApkShellext2 更新至 `2.0.7`版本

##### [1.4.0.0 Beta 2022-02-08]

该版本为beta测试版。

* 新增-恶意软件识别（实验室功能）如出现软件崩溃，请关闭此功能；

* 新增-软件配置页面新增偏好设置入口。

PS：如果当前正在使用旧版本，删除旧版软件。直接解压后先点击“卸载软件/清除旧版本”，再点击“一键安装”。

##### [1.3.0.0 Beta 2022-01-04]

该版本为beta测试版。
更新内容：

* 新增-偏好设置新增多语言支持，内置“中国-简体中文”,“中國-繁體中文（香港）”,“中國-繁體中文（台灣）”三个语言包；

* 新增-软件配置页面新增偏好设置入口；

* 优化-修复安装APK时在仅有一台设备连接电脑时弹出设备选择的问题；

* 优化-修复某些app无法获取icon的问题。

PS：如果当前正在使用旧版本，删除旧版软件。直接解压后先点击“卸载软件/清除旧版本”，再点击“一键安装”。

##### [1.2.3.0 2021-12-26]

* 新增-显示Apk文件的大小；

* 新增-添加偏好设置，支持Apk降级覆盖安装；

* 新增-添加偏好设置，支持安装Apk后自动关闭窗口；

* 优化-修复修改文件名之后无法安装注册的问题；

* 优化-修复Apk安装失败不显示失败原因的问题；

* 优化-软件更名为Apk Installer-为上架商店做准备。

PS：如果当前正在使用旧版本，删除旧版软件。直接解压后先点击“卸载软件/清除旧版本”，再点击“一键安装”。

##### [1.2.0.0 2021-11-20]

* 优化-将关联APK和显示应用自身图标合二为一，简化安装过程；

* 优化-修复包含空格名称的APK无法解析的问题；

* 优化-修复包含空格名称的APK无法安装的问题；

* 优化-修复部分用户关联APK导致软件崩溃的问题。

PS：如果当前正在使用旧版本，直接解压覆盖即可。

##### [1.1.0.5 2021-11-10]

* 新增-显示APK支持的最低版本；

* 新增-显示APK应用本身的图标；

* 提升稳定性，修复若干问题。

PS：如果当前正在使用旧版本，直接解压覆盖即可。
