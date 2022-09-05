using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken //Anlamsız değerlerden oluşan string
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } // Bitiş zamanı için verdiğimiz değer
    }
}
