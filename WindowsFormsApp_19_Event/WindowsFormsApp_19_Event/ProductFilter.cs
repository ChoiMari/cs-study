﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_19_Event
{
    // 조건 델리게이트 타입 정의
    public delegate bool ProductCondition(Product p);
    // = Product 타입 객체를 전달받아 bool(true/false)을 반환하는 함수 형식의 델리게이트
    // => 즉, 조건을 검사하는 용도로 사용할 수 있는 함수 타입을 의미.
    public class ProductFilter
    {
        // 정적 메서드 정의
        public static List<Product> Filter(List<Product> products, ProductCondition condition)
        // ㄴ static: 객체를 만들지 않고 클래스 이름으로 직접 호출 가능
        // ㄴ List<Product>: 이 Filter메서드는 Product 리스트를 반환함.
        // ㄴ Filter: 메서드 이름
        // ㄴ - 매개변수
        //      -> List<Product> products: 전체 제품 목록 (필터링 대상)
        //      -> ProductCondition condition: 조건 함수 (델리게이트로 전달받음)
        // 제품 리스트 중 조건을 만족하는 항목만 필터링해서 반환하는 메서드
        {
            List<Product> result = new List<Product>(); // [ 노트북 객체 , 청소기 , 책상, ]
            // 조건을 만족하는 제품만 따로 저장할 결과 리스트를 미리 생성해 둠
            foreach (var p in products)
            {
                if (condition(p))
                    // 델리게이트에 담긴 조건 함수를 실행하여
                    // 조건을 만족하는 경우에만 아래 코드 실행.
                    result.Add(p);
            }
            return result;
            // 최종적으로 조건에 맞는 제품 리스트를 반환.
        }


    }
}