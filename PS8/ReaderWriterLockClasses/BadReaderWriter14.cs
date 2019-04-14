// Written by Joseph Zachary for CS 3500
// Copyright Joseph Zachary, April 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ReaderWriterLockClasses
{
    /// <summary>
    /// TryEnterReadLock doesn't throw ArgumentOutOfRangeException when n < -1
    /// </summary>
    public class BadReaderWriter14 : ReaderWriterLockSlimWrapper
    {
        public override bool TryEnterReadLock(int n)
        {
            if (n < -1)
            {
                n = 10;
            }
            return base.TryEnterReadLock(n);
        }
    }
}
