using System.IO;
using System.Security.Cryptography;
using System.Numerics;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text;

public static class FileHandler
{
    // Đọc nội dung file Word (.docx) 
    public static string ReadDocxText(string filePath)
    {
        using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
        {
            Body body = wordDoc.MainDocumentPart.Document.Body;
            return body.InnerText;
        }
    }

    // Băm dữ liệu chuỗi thành BigInteger (SHA-256) [9, 15]
    public static BigInteger HashString(string content)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            byte[] hash = sha256.ComputeHash(bytes);

            // Chuyển đổi mảng byte sang BigInteger dương
            // Cần thêm byte 0 vào cuối mảng (Little Endian) để đảm bảo bit dấu dương
            byte[] positiveHash = new byte[hash.Length + 1];
            Buffer.BlockCopy(hash, 0, positiveHash, 0, hash.Length);

            return new BigInteger(positiveHash);
        }
    }

    // Băm file trực tiếp (Stream) cho file lớn 
    public static BigInteger HashFileStream(string filePath)
    {
        using (FileStream fs = File.OpenRead(filePath))
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hash = sha256.ComputeHash(fs);
            byte[] positiveHash = new byte[hash.Length + 1];
            Buffer.BlockCopy(hash, 0, positiveHash, 0, hash.Length);
            return new BigInteger(positiveHash);
        }
    }
}