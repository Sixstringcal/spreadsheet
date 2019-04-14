﻿// Written by Joseph Zachary for CS 3500
// Copyright Joseph Zachary, March 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ReaderWriterLockClasses
{
    /// <summary>
    /// Behaves just like it is supposed to behave except that it uses a timeout that is too long
    ///  when trying to enter a write lock.
    /// </summary>
    public class BadReaderWriter23: ReaderWriterLockSlimWrapper
    {
        public override bool TryEnterWriteLock(int n)
        {
            if (n >= 0)
            {
                n = 2 * n + 500;
            }
            return base.TryEnterWriteLock(n);
        }
    }
}

