/**************************
 * 작성일 : 2025-04-29
 * 문자열 내장 메서드 & 실습
 **************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; //
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_04_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 문자열 내장 메서드
            //  ㄴ string 타입(문자열)이 기본적으로 가지고 있는 기능(메서드)

            //  문자열도 string 타입이라는 클래스이기 때문에,
            //  .을 찍고 string클래스에 내장된 다양한 기능(메서드)을 사용할 수 있다.

            // Ex1)
            string[] a = "1 2 3".Split(' ');
            //공백(스페이스)를 기준으로 잘라서 문자열 배열로 반환

            //Ex2)
            string on = "on";
            on.Replace("on","off"); // on을 off로 바꿔서 반환

            //Ex3)
            string q = "string 5";
            string[] parsed = q.Split(' '); // [string, 5]
                                            // 공백으로 잘라서 문자열 배열로 반환
                                            // 배열 인덱스 0번 요소 : string
                                            // 배열 인덱스 1번 요소 : 5


            // 실습 문제)
            #region 실습. 문자열 및 배열 문제
            /*
             실습. 문자열 및 배열

             • 문자열 관련 함수의 사용법을 직접 검색하여 아래 기능을 작성
              1. 10칸 크기의 문자열 배열을 생성
              2. 배열의 각 요소에 문자열 관련 함수를 하나씩 적용하여 결과값을 저장
                 1. IndexOf(): "동해 물과 백두산이" 에서 "백두산"의 검색 결과를 저장
                 2. LastIndexOf(): "토요일에 먹는 토마토" 에서 "토"를 검색하여 결과를 저장
                 3. Contains(): "질서 있는 퇴장" 에서 "퇴"를 검색하여 결과를 저장
                 4. Replace(): "그 사람의 그림자는 그랬다."에서 "그"를 "이"로 변경
                 5. Insert(): "삼성 갤럭시" 에서 "삼성" 과 "갤럭시" 사이에 "애플"을 넣기
                 6. Remove(): "오늘은 왠지 더 배고프다" 에서 "더"를 삭제
                 7. Split(): "이름, 나이, 전화번호" 를 ","를 기준으로 분리하여 저장 (배열 3칸 소모)
                 8. SubString(): "우리 나라 만세" 에서 "나라" 만 꺼내서 저장
              3. 배열의 모든 요소를 TextBox에 출력
              4. 결과를 push 하고 Repo. 링크를 슬랙 댓글로 제출
             */
            #endregion

            // 1. 10칸 짜리 문자열 배열 생성
            string[] results = new string[10]; // [0,0,0,0,0,0,0,0,0,0]

            // 2. 문자열 함수 적용한 후, 배열에 할당.
            results[0] = "동해 물과 백두산이".IndexOf("백두산").ToString(); // 6
            results[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            results[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            results[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            results[4] = "삼성 갤럭시".Insert(2, "애플");
            results[5] = "오늘은 왠지 더 배고프다".Remove("오늘은 왠지 더 배고프다".IndexOf("더"), 1);

            // Split 사용
            string data = "이름, 나이, 전화번호";
            string[] splitData = data.Split(','); // [이름, 나이, 전화번호]

            // 배열 3칸에 각각 나눠서 저장
            results[6] = splitData[0].Trim();  // "이름"
            results[7] = splitData[1].Trim();  // " 나이"
            results[8] = splitData[2].Trim();  // " 전화번호"
            // Trim(): 문자열의 양쪽 끝에 있는 공백을 없애주는 함수.

            // 문자열.Substring(시작 위치, 가져올 개수)
            // 시작위치 : 어디서부터 자를지, 인덱스 지정 (0부터)
            // 가져올 개수 : 몇 글자를 가져올지 숫자로 지정
            string message = "우리 나라 만세";

            // "나라" 꺼내야함.
            string sub = message.Substring(3, 2);
            results[9] = sub;

            textBox1.Text = results[0] + "\r\n";
            textBox1.Text += results[1] + "\r\n";
            textBox1.Text += results[2] + "\r\n";
            textBox1.Text += results[3] + "\r\n";
            textBox1.Text += results[4] + "\r\n";
            textBox1.Text += results[5] + "\r\n";
            textBox1.Text += results[6] + "\r\n";
            textBox1.Text += results[7] + "\r\n";
            textBox1.Text += results[8] + "\r\n";
            textBox1.Text += results[9] + "\r\n";

            // 실습) 문자열 & 배열 3
            /* 
             Q3) 과일 가게 주문 정보 정리하기.

                손님 주문서   
                손님 이름   |        주문 상품   
                 홍길동     |   포도, 복숭아, 바나나
                 아무개     |   사과, 수박, 오렌지
                 손오공     |   바나나, 사과, 오렌지

            1. 위, 주문 정보를 2차원에 배열에 저장.(항목명은 제외)

            2. 각 손님의 주문 상품 중에 "바나나"를 주문한 경우,
            • "바나나"→ "바나나 (유기농)"으로 변경.
            • 상품 이름 중 2글자가 넘는 상품 이름만 상품 이름 뒤에 (인기) 붙히기.
            • "수박" 이라는 글자가 들어간 상품은 "씨없는 수박"으로 변경.
            • 모든 상품을 출력할 때 상품 이름 첫 글자만 뽑아서 보여주는 문자열도 같이 출력.
             */

            #region textBox에 최종 출력 예시
            /*
             홍길동: 포도 / 복숭아 (인기) / 바나나 (유기농)
             상품 첫 글자 요약: 포 / 복 / 바

             아무개: 사과 / 씨없는 수박 / 오렌지 (인기)
             상품 첫 글자 요약: 사 / 씨 / 오

             손오공: 바나나 (유기농) / 사과 / 오렌지 (인기)
             상품 첫 글자 요약: 바 / 사 / 오
             */
            #endregion

            string[,] orders = new string[,] {
                { "홍길동", "포도", "복숭아", "바나나" },
                { "아무개", "사과", "수박", "오렌지" },
                { "손오공", "바나나", "사과", "오렌지" }
            };

            // 1. 2차원 배열 준비 (3명, 4개 항목: 이름 + 과일3개)
            //string[,] orders = new string[3, 4];

            //// 2. 데이터 저장
            //orders[0, 0] = "홍길동"; orders[0, 1] = "포도"; orders[0, 2] = "복숭아"; orders[0, 3] = "바나나";
            //orders[1, 0] = "아무개"; orders[1, 1] = "사과"; orders[1, 2] = "수박"; orders[1, 3] = "오렌지";
            //orders[2, 0] = "손오공"; orders[2, 1] = "바나나"; orders[2, 2] = "사과"; orders[2, 3] = "오렌지";

            // 3. 문자열 내장 메서드 적용
            orders[0, 1] = (orders[0, 1].Length > 2) ? orders[0, 1] + " (인기)" : orders[0, 1];
            orders[0, 2] = (orders[0, 2].Length > 2) ? orders[0, 2] + " (인기)" : orders[0, 2];
            orders[0, 3] = orders[0, 3].Replace("바나나", "바나나 (유기농)");

            orders[1, 1] = orders[1, 1];
            orders[1, 2] = orders[1, 2].Contains("수박") ? "씨없는 수박" : orders[1, 2];
            orders[1, 3] = (orders[1, 3].Length > 2) ? orders[1, 3] + " (인기)" : orders[1, 3];

            orders[2, 1] = orders[2, 1].Replace("바나나", "바나나 (유기농)");
            orders[2, 2] = orders[2, 2];
            orders[2, 3] = (orders[2, 3].Length > 2) ? orders[2, 3] + " (인기)" : orders[2, 3];

            // 4. TextBox에 출력
            textBox_print.Text = "";

            textBox_print.Text += orders[0, 0] + ": " + orders[0, 1] + " / " + orders[0, 2] + " / " + orders[0, 3] + "\r\n";
            textBox_print.Text += "상품 첫 글자 요약: " +
                orders[0, 1].Substring(0, 1) + " / " +
                orders[0, 2].Substring(0, 1) + " / " +
                orders[0, 3].Substring(0, 1) + "\r\n\r\n";

            textBox_print.Text += orders[1, 0] + ": " + orders[1, 1] + " / " + orders[1, 2] + " / " + orders[1, 3] + "\r\n";
            textBox_print.Text += "상품 첫 글자 요약: " +
                orders[1, 1].Substring(0, 1) + " / " +
                orders[1, 2].Substring(0, 1) + " / " +
                orders[1, 3].Substring(0, 1) + "\r\n\r\n";

            textBox_print.Text += orders[2, 0] + ": " + orders[2, 1] + " / " + orders[2, 2] + " / " + orders[2, 3] + "\r\n";
            textBox_print.Text += "상품 첫 글자 요약: " +
                orders[2, 1].Substring(0, 1) + " / " +
                orders[2, 2].Substring(0, 1) + " / " +
                orders[2, 3].Substring(0, 1) + "\r\n";

        }
    }
}
