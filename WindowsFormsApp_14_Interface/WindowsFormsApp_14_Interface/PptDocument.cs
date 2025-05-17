using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_14_Interface
{
    internal class PptDocument : IReadable
    {
        public void Read()
        {
            Console.WriteLine("PPT 문서를 읽고 있습니다.");
        }
    }
}
