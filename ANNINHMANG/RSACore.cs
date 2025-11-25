using System;
using System.Numerics;
using System.Text;

public class RSACore
{
    // Các thuộc tính khóa tương ứng với giao diện
    public BigInteger P { get; private set; }
    public BigInteger Q { get; private set; }
    public BigInteger N { get; private set; }
    public BigInteger Phi { get; private set; }
    public BigInteger E { get; set; } // Tương ứng B trên UI
    public BigInteger D { get; private set; } // Tương ứng A trên UI

    // Sinh P và Q ngẫu nhiên 
    public void GeneratePrimes(int bitLength = 1024)
    {
        // Sinh P
        do { P = BigIntegerExtensions.RandomBigInteger(bitLength / 2); }
        while (!P.IsProbablePrime());

        // Sinh Q khác P
        do { Q = BigIntegerExtensions.RandomBigInteger(bitLength / 2); }
        while (Q == P || !Q.IsProbablePrime());
    }

    // Tính toán khóa [7]
    public void CalculateKeys(BigInteger specifiedE)
    {
        N = P * Q;
        Phi = (P - 1) * (Q - 1);
        E = specifiedE;

        // Kiểm tra điều kiện gcd(E, Phi) = 1
        if (BigInteger.GreatestCommonDivisor(E, Phi) != 1)
        {
            throw new ArgumentException("Giá trị B (Public Key) không nguyên tố cùng nhau với Phi(n). Vui lòng chọn số khác.");
        }

        // Tính A (Private Key)
        D = E.ModInverse(Phi);
    }

    // Ký số (Mã hóa Hash bằng Private Key D/A) 
    public BigInteger SignData(BigInteger hashInt)
    {
        return BigInteger.ModPow(hashInt, D, N);
    }

    // Kiểm tra (Giải mã Chữ ký bằng Public Key E/B)
    public BigInteger VerifySignature(BigInteger signatureInt)
    {
        return BigInteger.ModPow(signatureInt, E, N);
    }
}