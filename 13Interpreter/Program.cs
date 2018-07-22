using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interpreter
{
    /// <summary>
    /// 解释器模式，行为性模式
    /// 有一个上下文环境，有些规则，比如在aspx,cshtml，可以嵌入后台代码，在前台就是解释器模式，就知道这些是后台代码
    /// TPL语言 template 模板语言，就是解释器模式，把嵌入的后台代码解释出来是后台的
    /// web开发与后台交流的
    /// 发布系统，把动态数据发布成静态HTML，用户直接访问，不需要访问数据库 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                string text = "abcde";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }
            {
                string text = "bcdefg";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }
            {
                string text = "cdefghij";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }

            {
                string text = "cdefghijkjsdfhjk";
                Context context = new Context(text);
                List<BaseExpression> expressionList = new List<BaseExpression>();
                expressionList.Add(new OtherExpression());
                expressionList.Add(new ZeroExpression());
                foreach (BaseExpression expression in expressionList)
                {
                    expression.TranscateContext(context);
                }


                Console.WriteLine("转换结果是{0}={1}", text, context.GetLongResult());
            }



            Console.ReadKey();
        }

        /// <summary>
        /// 转换规则是 
        /// a到i  对应1到9
        /// 其他的都是0
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static long ToLong(string text)
        {
            long lResult = 0;
            switch (text)
            {
                case "abcde":
                    lResult = 12345;
                    break;
                case "bcdefg":
                    lResult = 234567;
                    break;
                case "cdefghij":
                    lResult = 34567890;
                    break;
                default:
                    throw new Exception("错误的字符串");
            }

            return lResult;
        }
    }
}
