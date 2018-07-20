using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 桥接模式
/// </summary>
namespace _07Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*01*/
            //当我们需要一个手机的时候，不是加手机，看到两个手机类有很多相似之处时候，我们就要去抽象
            //抽象有两种方式，一是接口，二是抽象类，继承抽象类override实现抽象方法

            //BasePhone apple = new Apple();
            //apple.Call();
            //apple.Message();
            //Console.WriteLine(apple.System());

            //BasePhone sumsong = new Sumsong();
            //sumsong.Call();
            //sumsong.Message();
            //Console.WriteLine(apple.System());



            /*02*/
            /*当我们需要刷机，将ios刷成android  android刷机成apple*/
            //BasePhone appleAndroid = new AppleAndroid();
            //appleAndroid.Call();
            //appleAndroid.Message();
            //Console.WriteLine(appleAndroid.System());

            //BasePhone sumsongIOS = new SumsongIOS();
            //sumsongIOS.Call();
            //sumsongIOS.Message();
            //Console.WriteLine(sumsongIOS.System());

            /*以上我们为了刷机，又增加了两个类，当我们在增加一个手机，又增加一个系统时候，又会增加5个类，总共九个类，手机类型*手机操作系统 */
            /*然后我们为了得到appleAndroid 就加一个类继承ios的系统，这种继承就写死了，从上往下继承*/
            /*这时候我们就需要桥接模式，我们就把变化点抽象出来组合到类里去，比如apple 类ios ,appleAndroid类写android */
            /*用了桥接，进行组合，apple类就只组合抽象的system接口，这个接口再去连接很多个操作系统  */
            /*比如手机运营商 也可以桥接，要不然加一个运营商，每种手机都要再新建一个类去匹配这个运营商 */

            /*有两个变化因素：手机类型，手机操作系统,那我们就需要把变化因素抽象出去 */
            /*操作系统是一个变化因素，于是我们就不再将操作系统放在手机类中，应该抽象出来*/
            /*桥接模式：实现m*n 这种变化因数，避免代码爆炸*/
            /*03*/
            BasePhone apple1 = new Apple();
            apple1.CurrentSystem = new AndroidSystem();
            apple1.Call();
            apple1.Message();


            BasePhone sumsong1 = new Sumsong();
            sumsong1.CurrentSystem = new IOSSystem();
            sumsong1.Call();
            sumsong1.Message();



            Console.Read();
        }
    }
}
