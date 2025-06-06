# 🧮 Baekjoon 2475 - 검증수 풀이 & LINQ 학습 노트

## 📁 파일 경로
[🔗 2475 문제 코드 보기](../백준/Bronze/2475.%E2%80%85%EA%B2%80%EC%A6%9D%EC%88%98)

---

## 📖 문제 요약

- 공백으로 구분된 5개의 정수를 입력받고,
- 각 수를 제곱한 뒤 모두 더한 후,
- 그 합을 10으로 나눈 **나머지를 출력**하는 문제.

---

## 💻 최초 제출 코드

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (a, b, c, d, e) = (nums[0], nums[1], nums[2], nums[3], nums[4]);
        a = a * a;
        b = b * b;
        c = c * c;
        d = d * d;
        e = e * e;
        int num = (a + b + c + d + e) % 10;
        Console.WriteLine(num);
    }
}
```

## ✅ 코드 평가

| 항목             | 점수   | 평가 내용 |
|------------------|--------|-----------|
| **정확성**       | ⭐⭐⭐⭐⭐ | 문제의 요구사항을 정확하게 구현함 |
| **가독성**       | ⭐⭐⭐   | 변수명이 의미를 담지 않고, 제곱 반복 로직이 중복됨 |
| **유지보수성**   | ⭐⭐    | 입력 수 변경 시 코드 전체를 수정해야 함 |
| **일반화 가능성** | ⭐⭐    | `for`문 또는 `LINQ` 활용 시 더 유연하게 확장 가능 |

---

## 🧩 람다식(Lambda Expression) & LINQ 개념 정리

### 📌 람다식이란?

- 람다식은 **익명 함수(이름 없는 함수)**를 간단하게 표현하는 문법이다.
- 기본 구조는 `(입력) => (출력)` 형태로 구성된다.
- 예시:
  ```csharp
  x => x * x  // x를 제곱해서 반환
  (a, b) => a + b  // 두 수를 더해서 반환
  ```
일반 함수 대신 간결하게 표현할 수 있어 LINQ와 함께 매우 자주 사용된다.

📌 LINQ란?
Language INtegrated Query
C#에서 배열이나 리스트 등의 데이터를 간결하게 필터링하고 변환하고 집계할 수 있는 기능.

🛠 주요 메서드

메서드	기능
Select	모든 요소를 특정 방식으로 변환
Where	조건을 만족하는 요소만 추출
Sum	모든 요소를 합산
ToArray	결과를 배열로 변환

✅ 실전 사용 예시 (Baekjoon 2475 기준)
```csharp
int validationCode = numbers
    .Select(n => n * n) // 제곱
    .Sum()              // 더하고
    % 10;               // 나머지
```
---

## ✨ 개선된 LINQ 버전

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();

        int validationCode = numbers.Select(n => n * n).Sum() % 10;
        Console.WriteLine(validationCode);
    }
}
```

## 오늘 새로 배운걸 활용하면 가독성을 좋게 짤수 있을듯 함
