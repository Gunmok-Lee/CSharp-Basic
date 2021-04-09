using System;

public class Solution {
    public int[] solution(int n, int m) {
        
        int gcd = 1;
        int lcm;
        int big;
        int small;
        
        if (m < n)
        {
            big = n;
            small = m;
        }

        for (int i = 1; i < big; i++)
        {
            if(small % i == 0 && big % i ==0)
            {
                gcd = i;
            }
        }
        

        if (big % small == 0) {
            lcm = m;
        } 
        else 
        {
            lcm = small * big;
        }
        
        int[] answer = new int[2] {gcd, lcm};
        return answer;
    }
}