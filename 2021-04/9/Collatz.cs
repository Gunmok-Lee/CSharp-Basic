using System;

public class Solution {
    public int solution(int num) {
        int answer = -1;
        int Max = 500;
        for (int i = 0; i < Max; i++)
        {
            if(num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = (num * 3) + 1;
            }

            if(num == 1)
            {
                answer = i + 1;
                break;
            }
        }
        return answer;
    }
}