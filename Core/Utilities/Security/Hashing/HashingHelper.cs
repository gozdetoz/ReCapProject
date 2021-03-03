using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //verilen password degerini hashleyip ve saltlayıp dısarı bu ıkı degerı verecektır .
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }

        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            //passwordHash kısmının dogrulandıgı alandır .Karsılastırma alanıdır .Veritabanıyla kullanıcıdan gelen paasswordun hashlenmıs halının karsılastırılması yapılır.passwordsalt anahtar degeridir.Sifrelerken vermek lazım
            //passwordHash veritabanından gelen alan 
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
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
