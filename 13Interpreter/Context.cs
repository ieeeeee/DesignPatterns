using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interpreter
{
    /// <summary>
    /// 上下文
    /// </summary>
   public class Context
    {
        public Context(string sourceText)
        {
            SourceText = sourceText;
        }
        /// <summary>
        /// 源字符串
        /// </summary>
        public  string SourceText { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        /// <returns></returns>
        public long GetLongResult()
        {
            return long.Parse(SourceText);
        }
    }
}
