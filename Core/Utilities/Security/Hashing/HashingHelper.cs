using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{//Bizim içiçn bir araç bu yüzden çıplak kalabilir.
    public class HashingHelper
    {
        //Burası verdiğimiz passeord'un hash'ini oluşturmaya yarıyor.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //birden fazla veriyi döndürür.
        {
            using (var hmac =new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) //out'a gerek yok değerleri biz göndereceğiz.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                //Burası sonradan sisteme girmek isteyen kişinin verdiği passwordu, bizim veritabanında verdiğimiz Hash ile eşleşip eşleşmediği yerdir.
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }           
        }
    }
}
