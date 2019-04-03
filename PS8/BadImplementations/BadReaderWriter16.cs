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
    /// TryEnterWriteLock doesn't throw RecursionLockException when write lock already held
    /// </summary>
    public class BadReaderWriter16 : ReaderWriterLockSlimWrapper
    {
        public override bool TryEnterWriteLock (int n)
        {
            if (!base.IsWriteLockHeld)
            {
                return TryEnterWriteLock(n);
            }
            else
            {
                return true;
            }
        }
    }
}
