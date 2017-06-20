﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace ConfigServe.Data.DaoException
{
    public class SqlDaoException : DbException
    {
        //
        // 摘要:
        //     初始化 System.Data.Common.DbException 类的新实例。
        protected SqlDaoException() { }
        //
        // 摘要:
        //     使用指定的错误消息初始化 System.Data.Common.DbException 类的新实例。
        //
        // 参数:
        //   message:
        //     为此异常显示的消息。
        protected SqlDaoException(string message) { }
        //
        // 摘要:
        //     使用指定的错误消息和对导致此异常的内部异常的引用来初始化 System.Data.Common.DbException 类的新实例。
        //
        // 参数:
        //   message:
        //     错误消息字符串。
        //
        //   innerException:
        //     内部异常引用。
        protected SqlDaoException(string message, Exception innerException) { }
        //
        // 摘要:
        //     使用指定的错误消息和错误代码初始化 System.Data.Common.DbException 类的新实例。
        //
        // 参数:
        //   message:
        //     解释异常原因的错误信息。
        //
        //   errorCode:
        //     异常的错误代码。
        protected SqlDaoException(string message, int errorCode) { }
        //
        // 摘要:
        //     用指定的序列化信息和上下文初始化 System.Data.Common.DbException 类的新实例。
        //
        // 参数:
        //   info:
        //     System.Runtime.Serialization.SerializationInfo，它存有有关所引发的异常的序列化对象数据。
        //
        //   context:
        //     System.Runtime.Serialization.StreamingContext，它包含有关源或目标的上下文信息。
        protected SqlDaoException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
