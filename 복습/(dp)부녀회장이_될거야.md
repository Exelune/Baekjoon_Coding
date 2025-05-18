## [[Bronze I] 부녀회장이 될테야 - 2775](https://github.com/Exelune/Baekjoon_Coding/tree/main/%EB%B0%B1%EC%A4%80/Bronze/2775.%E2%80%85%EB%B6%80%EB%85%80%ED%9A%8C%EC%9E%A5%EC%9D%B4%E2%80%85%EB%90%A0%ED%85%8C%EC%95%BC)
dp 기초 다지기
=============

![image](https://github.com/user-attachments/assets/48137540-0e91-42c6-a43f-564f7aac492f)   
우선 이 문제의 예제출력부터가 이해가 가지를 않음... 그래서 직접 메모장에다가 써보기로 함



![image](https://github.com/user-attachments/assets/b2a444b6-cebb-4f03-ba41-4d462b41d6d2)   
뭔가 아무리 적어봐도 k = 2, n = 3 예제출력이 이해가 가지를 않는 문제가 발생...   
메모장에서 한 10분을 고민하며 골머리를 앓다가 문제 조건을 몆번이고 다시 읽어보니   
`a층의 b호에 살려면 자신의 아래(a-1)층의 1호부터 b호까지 사람들의 수의 합만큼 사람들을 데려와 살아야 한다`   
이 부분을 몆번이고 읽어보니 내가 틀리게 계산하고 있는것을 확인 이후 제대로 구현 완료   

![image](https://github.com/user-attachments/assets/54f8b52d-2aab-441e-81b2-7b7de2177130)

이후 제대로 계산 완료한뒤에 코드까지는 잘 짯는데 내가 세운 점화식인데 내가 많이 햇갈려서 결국 다시 메모장을 꺼냄
``` csharp
dp[i][j] = dp[i][j - 1] + dp[i - 1][j];
```

![image](https://github.com/user-attachments/assets/2aba81f0-40ac-4c1d-b81c-f5f797b960eb)

메모장에 적으면서 머리에 정보 떄려박기 완료 이후 완성코드

``` csharp
using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int k = 0;
        int n = 0;
        List<int> listk = new List<int>();
        List<int> listn = new List<int>();
        int T = int.Parse(sr.ReadLine());

        for(int i = 0; i < T; i++)
        {
            k = int.Parse(sr.ReadLine());
            n = int.Parse(sr.ReadLine());
            listk.Add(k);
            listn.Add(n);
        }

        k = listk.Max();
        n = listn.Max();

        int[][] dp = new int[k + 1][];
        
        for(int i = 0;i <= k; i++)
        {
            dp[i] = new int[n + 1];
        }

        for(int i = 1;i<=n; i++)
        {
            dp[0][i] = i;
        }

        for(int i = 1; i <= k; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                dp[i][j] = dp[i][j - 1] + dp[i - 1][j];
            }
        }

        for(int i = 0; i < T; i++)
        {
            k = listk[i];
            n = listn[i];
            sw.WriteLine(dp[k][n]);
        }
    }
}
```

배운것
-------------
- 가변배열(2차원 리스트같은 느낌?)
- 문제 이해능력 + 1
- 점화식은 낮은 문제는 어느정도 비슷비슷한것 같지만 이해는 제대로 하자   

여기서 기초를 못다지면 좀만 더 어려워져도 못푼다.   
그러므로 이 문제랑 남은 class2문제로 제대로 다지고 class3을 마저 풀자
