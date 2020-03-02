# Unity 3D 图形用户界面

## 一、GUI简介

在游戏开发过程中，为了增强游戏与玩家的交互性，开发人员往往会通过制作大量的图形用户界面（Graphical User Interface，GUI）来增强这一效果。

Unity 3D 中的图形系统分为 OnGUI、NGUI、UGUI 等，这些类型的图形系统内容十分丰富，包含游戏中通常使用到的按钮、图片、文本等控件。

### 1.GUI 的概念

图形用户界面是指采用图形方式显示的计算机用户操作界面。

与早期计算机使用的命令行界面相比，图形界面对于用户来说在视觉上更易于接受，可以使玩家更好地了解游戏。

### 2.GUI 的发展

在游戏开发的整个过程中，游戏界面占据了非常重要的地位。

玩家在启动游戏的时候，首先看到的就是游戏的 GUI，其中包括贴图、按钮和高级控件等。

早期的 Unity 3D 采用的是 OnGUI 系统，后来进展到了 NGUI 系统。

在 Unity 4.6 以后 Unity 官方推出了新的 UGUI 系统，采用全新的独立坐标系，为游戏开发者提供了更高的运转效率。

UGUI与NGUI的区别
- UGUI具有屏幕自适应、深度管理（渲染顺序）、图集管理的特点。


UGUI与之前GUI的区别

- UGUI——所见即所得，简单易学，易开发
- GUI——代码控制，高级应用，多用于调试

## 二、UGUI概要与基本布局

- Canvas（画布）
- EventSystem（事件系统）
- The Rect Tool（矩形工具）
- Rect Transform（矩形变换组件）
- Anchors（锚点）
- Pivot（中心点）

### 1.Canvas（画布）

#### 什么是画布

- 摆放容纳所有UI元素的区域，所有的UI元素都需要在画布上组装。
- 脱离画布，UI组件就不能使用
- 举例：电脑显示器，教室的屏幕，即所见物体的载体

#### 创建画布——两种方式
- 通过菜单直接创建
- 首次创建一个UI控件时，会同时自动创建一个容纳该控件的画布

#### 画布的相关组件介绍

![](https://raw.githubusercontent.com/qinnian/FigureBed/master/20200302155959.png)

Render Mode（渲染模式）

- Screen Space – Overlay: 2DUI，始终显示在屏幕最前方
- Screen Space – Camera: 2D及3DUI，绑定到制定摄像机，可进行3D旋转（3D效果）
- World Space: UI在3D空间，与摄像机分离







