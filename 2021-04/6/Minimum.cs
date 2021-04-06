using System;

public class Solution {
    public int[] solution(int[] arr) {
        int leng = arr.Length;
        int[] answer = new int[] {};

        if (leng > 1)
        {
            answer = new int[leng-1];
            for (int i = 0; i < leng; i++)
            {
                for (int j = i + 1; j < leng; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        answer[i] = arr[i];
                        break;
                    }
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