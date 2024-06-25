//*****************************************************************************
//** 50. Pow(x,n) leetcode                                                   **
//** I started using loops and if statements.  That got me to 30X test cases **
//** Then I moved to recursion for solving the problem. -Dan                 **
//** P.S. - This was NOT a Hash table solution.                              **
//*****************************************************************************

double myPow(double x, long long n) {
    if (n == 0)
    {
        return 1.0;
    }
    if (n < 0) 
    {
        long long john = -n;
        long double triple = myPow(x, john);
        return 1.0 / triple;
    }
    else
    {
        long double triple = myPow(x, n / 2);
        return n % 2 == 0 ? triple * triple : triple * triple * x;
    }
}