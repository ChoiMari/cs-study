/*
 스마트 팩토리 개발자 고급 과정
 작성일 : 2025-04-25
 WindowsFormApp의 기본 구조 파악
 */

// # 기본 구조 파악

// using 키워드: "네임스페이스"를 가져온다는 의미.
// ㄴ 네임스페이스(namespace)란?
//    ㄴ 여러 클래스들을 논리적으로 묶은 공간.

using System;
//ㄴ 가장 기본적인 .NET 네임스페이스. 
// ㄴ (Console, Math 등) 자주 쓰이는 클래스들이 포함되어 있음.

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
//ㄴ 문자열과 관련된 기능을 제공하는 네임스페이스

using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_01_Base // 프로젝트 이름.
{
    public partial class Form1 : Form //윈도우 폼(Form)을 상속한 사용자 정의 폼(Form1)
    // ㄴ Form1 이라는 이름의 클래스, Form 클래스를 상속받음.
    // ㄴ .NET에서 제공하는 기본 윈도우 창인 Form 클래스를 상속받아서, 윈도우 창의 기본 동작과 속성을 물려받음.
    // ㄴ partial : 이 클래스는 코드가 여러 파일로 나눠져 있음을 의미.
    {
        public Form1()  // Form1 클래스의 생성자.
        { //Program.cs에서 Main()메서드가 실행 될 때, new Form1()로 Form1클래스의 객체가 생성되고, 이때 Form1()의 생성자가 호출되어 실행됨
          //폼 클래스의 생성자, UI 구성 초기화 담당

            InitializeComponent();  // 폼의 컴포넌트들을 초기화
            // ㄴ 폼에 포함된 UI 요소들을 초기화하는 메서드 호출.
            // ㄴ 버튼, 텍스트박스 등 디자인 도구에서 만든 컨트롤들을 실제로 생성하고 속성 설정하는 코드들이 있음.
            // ㄴ 폼이 실행될 때, 꼭 호출되어야 윈도우 폼이 제대로 보임.
            // ㄴ 디자이너가 자동으로 생성한 UI 코드 불러오기(UI 초기화 메서드, 디자이너에서 자동 생성)
        }
        // 프로그램 실행을 하는 Main()메서드는 Program.cs파일에 있음
        // Program.cs 파일은 C# 윈도우폼 애플리케이션의 시작점
        // Main()메서드는 프로그램이 실행될 때 제일 먼저 실행되는 함수
    }
}
