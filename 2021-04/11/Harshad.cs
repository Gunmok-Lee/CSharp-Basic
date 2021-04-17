using System;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string a = x.ToString();
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += Int32.Parse(a.Substring(i,1));
        }

        if (x % sum /= 0)
        {
            answer = false;
        }
        return answer;
    }
}