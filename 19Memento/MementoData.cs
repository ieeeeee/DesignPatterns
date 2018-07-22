using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Memento
{
    /// <summary>
    /// 单次恢复
    /// </summary>
    public class MementoData
    {
        private War3 WAR3 = null;
        public  MementoData(War3 war3)
        {
            this.WAR3 = war3;
        }
        public War3 Recover()
        {
            return WAR3;
        }
    }

    /// <summary>
    /// 多次恢复
    /// </summary>
    public class MementoList
    {
        private Dictionary<string, War3> DictionaryWar3 = new Dictionary<string, War3>();
        public bool Save(string name,War3 war3)
        {
            if(DictionaryWar3.ContainsKey(name))
            {
                return false;
            }
            DictionaryWar3.Add(name, war3);
            return true;
        }

        public War3 Recover(string name)
        {
            if(DictionaryWar3.ContainsKey(name))
            {
                return DictionaryWar3[name];
            }
            else
            {
                return null;
            }
        }
    }

    /// <summary>
    /// 就是来与上端调用存档与恢复存档的
    /// </summary>
    public class Manager
    {
        private MementoList Memento = null;
        public Manager()
        {
            Memento = new MementoList();
        }
        public bool Save(string name,War3 war3)
        {
            return Memento.Save(name, war3);
        }
        public War3 Recover(string name)
        {
            return Memento.Recover(name);
        }
    }
}
