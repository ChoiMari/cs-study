/*
 작성일 : 2025-04-25
 변수 & 연산자, 실습 풀이
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

namespace WindowsFormsApp_02_Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //변수의 선언
            int numOfCrew;

            //변수의 사용(초기화 : 변수에 값을 **처음** 할당하는 것)
            numOfCrew = 19;

            // 변수의 선언 & 초기화
            string className = "말하기";

            //변수의 값 덮어쓰기
            className = "수학";

            //선언보다 밑에 줄에서 사용 가능
            //linecount = 10;(x)
            int lineCount;

            //같은 이름 사용 불가(선언시 변수이름 중복 불가)
            byte buffer;
            // float buffer; // (x) 같은 이름 사용 불가

            //데이터 타입이 완전히 다르면 복사 불가
            int number = 10;
            string word = "안녕";

            // number = word; // (x) int형과 string형은 서로 다른 타입이므로 복사 불가

            // 같은 형식에서 데이터 타입의 크기에 따라 복사 가능 or 불가능
            short word2 = 20;

            // int > short 더 큰 범위의 데이터 타입.
            number = word2; // (o) short형과 int형은 서로 다른 타입이지만, int형이 더 큰 범위의 데이터 타입이므로 복사 가능
            // 자료형이 다르지만, 복사 가능한 경우
            //int가 short보다 더 큰 범위의 데이터 타입이라서
            // 데이터 타입에 따라서 가능할 수도 있고 불가 할 수 도 있음
            // 자료형 범위가 더 큰범위에서만 적용가능
            // 변수끼리 값 복사 가능

            // 변수끼리 값 복사 (o)
            int varX = 10;
            int varY = varX; // varX의 값을 varY에 복사

            //사칙 연산 및 괄호 활용
            int varZ = varX * varY;
            int result = varZ + (varX + 5);

            //Scope가 다르면 사용이 불가능(X)
            {
                int inside = 100; // 이 위치에서 생성 되었다가 }끝나면 사라짐
            }

            //inside와 Scope가(유효범위)가 달라서 사용 불가
            // int outside = inside + 50;


            //출력
            textBox_print.Text += numOfCrew.GetType()
                    + "numOfCrew : " + numOfCrew.ToString() + "\r\n";



            // 실습 . 변수 및 캐스팅
            byte studentCount = 22;
            short deficit = -30000;
            int sumTotal = 1000000000;
            float pi = 3.14f;
            double rocketPressure = 0.384745892;
            decimal average = 81.3333333m;

            // 디자인 폼 텍스트 박스로 출력
            textBox_print.Text += studentCount.GetType()
                + "studentCount : " + studentCount.ToString() + "\r\n";

            textBox_print.Text += deficit.GetType()
                + "deficit : " + deficit.ToString() + "\r\n";

            textBox_print.Text += sumTotal.GetType()
                + "sumTotal : " + sumTotal.ToString() + "\r\n";

            textBox_print.Text += pi.GetType()
                + "pi : " + pi.ToString() + "\r\n";

            textBox_print.Text += rocketPressure.GetType()
                + "rocketPressure : " + rocketPressure.ToString() + "\r\n";

            textBox_print.Text += average.GetType()
                + "average : " + average.ToString() + "\r\n";

            //연산자
            /*
             * 대입 연산자 (=)
             * : 변수에 값을 "할당" 할 때 사용하는 연산자.
             * 
             * 산술 연산자
             * 사칙 연산 : +, -, /, *
             * 나머지 연산 : %
             * 거듭제곱 : Math.Pow() 메서드
             */

            //알아둘 사항
            int a = 5;
            int b = 2;

            //TextBox 컨트롤은 "사용자에게 텍스트(문자열)을 보여주기 위한 도구"
            //textBox_print.Text의 자료형이 string(문자열)임
            //textBox_print.Text = a; //-> 출력되지 않음
            //textBox_print.Text의 자료형이 string(문자열)이기 때문에
            //변환 해주어야한다

            textBox_print.Text = a.ToString();
            //ㄴ 숫자를 바로 넣을 수 없음

            //1) 형변환 방법(.ToString()사용)
            textBox_print.Text += (a + b).ToString() + "\r\n";

            //2) 문자열 보간 방법
            // $"{표현식}"형태
            // {}안에 있는 코드를 계산하고 자동으로 문자열로 만들어줌
            // 깔끔하고, 가독성이 좋아서 요즘 많이 사용되는 코드라고 함
            textBox_print.Text += $"a - b = {a - b} \r\n";
            textBox_print.Text += $"a / b = {a / b} \r\n";
            textBox_print.Text += $"a * b = {a * b} \r\n";
            textBox_print.Text += $"a % b = {a % b} \r\n";

            //파이썬에서는 거듭제곱 ** 사용

            // C#에서의 거듭제곱 :
            // C언어들에서는 문법적으로 거듭제곱을 표현하는 연산자가 존재하지 않는다
            // Math.Pow(밑, 지수)라는 메서드를 사용해야 함
            // Pow함수 결과는 항상 double로 반환됨(Pow()함수 리턴타입 double이란 소리)
            textBox_print.Text +=  $"a ^ b = {Math.Pow(a, b)} \r\n";

            //제곱근
            //Math.Sqrt(제곱근을 구할 숫자) : 제곱근을 구하는 메서드
            //리턴타입 double
            textBox_print.Text += $"{Math.Sqrt(9)} \r\n"; // 3

            //비교 연산자
            // 1. 동등 비교 : 같다(==), 같지 않다(!=)
            textBox_print.Text += $"{1 == 1} \r\n";
            textBox_print.Text += $"{1 == 2} \r\n";
            textBox_print.Text += $"{1 != 1} \r\n";
            textBox_print.Text += $"{1 != 2} \r\n";

            // 2. 크기 비교
            textBox_print.Text += $"{2 > 1} \r\n";
            textBox_print.Text += $"{2 >= 2} \r\n";
            textBox_print.Text += $"{2 < 1} \r\n";
            textBox_print.Text += $"{1 >= 1} \r\n";

            textBox_print.Text += $"----------------- \r\n";

            // 3. 논리 연산자
            // ! : not (참 -> 거짓, 거짓 -> 참)
            // && : and (여러 값 중 모두가 참 -> 참)
            // || : or (여러 값 중 하나라도 참 -> 참)
            textBox_print.Text += $"{!true}\r\n";
            textBox_print.Text += $"{!false}\r\n";
            textBox_print.Text += $"{!!true}\r\n";
            textBox_print.Text += $"{!!false}\r\n";

            textBox_print.Text += $"{true && true} \r\n";
            textBox_print.Text += $"{true && false} \r\n";
            textBox_print.Text += $"{false && false} \r\n";
            
            textBox_print.Text += $"{true || true} \r\n";
            textBox_print.Text += $"{true || false} \r\n";
            textBox_print.Text += $"{false || false} \r\n";


            textBox_print.Text += $"{!(2 > 1)} \r\n"; // !True -> False
            textBox_print.Text += $"{ 2 > 1 && -2 < 1} \r\n"; //  True
            textBox_print.Text += $"{!(2 > 1 && -2 < 1) || 5 < 2} \r\n"; // True

            textBox_print.Text += $"---------------- \r\n";

            // 증감 연산자
            // ++ : 변수 값을 1증가
            // -- : 변수 값을 1감소
            // 증감 연산자를 붙이는 위치에 따라 결과가 다르다.
            int result1, result2; // 같은 자료형이라면 ,로 구분하여 같이 선언 가능
            int num = 10, num2 = 10;

            // 후위 증감(Postfix)
            // 변수를 **먼저 사용**하고, 이후에 1증가/감소 함
            //ToString()붙인 이유. num이 숫자라서
            // 텍스트박스안에 출력하려면 string타입이여야 하기 때문
            result1 = num++;
            textBox_print.Text += result1.ToString() + "\r\n";
            textBox_print.Text += num.ToString() + "\r\n";

            // 전위 증감(Prefix)
            //변수를 먼저 증가/감소 시키고, 이후에 사용
            result2 = ++num2;
            textBox_print.Text = result2.ToString() + "\r\n";
            textBox_print.Text += num2.ToString() + "\r\n";
            // =은 덮어 쓰기
            // +=은 추가 쓰기

            //연산자 줄여쓰기

            //------------------------------------------

            //실습
            //Q1) 과일 이름(string), 가격(int), 수량(int)을 저장할 수 있는 변수 선언
            // 과일 이름, 가격, 수량은 자유롭게 지정
            // 총 가격을 계산하는 변수를 만들기
            // testBox1에 다음과 같은 형식으로 출력하기
            // ex) "사과 5개의 총 가격은 15000원 입니다."

            string fruit = "사과";
            int price = 1000;
            int quantity = 8;
            int total = price * quantity;

            textBox1.Text = fruit + " " + quantity.ToString()
                + "개의 총 가격은 " + total.ToString() + "원 입니다. \r\n";

            //Q2) 문자열 + 숫자
            // 문자열 "15"를 숫자로 변환하여 10을 더하고 그 결과 값을 출력해보기
            // textBox2에 다음과 같은 형식으로 출력
            // ex) "15에 10을 더하면 25입니다."
            string strNum = "15";
            textBox2.Text = strNum + $"에 10을 더하면 {int.Parse(strNum) + 10}입니다.";

            // Q3) 종합 문제
            // Q3-1) 변수 5개 선언(자료형에 맞춰서)
            // 상품명(string) : 노트북
            // 가격(int) : 1,200,000
            // 할인율(float) : 0.15
            // 재고 수량(byte) : 8개
            // isAvailable(bool)이라는 변수를 만들어, 재고가 1개 이상이면 true, 아니면 false를 저장.
            //-> 아직 조건문을 안배웠기 때문에 삼항연산자로 대체하기
            string productName = "노트북"; // 상품명
            int productPrice = 1200000; // 가격
            float discountRate = 0.15f; //할인율
            byte stockCount = 8; // 재고 수량
            bool isAvailable = (stockCount >= 1) ? true : false;

            // Q3-2) 할인된 가격을 계산해서 새로운 변수 생성
            // 할인 가격은 "가격 x (1-할인율)"로 계산
            // 계산 결과는 소수점이 생길 수 있으므로, double형 변수에 저장
            double discountPrice = productPrice * (1 - discountRate);

            //Q3-3) 재고가 있을 경우와 없을 경우 출력 메세지를 다르게 설정하기
            // 재고가 있으면, 
            // "구매 가능 : 할인 가격은 0,000,000원 입니다."
            // 재고가 없으면,
            // "품절되었습니다."
            // textBox1에 출력하기
            string resultMessage = (stockCount > 0) ? "구매 가능 : 할인 가격은 " + discountPrice.ToString("#,0") + "원 입니다."
                : "품절되었습니다.";
            textBox1.Text = resultMessage;
            //Q3-4) 재고가 5개 이상이면 "여유 있음", 아니면 "소량 남음"표시.
            // textBox2에 출력하기
            textBox2.Text = (stockCount >= 5) ? "여유 있음" : "소량 남음";

            //Q3-5) 상품 정보를 한 줄에 정리하여 textBox3에 출력하기
            // 출력 예시
            // "상품명 : 노트북, 할인된 가격 : 0,000,000원, 재고 : 8개"
            string productInfo; // 상품 정보 변수 선언
            productInfo = "상품명 : " + productName + ", 할인된 가격 : "
                + discountPrice.ToString("#,0") + "원, 재고 : " + stockCount.ToString() + "개 \r\n";
            //.ToString("#,0") : 문자형 타입으로 변환하고 #,0형식으로 만듬
            // #,0 : 천 단위로 ,를 찍어주고 소수점은 0자리까지 표현

            textBox3.Text = productInfo;

            // Q3-6) push 후, Repo 주소 슬랙 댓글에 남기기(서로의 코드 리뷰를 위해서)
        }

    }
}

/*
 
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
