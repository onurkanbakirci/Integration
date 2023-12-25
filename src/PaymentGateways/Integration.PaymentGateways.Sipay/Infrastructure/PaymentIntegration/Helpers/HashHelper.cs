using System.Security.Cryptography;
using System.Text;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Helpers;
public static class HashHelper
{
    public static string GenerateHashKey(string total, string installment, string currency_code, string merchant_key, string invoice_id, string app_secret)
    {
        var data = total + '|' + installment + '|' + currency_code + '|' + merchant_key + '|' + invoice_id;
        var sha1 = new SHA1Managed();
        var rnd = new Random();
        var iv = sha1.ComputeHash(Encoding.UTF8.GetBytes(rnd.ToString()));
        var password = sha1.ComputeHash(Encoding.UTF8.GetBytes(app_secret)).ToString();
        rnd = new Random();
        var shaSalt = sha1.ComputeHash(Encoding.UTF8.GetBytes(rnd.ToString())).ToString();
        var salt = shaSalt.Substring(0, 4);

        var sha256 = new SHA256Managed();
        var saltWithPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        var encrypted = EncryptString(data, saltWithPassword, iv);
        var msg_encrypted_bundle = iv + ":" + salt + ":" + encrypted;
        msg_encrypted_bundle = msg_encrypted_bundle.Replace("/", "__");
        return msg_encrypted_bundle;
    }

    public static string EncryptString(string plainText, byte[] key, byte[] iv)
    {
        var encryptor = Aes.Create();
        encryptor.Mode = CipherMode.CBC;
        encryptor.Key = key;
        encryptor.IV = iv;
        var memoryStream = new MemoryStream();
        var aesEncryptor = encryptor.CreateEncryptor();
        var cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);
        var plainBytes = Encoding.ASCII.GetBytes(plainText);
        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
        cryptoStream.FlushFinalBlock();
        var cipherBytes = memoryStream.ToArray();
        memoryStream.Close();
        cryptoStream.Close();
        var cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
        return cipherText;
    }
}