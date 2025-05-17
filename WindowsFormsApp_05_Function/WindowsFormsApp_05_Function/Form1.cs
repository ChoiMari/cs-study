/*****************************
 작성일 : 2025-04-29
    함수, 메서드
 *****************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_Function
{

    public partial class Form1 : Form
    {
        // 함수
        //  - 특정 작업을 수행하기 위해 독립적으로 설계된 코드 집합.

        int Add(int x, int y)
        {
            return x + y;
        }
        // 구조
        //  - int (자료형) : 이 함수가 돌려줄 값(return 값)의 타입
        //  - Add : 함수명(C#에서는 파스칼 표기가 관례)
        //  - int x, int y : 파라미터
        //      ㄴ 함수 선언 시 함수가 받아야 하는 입력 값(=매개 변수)들
        //      ㄴ 함수에 전달되는 외부 데이터(외부에서 호출 할 때 넣어주는 값)
        //  - {} : Scope(유효 범위), 코드 실행 범위

        // 용어 정리
        //  - 함수 정의(선언) : 함수를 생성
        //  - 함수 호출 : 함수를 사용

        // return 반환값
        // 함수 내부 코드의 최종 결과 값
        // 함수 본문에서 최종 결과를 저장하고 호출한 곳으로 돌려주는 키워드
        // return 키워드를 만나면 함수 실행이 종료됨
        // (-> 그래서 return 키워드 밑에 작성하는 코드는 의미가 없다. 어차피 실행 안되기 때문에)

        // return 값이 없는 함수
        // void
        // - 반환 값이 없을 때 사용하는 키워드
        void Nothing() { 
            textBox1.Text += "Nothing";
        }

        public Form1() // 생성자(Form1 객체가 만들어질 때 호출되며 실행)
        {
            InitializeComponent();

            int num = 200;
            int result = Add(100, num);

            textBox1.Text = result.ToString();
            Nothing(); // 함수 사용(호출)

            /*
             • 아래 내용을 참고하여 적당한 이름의 함수를 구현
                    1. int 형 숫자 두 개를 입력 받기
                    2. 첫 번째 입력 값을 두 번째 입력 값으로 나눔
                    3. 나눠진 값은 배열의 첫 번째 요소에 저장
                    4. 나머지 값은 배열의 두 번째 요소에 저장
                        • 나머지 연산은 %를 이용 (필요시 검색)
                    5. 위 배열을 반환
                1. Form1()에서 위 함수를 사용하고 TextBox에 결과 값을 출력
                2. 결과를 push 하고 Repo. 링크를 슬랙 댓글로 제출
             
             */

            int[] result2 = Divide(9, 2);//함수 호출

            //TextBox에 출력
            textBox1.Text = "몫 : " + result2[0].ToString() + "\r\n";
            textBox1.Text += "나머지 : " + result2[1].ToString() + "\r\n";

        }

        // 실습. 함수
        // int형 숫자 두 개를 입력 받기
        public int[] Divide(int x, int y)
        {

            int[] result = new int[2];
            // 첫 번째 입력 값을 두 번째 입력 값으로 나눔
            // 나눠진 값은 배열의 첫 번째 요소에 저장
            result[0] = x / y; // 정수끼리 계산 = 정수로 나옴
            // 나머지 값은 배열의 두 번째 요소에 저장(%연산자 이용)
            result[1] = x % y;

            // 계산 된 배열을 반환
            return result;
        }
    }
} 
