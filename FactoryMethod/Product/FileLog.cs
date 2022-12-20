using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class FileLog : AbstractLog
    {

        public override void WriteLog()
        {
            Console.WriteLine("写入文件日志");
        }
    }
}
