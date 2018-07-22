using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Memento
{
    public class War3
    {

        public War3(string race, string hero, string army, string resource)
        {
            this.Race=race;
            this.Hero = hero;
            this.Army = army;
            this.Resource = resource;

        }

        /// <summary>
        /// 种族
        /// </summary>
        public string Race { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string Hero { get; set; }
        /// <summary>
        /// 兵力
        /// </summary>
        public string Army { get; set; }
        /// <summary>
        /// 资源
        /// </summary>
        public string Resource { get; set; }
        public void Show()
        {
            Console.WriteLine("当前种族为 {0}", this.Race);
            Console.WriteLine("当前英雄状况为 {0}", this.Hero);
            Console.WriteLine("当前兵力状况为 {0}", this.Army);
            Console.WriteLine("当前资源状况为 {0}", this.Resource);
        }
    }
}
