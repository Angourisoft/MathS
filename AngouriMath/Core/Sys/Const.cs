
/* Copyright (c) 2019-2020 Angourisoft
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy,
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
 * is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */



﻿using System;
using System.Collections.Generic;
using System.Text;
 using System.Security.Cryptography;

namespace AngouriMath
{
    internal static class Const
    {
        internal static readonly int PRIOR_SUM = 2;
        internal static readonly int PRIOR_MINUS = 2;
        internal static readonly int PRIOR_MUL = 4;
        internal static readonly int PRIOR_DIV = 4;
        internal static readonly int PRIOR_POW = 6;
        internal static readonly int PRIOR_FUNC = 8;
        internal static readonly int PRIOR_VAR = 10;
        internal static readonly int PRIOR_NUM = 2;
        internal static readonly string ARGUMENT_DELIMITER = ",";
        internal static OperatorEntity FuncIfSum(Entity child)
        {
            return new OperatorEntity("mulf", Const.PRIOR_MUL)
            {
                Children = new List<Entity> {
                    -1,
                    child
                    }
            };
        }
        internal static OperatorEntity FuncIfMul(Entity child)
        {
            return new OperatorEntity("powf", Const.PRIOR_POW)
            {
                Children = new List<Entity> {
                    child,
                    -1
                    }
            };
        }


        /// <summary>
        /// TODO & DOCTODO
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static bool IsReservedName(string name)
        {
            if (CompiledMathFunctions.func2Num.ContainsKey(name))
                return true;
            if (name == "tensort")
                return true;
            return false;
        }

        internal static string HashString(string input)
        {
            using (var sha = new SHA256Managed())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] computedByteHash = sha.ComputeHash(bytes);
                return BitConverter.ToString(computedByteHash).Replace("-", String.Empty);
            }
        }
    }
}
