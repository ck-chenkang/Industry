using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 获取库句柄 ( Ethernet ) 并进行连接
            ushort Flibhndl = 0;
            short ret = Focas1.cnc_allclibhndl3("10.178.67.13", 8193, 10, out Flibhndl);
            if (ret != Focas1.EW_OK)
            {
                Console.WriteLine("发生异常，请检查！");
                return;
            }

            #region cnc_machine

            Focas1.ODBAXIS odbaxis = new Focas1.ODBAXIS();            
            for (short i = 0; i < 3; i++)
            {
                ret = Focas1.cnc_machine(Flibhndl, (short)(i + 1), 8, odbaxis);
                Console.WriteLine(odbaxis.data[0]*Math.Pow(10,-4));
            }
            #endregion
            Console.Write("read values");
            Console.Read();
        }
    }

}
