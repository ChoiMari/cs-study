/**********************************
 * 작성일 : 2025-05-13
 * 인터페이스, 다형성
***********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_14_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 다형성이란?
            //  ㄴ 하나의 인터페이스로 여러 개의 서로 다른 객체를 동일하게 다루는 것.

            // 다형성을 적용하지 않은 예
            Document doc = new Document();
            doc.Read();
            doc.Write();
            doc.Print();

            // 인터페이스 타입으로 사용
            IReadable reader = new Document();
            IWritable writer = new Document();
            IPrintable printer = new Document();

            // 이렇게 하면 각 기능별로 분리가 가능함
            // 해당 인터페이스에 정의된 기능만 사용할 수 있게 제한

            // 하나의 인터페이스 타입으로 다양한 객체를 만들어본다면?
            // 같은 인터페이스를 상속 받아서 구현한 모든 클래스의 객체들을
            // 해당 인터페이스 타입의 변수에 참조 할 수 있다.
            IReadable reader1 = new Document();
            IReadable reader2 = new PptDocument();
            IReadable reader3 = new PdfDocument();

            reader1.Read();
            reader2.Read();
            reader3.Read();
            // IReadable 인터페이스 타입으로
            // 서로 다른 클래스 객체를 동일하게 제어하면서, 동작은 다르게 나옴
            // 해당 인터페이스를 상속하는 각각의 클래스 객체마다 내부{} 구현이 다르기 때문에(오버라이드)
            // -> 다형성
        }
    }
}
