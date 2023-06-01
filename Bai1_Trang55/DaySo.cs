using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Trang55
{
    internal class DaySo
    {
        public int n=0;
        private long tong;
        public List<int> daySo = new List<int>();

        public void taoDaySo()
        {
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                daySo.Add(rd.Next(0, 100));  // sinh số từ 0 -> 100
            }
        }

        public string tinhTong()
        {
            tong = 0;
            for (int i = 0; i < daySo.Count; i++)
            {
                tong += daySo[i];
            }
            return ("Tổng = " + tong.ToString());
        }

        public string inDaySo(string message)
        {
            string str = message;
            for (int i = 0; i < daySo.Count; i++)
            {
                str += "   " + daySo[i];
            }
            return str;
        }

        public string sapXepGiam()
        {
            QuickSort.quickSort(daySo, 0, daySo.Count - 1);
            QuickSort.quickSort(daySo, 0, daySo.Count - 1);

            string str = inDaySo("Dãy số đã sắp xếp giảm dần:");
            return str;
        }
    }
}
