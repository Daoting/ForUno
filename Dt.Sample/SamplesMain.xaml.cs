﻿#region 文件描述
/******************************************************************************
* 创建: Daoting
* 摘要: 
* 日志: 2013-12-16 创建
******************************************************************************/
#endregion

#region 引用命名
using Dt.Base;
using Dt.Core;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
#endregion

namespace Dt.Sample
{
    /// <summary>
    /// 控件样例
    /// </summary>
    [View("控件样例")]
    public sealed partial class SamplesMain : Win
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public SamplesMain()
        {
            InitializeComponent();
            LoadSampleList();
        }

        void LoadSampleList()
        {
            Nl<GroupData<DataCmd>> ds = new Nl<GroupData<DataCmd>>();
            GroupData<DataCmd> group = null;

            #region 框架结构
            group = new GroupData<DataCmd>
            {
                new DataCmd
                {
                    Title = "窗口布局",
                    Note = "Windows模式：窗口分上下左右和主区五个区域，由Tab承载内容，拖动时自动停靠",
                    Tag = typeof(WinLayout)
                },
                new DataCmd
                {
                    Title = "窗口内导航",
                    Note = "Phone模式：窗口内所有区域的Tab自适应为可导航的页面，多个Tab可组合成多Tab页，页面之间支持循环导航",
                    Tag = typeof(WinNavi)
                },
                new DataCmd
                {
                    Title = "切换窗口主区",
                    Note = "动态切换窗口主区的内容",
                    Tag = typeof(ToggleWinCenter)
                },
                new DataCmd
                {
                    Title = "单视图窗口",
                    Note = "只在主区显示一个Tab内容的窗口，整个窗口相当于一个页面",
                    Tag = typeof(SingleViewWin)
                },
                new DataCmd
                {
                    Title = "对话框",
                    Note = "模拟传统对话框，PC上显示在窗口上层，可拖动、调整大小、自动关闭等，手机上承载在PhonePage内",
                    Tag = typeof(DlgDemo),
                    Callback = OnNaviTo
                },
                new DataCmd
                {
                    Title = "提示信息",
                    Note = "提供两个级别的提示信息（普通、警告），在对话框上层显示，可自动关闭，最多可显示一个操作按钮",
                    Tag = typeof(NotifyDemo),
                    Callback = OnNaviTo
                },
            };
            group.Title = "框架结构";
            ds.Add(group);
            #endregion

            #region 数据控件
            group = new GroupData<DataCmd>
            {
                new DataCmd
                {
                    Title = "表单Fv",
                    Note = "表单由单元格组成，单元格包括列名和编辑器，自动布局，支持自定义行数和内容，可作为独立的布局面板使用",
                    Tag = typeof(FvHome)
                },
                new DataCmd
                {
                    Title = "列表Lv",
                    Note = "支持三类视图表格、列表、磁贴，两种数据源，三种选择模式，定制分组，上下文菜单",
                    Tag = typeof(LvHome)
                },
                new DataCmd
                {
                    Title = "树Tv",
                    Note = "支持动态加载子节点，自定义节点样式、节点内容，动态设置节点模板，上下文菜单",
                    Tag = typeof(TvHome)
                },
                new DataCmd
                {
                    Title = "报表",
                    Note = "可视化报表模板设计，报表预览时支持导出、打印、简单编辑，支持报表绘制过程脚本",
                    //Tag = typeof(RptDemo)
                },
                new DataCmd
                {
                    Title = "数据图表",
                    Note = "支持柱线饼等9大类40种不同图表，每种图表提供多种不同的调色板，支持交互操作",
                    Tag = typeof(ChartHome)
                },
                new DataCmd
                {
                    Title = "Excel",
                    Note = "包含类似Excel编辑的常用功能，报表模板设计的基础",
                    //Tag = typeof(ExcelHome)
                },
                new DataCmd
                {
                    Title = "数据访问与异常",
                    Note = "包括数据表操作、数据序列化、远程/本地数据的增删改查、远程过程调用等",
                    Tag = typeof(DataAccessHome)
                },
            };
            group.Title = "数据控件";
            ds.Add(group);
            #endregion

            #region 基础控件
            group = new GroupData<DataCmd>
            {
                new DataCmd
                {
                    Title = "菜单",
                    Note = "包括普通工具栏菜单、上下文菜单，支持多层子项、选择和分组单选等功能",
                    Tag = typeof(MenuHome),
                },
                new DataCmd
                {
                    Title = "文件",
                    Note = "跨平台文件选择、上传下载文件、不同类型图像资源",
                    Tag = typeof(FileHome),
                },
                 new DataCmd
                {
                    Title = "Tab页",
                    Note = "TabControl控件基本功能演示",
                    Tag = typeof(TabControlDemo)
                },
                new DataCmd
                {
                    Title = "系统监视输出",
                    Note = "内部使用的调试输出与断言处理，调试输出内容同时保存在日志，断言处理在调试与非调试状态有不同行为",
                    Tag = typeof(SysTraceDemo)
                },
                new DataCmd
                {
                    Title = "杂项",
                    Note = "基础事件、分隔栏、可停靠面板、流程图、控件事件顺序",
                    Tag = typeof(MiscHome)
                },
            };
            group.Title = "基础控件";
            ds.Add(group);
            #endregion

            #region 样式资源
            group = new GroupData<DataCmd>
            {
                new DataCmd
                {
                    Title = "图标",
                    Note = "内置的矢量文字，可用作图标、提示",
                    Tag = typeof(IconDemo),
                    Callback = OnNaviTo
                },
                new DataCmd
                {
                    Title = "按钮",
                    Note = "标准按钮和自定义按钮的常用样式",
                    Tag = typeof(BtnDemo),
                    Callback = OnNaviTo
                },
                new DataCmd
                {
                    Title = "常用画刷",
                    Note = "",
                    Tag = typeof(BrushDemo),
                    Callback = OnNaviTo
                },
                new DataCmd
                {
                    Title = "生成App图片",
                    Note = "生成 android 和 iOS 中用到的app图片",
                    Tag = typeof(AppIcon),
                    Callback = OnNaviTo
                },
            };
            group.Title = "样式资源";
            ds.Add(group);
            #endregion

            #region 临时
            group = new GroupData<DataCmd>
            {
                new DataCmd
                {
                    Title = "测试1",
                    Note = "Daoting测试",
                    Tag = typeof(TestDemo1)
                },
                new DataCmd
                {
                    Title = "测试2",
                    Note = "忠宝测试",
                    Tag = typeof(TestDemo2)
                },
            };
            group.Title = "临时";
            ds.Add(group);
            #endregion

            _lv.Data = ds;
        }

        void OnItemClick(object sender, ItemClickArgs e)
        {
            AtKit.RunAsync(() =>
            {
                DataCmd dc = (DataCmd)e.Data;
                if (dc.Callback != null)
                    dc.Callback(dc);
                else if (dc.Tag is Type type)
                    AtApp.OpenWin(type, dc.Title);
            });
        }

        void OnNaviTo(DataCmd p_cmd)
        {
            if (p_cmd.Tag is Type tp)
            {
                Win win = Activator.CreateInstance(tp) as Win;
                if (win != null)
                {
                    win.Title = p_cmd.Title;
                    p_cmd.Tag = win;
                }
            }
            LoadMain(p_cmd.Tag);
        }
    }
}