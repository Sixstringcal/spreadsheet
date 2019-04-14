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
    public class BadReaderWriter13 : ReaderWriterLockSlimWrapper
    {
        /// <summary>
        /// TryEnterReadLock doesn't throw LockRecursionException when write lock already held
        /// </summary>
        public override bool TryEnterReadLock (int n)
        {
            if (!base.IsWriteLockHeld)
            {
                return base.TryEnterReadLock(n);
            }
            else
            {
                return true;
            }
        }
    }
}
