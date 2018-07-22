using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interpreter
{
    public class OtherExpression:BaseExpression
    {
        private static Dictionary<string, string> transDic = new Dictionary<string, string>();
        static OtherExpression()
        {
            transDic.Add("a", "1");
            transDic.Add("b", "2");
            transDic.Add("c", "3");
            transDic.Add("d", "4");
            transDic.Add("e", "5");
            transDic.Add("f", "6");
            transDic.Add("g", "7");
            transDic.Add("h", "8");
            transDic.Add("i", "9");
        }

        public override string Transcate(string word)
        {
            if (transDic.ContainsKey(word))
                return transDic[word];
            else
                return word;
        }

        public override void TranscateContext(Context context)
        {
            //就是把上下文里面的源字符串转换成一个字符集合
            List<string> sourceTextList = context.SourceText.ToCharArray().Select(w => w.ToString()).ToList();
            List<string> result = new List<string>();
            foreach(string word in sourceTextList)
            {
                result.Add(Transcate(word));
            }
            context.SourceText = string.Concat(result);
        }
    }
}
