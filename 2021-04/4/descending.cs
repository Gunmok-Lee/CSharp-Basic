using System;

public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        
        char[] s = n.ToString().ToCharArray();
        
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (long.Parse(s[i].ToString()) < long.Parse(s[j].ToString()))
                    // 부등호가 바뀌면 오름차순
                {
                char v = s[i];
                s[i] = s[j];
                s[j] = v;
                }
            }
        }
        string str = new string(s);
        answer = Int64.Parse(str);
        return answer;
    }
}