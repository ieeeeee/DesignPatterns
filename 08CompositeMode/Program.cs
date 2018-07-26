using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 组合模式
/// </summary>
namespace _08CompositeMode
{
    /// <summary>
    /// 组合模式：以前是一次性描述一个整体，一个复杂的对象，由于层级是无限的，根本无法描述
    /// 组合模式是对重复点的抽取，将整个对象化整为零，分层描述，
    /// 满足组合模式时，就可以使用递归查找
    /// 节点+递归就是整个对象，只有树形结构才用得上组合模式
    /// </summary>
    class Program
    {
        //递归 
        /// <summary>
        /// 找出文件夹里面所有的文件
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="fileList"></param>
        /// <returns></returns>
        private static void GetChildFileList(DirectoryInfo dir,List<FileInfo> fileList)
        {
            fileList.AddRange(dir.GetFiles());//找出该文件夹下面的所有文件
            List<DirectoryInfo> dirList = dir.GetDirectories().ToList();//找出该文件夹下面的所有文件夹
            //遍历每个子文件夹
            foreach(DirectoryInfo dirChild in dirList)
            {
                GetChildFileList(dirChild, fileList);
            }

        }
        static void Main(string[] args)
        {
            //为了得到项目的所有文件，但文件夹下还有很多文件夹，文件夹下还有文件夹，是个很复杂的对象，可用递归
            //也可升级，就是文件夹类，里面还有文件夹，文件list

            /*01*/
            //复杂对象   容器对象
            MyProject myProject = new MyProject()
            {
                DirectoryList = new List<MyDirectory>()
                {
                    new MyDirectory()
                    {
                        Name="bin"
                    },
                    new MyDirectory()
                    {
                        Name="obj"
                    },
                    new MyDirectory()
                    {
                        Name="Properties"
                    }
                },
                FileList = new List<MyFile>()
                {
                    new MyFile()
                    {
                        Name="App.config"
                    },
                }
            };

            /*02 运用递归*/
            DirectoryInfo rootDirec = new DirectoryInfo(@"F:\GitRepo\DesignPatterns\DesignPatterns\Design");
            List<FileInfo> fileList = new List<FileInfo>();
           
            GetChildFileList(rootDirec, fileList);
            Console.WriteLine("一共是{0}个", fileList.Count());

            /*03 运用组合模式*/
            /*每次都是展开一个文件夹，获取文件,我们抽象出节点*/

            MyNode myNode = new MyNode()
            {
                Path = @"F:\GitRepo\DesignPatterns\DesignPatterns\Design"
            };
            List<MyNode> nlist=myNode.GetMyDirecList();

            Console.Read();
        }
    }
}
