using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CompositeMode
{
    /// <summary>
    /// 我的项目下有多个文件夹，多个文件
    /// </summary>
    class MyProject
    {
       public List<MyDirectory> DirectoryList { get; set; }

       public  List<MyFile> FileList { get; set; }
    }
}
