/*
 작성일 : 2025-04-28
 1,2,3차원 배열 & 재그드 배열
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_03_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /* ● 배열(Array)
               같은 자료형 변수 여러개를 하나의 배열로 처리.
                ㄴ 한 번에 여러 값을 저장할 수 있음.
               
               ○ 배열을 사용하는 이유
                int num1, num2, num3, num4 , ... 
                이렇게 다 변수로 만들어서 저장해서 쓰려고 하면 너무 힘들기 때문에..
                
                -> 그래서 배열을 만들어서 사용한다
            */


            // ○ 배열 예시
            int[] nums = new int[8]; // 정수형 8개를 저장할 수 있는 8칸의 배열 선언함

            /* 구조
                배열의 이름 : nums
                배열의 자료형 : int[] -> 정수형의 1차원 배열
                배열 선언 및 메모리 공간 확보 : nums = new int[8]
                 ㄴ 정수형으로 8개 짜리 공간을 만듦
             */

            // ○ 배열 안에 있는 데이터 하나 하나를 **배열의 요소(또는 배열의 아이템)**이라고 말함
            // ○ 배열의 위치(인덱스) : 배열의 인덱스는 0부터 시작한다(컴퓨터에서 숫자는 0부터 셈)
            // ○ 배열의 길이(크기) : 배열의 요소의 개수와 동일하다.

            // ○ 동적 배열 선언(입력되는 데이터의 크기를 알 수 없을 때 사용)
            // 배열의 크기를 변수로 지정하여 선언함
            // 입력되는 데이터 개수가 유동적일 때, 런타임(프로그램 실행 시점)에서 결정된 크기를 사용할 수 있음
            int inputCount = 10;
            int[] inputData = new int[inputCount]; // 배열의 크기를 "변수"로 지정하여 선언
            // 입력되는 크기를 알 수가 없어서 배열 생성시, 배열의 크기값에 변수를 넣음
            // 배열의 크기를 런타임(실행) 시점에 변수로 지정하여 선언함
            // 미리 입력될 데이터의 개수를 정확히 모를 경우, 변수를 통해 배열 크기를 지정할 수 있음
            // 단, 배열은 한 번 크기가 정해지면 변경할 수 없음
            // 배열의 크기를 런타임(실행)시점에 결정함, 한 번 정하면 변경 불가.
            // 즉, 배열의 크기를 런타임(실행) 시점에 결정하지만, 결정 후에는 고정됨

            inputData[0] = 20; // 배열의 인덱스 0번 위치에 20 저장
            // inputData배열 상태 : [20,0,0,0,0,0,0,0,0,0]
            // 배열의 인덱스는 0부터 시작하며, 각 요소에 접근하거나 값을 설정할 수 있음

            
            int oneOfData = inputData[0]; // oneOfData 변수에 inputData[0]의 값 20이 복사되어 저장됨 
            // 값 타입(int)은 '복사'되는 것이므로, 이후의 코드에서 inputData[0]을 바꿔도 oneOfData에는 영향 없음

            // ○ 1차원 배열의 할당 및 초기화
            int[] array1 = new int[5]; // [0,0,0,0,0] int형 5칸짜리 배열 선언
            int[] array2 = { 1, 2, 3, 4, 5, 6 }; // new int[6]과 유사

            //-----------------------------------------------------

            /* ● 2차원 배열 (행과 열로 구성)
                ㄴ 배열 안에 배열이 들어갈 수 있다(n 중첩 가능)

                [,] 배열의 모양을 미리 정하는 표시라고 이해하기
                    ㄴ 중첩이 되면 배열의 모양을 []안에 ,(쉼표)로 나눔
                
                []    1차원 배열
                [,]   2차원 배열
                [,,]  3차원 배열
                [,,,] 4차원 배열 
                이런 식으로 []안의 ,로 구분됨

                {}안에는 배열에 들어갈 실제 값을 넣으면 된다.
             */

            int[,] multiArray1 = new int[2, 3]; // 2행 3열의 배열 선언
            int[,] multiArray2 =
                                    {
                                        { 1,2,3 },
                                        { 4,5,6 }
                                    }; // new int[2,3];과 유사함
            // 2행 3열의 2차원 배열을 선언과 동시에 초기화 한 것

            // ○ 2차원 배열의 요소 접근
            string[,] korean = new string[,] {
                { "가","나","다" },
                { "라","마","바" },
                { "사","아","자" }
            }; // 3행 3열의 2차원 배열 선언 & 초기화

            textBox1.Text = korean[0, 0]; // 가
            textBox1.Text = korean[0, 2]; // 다
            textBox1.Text = korean[1, 1]; // 마

            // 반짝 실습
            // Quiz 1) "가자" 글씨 출력해보기
            textBox1.Text = korean[0, 0] + korean[2,2]; // 가자

            // Quiz 2) 3차원 배열에서 숫자 8 출력
            int[,,] num = new int[,,] {
                {
                    { 1,2,3 },
                    { 4,5,6 }
                },
                {
                    { 7,8,9 },
                    { 10,11,12 }
                }
            }; // 2쪽 2행 3열의 3차원 배열

            textBox1.Text = num[1,0,1].ToString(); // 8


            /*재그드(jagged) 배열(배열의 배열)
                들쭉날쭉한 배열(행마다 열 길이가 다름)
                [][] 중첩된 대괄효 사용
                첫 번째 [] : 바깥쪽 배열
                두 번째 [] : 안쪽 배열
             */

            int[][] jaggedArray = new int[6][];
            // 행은 6으로 고정, 열의 길이는 자유
            // 열은 행마다 들쭉 날쭉하게 들어갈 수 있다

            jaggedArray[0] = new int[4] { 1, 2, 3, 4 }; // 인덱스 0행에 4개의 데이터 저장
            jaggedArray[1] = new int[3] { 1, 2, 3 }; // 인덱스 1행에 3개의 데이터 저장



            //------------------------------------------------------
            // 재그드 배열 실습
            // 1. 각 반 마다 학생 수가 다를 때,
            // 재그드 배열을 활용하여 학생 이름 저장하고 출력하기
            // 반(줄) 만들기
            // 총 3개 반을 만듬
            // 1반 2명, 2반 3명, 3반 1명

            string[][] schoolClass = new string[3][];

            // 2. 학생 이름 넣기(각 반마다 다르게)
            schoolClass[0] = new string[2] { "가나다", "나다라" };
            schoolClass[1] = new string[3] { "홍길동", "임꺽정", "성춘향" };
            schoolClass[2] = new string[1] { "안눙이" };

            // 3. 학생 이름 출력하기
            // 모든 반, 모든 학생 이름을 textBox_print에 차례로 출력
            // 출력 예시
            // 1반 학생 목록:
            // - oo
            // - oo

            textBox1.Text += "1반 학생 목록 : \r\n";
            textBox1.Text += " - " + schoolClass[0][0] + "\r\n";
            textBox1.Text += " - " + schoolClass[0][1] + "\r\n";
            textBox1.Text += "2반 학생 목록 : \r\n";
            textBox1.Text += " - " + schoolClass[1][0] + "\r\n";
            textBox1.Text += " - " + schoolClass[1][1] + "\r\n";
            textBox1.Text += " - " + schoolClass[1][2] + "\r\n";
            textBox1.Text += "3반 학생 목록 : \r\n";
            textBox1.Text += " - " + schoolClass[2][0] + "\r\n";
        }
    }
}

