#region 文件描述
/******************************************************************************
* 创建: Daoting
* 摘要: 
* 日志: 2014-07-01 创建
******************************************************************************/
#endregion

#region 引用命名
using System;
#endregion

namespace Dt.Charts
{
    public class AxisRangeChangedEventArgs : EventArgs
    {
        public readonly double Scale;
        public readonly double Value;

        public AxisRangeChangedEventArgs(double value, double scale)
        {
            Value = value;
            Scale = scale;
        }
    }
}

