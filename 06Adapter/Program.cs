using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 适配器 上端是确定的，上端和下端不匹配，需要适配器去适配（转换），统一风格
/// 后期维护或者后期扩展时候用，兼容
/// 不和谐的东西一直在，只是被适配器覆盖了，缺陷是：有的东西可能会被适配器覆盖
/// 结构
/// </summary>
namespace _06Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ISqlHelper sqlHelper = new SqlServerHelper();
            sqlHelper.Add();
            sqlHelper.Delete();
            sqlHelper.Update();
            sqlHelper.Search();


            ISqlHelper mysqlHelper = new MySqlHelper();
            mysqlHelper.Add();
            mysqlHelper.Delete();
            mysqlHelper.Update();
            mysqlHelper.Search();

            //myLucene 没有update,这个接口又需要实现update ，就需要用适配器
            ISqlHelper myLuceneAdapter = new MyLuceneAdapter();
            myLuceneAdapter.Add();
            myLuceneAdapter.Delete();
            myLuceneAdapter.Search();
            myLuceneAdapter.Update();

            /**/
            NokiaPhone nokia = new NokiaPhone();
            SmartPhone smart = new SmartPhone();
            smart.Call();
            smart.VideoChat();

            PhoneAdapter nokiaAdapter = new PhoneAdapter(nokia);
            nokiaAdapter.Call();
            nokiaAdapter.VideoChat();

            PhoneAdapter smartAdapter = new PhoneAdapter(smart);
            smartAdapter.Call();
            smartAdapter.VideoChat(); /* 缺陷：smartphone 的方法被适配器覆盖了*/


            Console.Read();
        }
    }
}
