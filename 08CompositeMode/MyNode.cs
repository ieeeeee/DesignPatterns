using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CompositeMode
{
    /// <summary>
    /// 节点,每个文件夹都当做每个节点，进行每个节点的展开操作
    /// </summary>
    public class MyNode
    {
        public string Path { get; set; }

        public List<MyFile> MyFileList { get; set; }
        public List<MyNode> GetMyDirecList()
        {
            return null;
        }
    }
}
