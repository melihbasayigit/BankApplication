using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    internal class repList
    {
        public int repCount;
        public int repID;
        public repList(int a,int v)
        {
            repCount = a;
            repID = v;
        }

        public int returnRepID()
        {
            return repID;
        }

    }

    internal class deadlockItem
    {
        public int recNum;
        public int from;
        public int to;
        public string type;

        public deadlockItem()
        {

        }

        public deadlockItem(int recNum, int from, int to, string type)
        {
            this.recNum = recNum;
            this.from = from;
            this.to = to;
            this.type = type;
        }

        public deadlockItem(deadlockItem a)
        {
            recNum = a.recNum;
            from = a.from;
            to = a.to;
            type = a.type;
        }

    }

    internal class intString
    {
        public int a;
        public string s;

        public intString(int a, string s)
        {
            this.a = a;
            this.s = s;
        }

        public intString() {}

        public intString(intString item)
        {
            a = item.a;
            s = item.s;
        }

    }




}
