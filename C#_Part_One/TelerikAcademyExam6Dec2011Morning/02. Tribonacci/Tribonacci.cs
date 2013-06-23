using System;
using System.Numerics;


class Tribonacci
{
    static void Main()
    {

        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        BigInteger requestedMember = BigInteger.Parse(Console.ReadLine());
        BigInteger sumofMembers = 0;

        for (int index = 0; index < requestedMember -3; index++)
        {
            sumofMembers = firstMember + secondMember + thirdMember;
            firstMember = secondMember;
            secondMember = thirdMember;
            thirdMember = sumofMembers;
        }
        Console.WriteLine(thirdMember);
    }
}

