/**************************
 작성일 : 2025-04-29
    if문 , 논리 연산자
***************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
     &&, || : 단축평가 ==> 조건문 (if)에서 많이 사용.
    - (&&) : 앞 조건이 false면 뒤는 아예 계산 안함.
    - (||) : 앞이 true면 뒤를 아예 계산하지 않음.

    &, | : 전체 평가 ==> 논리 연산, 비트 연산에서도 사용.
    - (&) : 앞 조건이 false여도 뒤까지 무조건 계산함.
    - (|) : 앞이 true라도 뒤를 무조건 계산함.
 
    Quiz1) 
    a = false
    result = a && somefuntion(); ==>  false

    -> a가 false이면 && 연산에서 바로 결과가 false로 결정.
    -> Somefuntion() 거들떠 볼 필요가없다.
    = 즉, 실행도 안시킴.

    Quiz 2)
    b = true;
    result = b || Somefuntion();   ==> true
 */

namespace WindowsFormsApp_06_If
{
    public partial class Form1 : Form
    {
        /*
         실습. if 문

        • 동전 던지기(앞 면 또는 뒷 면) 함수를 작성
            1. 함수 이름을 적당하게 짓기
            2. 출력 자료형은 bool
            3. 입력은 bool 형 1개
            4. "난수 생성"을 검색하여 난수 생성 방법을 학습하고 int형 난수를 생성
            5. 생성된 난수와 % 연산을 이용, 연산 결과로 0 또는 1만 값이 나오도록 작성
            6. 입력 값과 연산 결과를 비교하여 둘이 같으면 true를 반환, 다르면 false를 반환
            · 1= true, 0= false 라고 가정
        • 함수에 true 또는 false를 입력하고 반환된 결과에 따라 "승리" 또는 "패배"로
        TextBox에 표시
        • Push 후 Repo. 링크를 슬랙 댓글로 제출        
         */
        public Form1()
        {
            InitializeComponent();

            #region #1-2 실습) if문
            if (CoinMatch(true))
            {
                textBox_result.Text = "승리 ~!";
            }
            else
            {
                textBox_result.Text = "패배 ..ㅠ";
            }
            #endregion
        }

        bool CoinMatch(bool type) // C#에서 함수명은 파스칼 표기 권장
        {
            // 난수를 생성하기 위한 클래스
            // ㄴ 기본적으로 현재시간을 기준으로 시드 자동 생성)
            Random randomObj = new Random();
            /*
             * Random : 클래스
             * new Random() : Random 클래스를 이용해서 'randomObj' 이라는 객체를 만든 것.
             * randomObj : 객체.
             */

            // 짝수 / 홀수로 나눠서 0 or 1 결정하게 하기.
            int coin = randomObj.Next() % 2; // rnd.Next() : 0보다 크고 매우 큰 int 값을 반환.
            /*
             * rnd.Next() - 0 이상 int.MaxValue 미만 까지 (약 ~21억)
             * rnd.Next(max) - 0 이상 max 미만
             * rnd.Next(min, max) - min 이상 max 미만
             * rnd.NextDouble() - 0.0 이상 1.0 미만 소수 랜덤 생성.
             * - Random은 재사용이 좋다.
            */

            /*
             * (참고)
             * Math (=내장 클래스)
             * Math.Round() - 반올림       ex) 2.5 -> 3  / 2.2 -> 2
             * Math.Floor() - 내림, 버림   ex) 2.7 -> 2
             * Math.Ceiling() - 올림       ex) 2.1 -> 3
             */

            if ((coin == 1 && type == true) || (coin == 0 && type == false))
            {
                return true; // true 반환? : 이 함수의 결과가 성공, 일치
            }
            // 1이면 true(앞면), 0이면 false(뒷면)
            // 동전 결과(coin)와 사용자의 선택(type)이 일치할 경우에만 true 반환.

            return false;   // false 반환? : 이 함수의 결과가 일치 하지 않는다.
                            // else에 들어가는 것도 상관없음.
            /*
                else
                {
                    return false;
                }
            */
 
        }
    }
}
