using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_14_Interface
{
    // 인터페이스 선언

    /*
     - 인터페이스 왜 쓸까?
        1. 공통 기능을 강제하기 위해서.
        일종의 규칙, 계약, 약속이라고 할 수 있음
        인터페이스를 상속 받는다면
        반드시 이 메서드들을 구현하라는 약속.
        2. 다형성을 가능하게 하기 위해서 사용함.
        3. 유연한 구조 → 유지보수를 용이하게 하기 위해서

        인터페이스는 메서드만 선언함. 내부{} 구현은 하지 않는다    
     */
    public interface IReadable { // 인터페이스 작명은 맨 앞에 대문자 I를 붙여 짓는 것이 관례 
        void Read(); // 문서를 읽는 기능
    }

    public interface IWritable
    {
        void Write(); // 문서를 쓰는 기능
    }

    public interface IPrintable { 
        void Print(); // 문서를 인쇄하는 기능
    }

    /*
     인터페이스 3개 다중 상속받음
     처음 상속받는다고 하면 오류..
     메서드 오버라이드하면 오류 없어짐
     인터페이스 자체가 public(외부에서 접근 가능)이기 때문에
     public으로 오버라이드    
     */
    public class Document : IReadable, IWritable, IPrintable
    {
        public void Print()
        {
            Console.WriteLine("문서를 프린터로 출력합니다.");
        }

        public void Read()
        {
            Console.WriteLine("문서를 읽고 있습니다.");
        }

        public void Write()
        {
            Console.WriteLine("문서에 내용을 쓰고 있습니다.");
        }
    }
}
