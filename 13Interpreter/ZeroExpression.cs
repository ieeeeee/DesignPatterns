using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interpreter
{
    /// <summary>
    /// 表达，解析的规则,除了a-i，其他都是零
    /// </summary>
    public class ZeroExpression:BaseExpression
    {
        private static Dictionary<string, string> transDic = new Dictionary<string, string>();
        static ZeroExpression()
        {
            transDic.Add("1", "1");
            transDic.Add("2", "2");
            transDic.Add("3", "3");
            transDic.Add("4", "4");
            transDic.Add("5", "5");
            transDic.Add("6", "6");
            transDic.Add("7", "7");
            transDic.Add("8", "8");
            transDic.Add("9", "9");
        }
        public override string Transcate(string word)
        {
            if (transDic.ContainsKey(word))
                return transDic[word];
            else
                return "0";
        }

        public override void TranscateContext(Context context)
        {
            List<string> sourceTextList = context.SourceText.ToCharArray().Select(w => w.ToString()).ToList();//就是把上下文里面的SourceText按照每个字符转换成一个list的元素

            List<string> result = new List<string>();
            foreach (string word in sourceTextList)
            {
                result.Add(Transcate(word));
            }
            context.SourceText = string.Concat(result);//连接成一个字符串
        }
    }
}
