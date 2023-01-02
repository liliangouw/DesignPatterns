using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    internal interface Subject
    {
        public string SubjectState { get; set; }
        //通知
        public void Notify();

    }
}
