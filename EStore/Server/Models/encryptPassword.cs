﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStore.Server.Models
{
    public class encryptPassword
    {
        public static string textToEncrypt(string paasWord)
        {
            return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(paasWord)));
        }
    }
}