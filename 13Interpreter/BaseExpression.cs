using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interpreter
{
    public abstract class BaseExpression
    {
     
        public abstract string Transcate(string word);
        public abstract void TranscateContext(Context context);
    }
}
