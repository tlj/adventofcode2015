﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    namespace Utils
    {

        public class MD5
        {
            public static string CalculateMd5(string input, System.Security.Cryptography.MD5 md5)
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                return ByteArrayToHexViaLookup32(hash);
            }

            private static readonly uint[] _lookup32 = CreateLookup32();

            private static uint[] CreateLookup32()
            {
                var result = new uint[256];
                for (int i = 0; i < 256; i++)
                {
                    string s = i.ToString("X2");
                    result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
                }
                return result;
            }

            private static string ByteArrayToHexViaLookup32(byte[] bytes)
            {
                var lookup32 = _lookup32;
                var result = new char[bytes.Length * 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    var val = lookup32[bytes[i]];
                    result[2 * i] = (char)val;
                    result[2 * i + 1] = (char)(val >> 16);
                }
                return new string(result);
            }

        }
    }
}