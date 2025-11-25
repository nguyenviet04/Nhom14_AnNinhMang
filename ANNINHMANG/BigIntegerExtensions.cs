using System;
using System.Numerics;
using System.Security.Cryptography;

public static class BigIntegerExtensions
{
    // 1. Sinh số ngẫu nhiên lớn với độ dài bit xác định
    public static BigInteger RandomBigInteger(int bitLength)
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            int byteLength = bitLength / 8;
            byte[] data = new byte[byteLength]; // Đã sửa lỗi: thêm []
            rng.GetBytes(data);

            // Đảm bảo số dương bằng cách xóa bit dấu (MSB)
            data[data.Length - 1] &= 0x7F;

            return new BigInteger(data);
        }
    }

    // 2. Kiểm tra nguyên tố Miller-Rabin
    public static bool IsProbablePrime(this BigInteger value, int k = 10)
    {
        if (value < 2) return false;
        if (value == 2 || value == 3) return true;
        if (value % 2 == 0) return false;

        BigInteger d = value - 1;
        int s = 0;
        while (d % 2 == 0)
        {
            d /= 2;
            s++;
        }

        for (int i = 0; i < k; i++)
        {
            // Hàm này trước bị thiếu, giờ đã bổ sung bên dưới
            BigInteger a = RandomIntegerBelow(value - 2) + 2;
            BigInteger x = BigInteger.ModPow(a, d, value);

            if (x == 1 || x == value - 1) continue;

            for (int r = 1; r < s; r++)
            {
                x = BigInteger.ModPow(x, 2, value);
                if (x == 1) return false;
                if (x == value - 1) break;
            }

            if (x != value - 1) return false;
        }
        return true;
    }

    // 3. Hàm phụ trợ bị thiếu trong code cũ: Sinh số ngẫu nhiên nhỏ hơn n
    public static BigInteger RandomIntegerBelow(BigInteger n)
    {
        byte[] bytes = n.ToByteArray();
        BigInteger r;

        do
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            bytes[bytes.Length - 1] &= 0x7F; // Đảm bảo dương
            r = new BigInteger(bytes);
        } while (r >= n || r < 0);

        return r;
    }

    // 4. Thuật toán Euclid mở rộng tìm nghịch đảo Modulo
    public static BigInteger ModInverse(this BigInteger a, BigInteger m)
    {
        BigInteger m0 = m;
        BigInteger y = 0, x = 1;

        if (m == 1) return 0;

        while (a > 1)
        {
            if (m == 0) throw new DivideByZeroException("Modulus cannot be zero.");
            BigInteger q = a / m;
            BigInteger t = m;

            m = a % m;
            a = t;
            t = y;

            y = x - q * y;
            x = t;
        }

        if (x < 0) x += m0;

        return x;
    }
}