/* 실습 3번 문제 풀이)
 
 // 실습3번) 종합문제
string productName = "노트북";
int price = 1200000;
float discountRate = 0.15f;
byte stock = 8;
bool isAvailable = stock > 0;

// 할인된 가격
double discountedPrice = price * (1 - discountRate);

textBox1.Text = isAvailable ? "구매 가능: 할인 가격은 " +
    discountedPrice.ToString("N0") + "원입니다." : "품절되었습니다.";

textBox2.Text = (stock >= 5) ? "여유 있음" : "소량 남음";

textBox3.Text = "상품명: " + productName
    + ", 할인된 가격: " + discountedPrice.ToString("N0") + "원"
    + ", 재고: " + stock.ToString() + "개";

// # 소수점 포맷 설정
// - 포맷 조정은 "출력용" 변환이다. (계산 자체가 바뀌진 X)
// "N0"     - 천 단위 구분 쉼표(,) 찍어주는 서식.
// "P1'     - 퍼센트로 변환해서 소수 첫째 자리까지.
// "0"      - 자리 수 채움 (0으로 채움)
// "0.0"    - 소수점 첫째 자리까지, 없으면 0 채움
// "0.00"   - 소수점 둘째 자리까지, 없으면 0 채움
// "0.###"  - 소수점 세 자리까지, 있으면 표시, 없으면 표시 안함.
// "N2"     - 쉼표 + 소수 둘째자리까지.
 
 
 */
