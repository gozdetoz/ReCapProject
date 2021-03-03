using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //securitykey byte halıne cevırıyor 
        public static SecurityKey CreateSecurityKey(string securiyKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securiyKey));
        }
    }
}
