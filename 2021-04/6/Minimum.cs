using System;

public class Solution {
    public int[] solution(int[] arr) {
        int leng = arr.Length;
        int minimum = arr[0];
        int[] answer = new int[] {};

        if (leng > 1)
        {
            answer = new int[leng-1];
            int[] min = arr;
            min.
            for (int i = 0; i < leng; i++)
            {
                if(arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }

            for (int j = 0; j <leng; j++)
            {
                if(arr[j] == minimum)
                {
                    answer[j] = arr[j+1];
                }
                else
                {
                    answer[j] = arr[j];
                }
            }
        }
        else 
        {
            answer = new int[] {-1};
        }
        return answer;
    }
}