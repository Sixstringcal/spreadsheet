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
    /// EnterReadLock doesn't throw LockRecursionException when write lock already held
    /// </summary>
    public class BadReaderWriter07 : ReaderWriterLockSlimWrapper
    {
        public override void EnterReadLock()
        {
            if (!base.IsWriteLockHeld)
            {
                base.EnterReadLock();
            }
        }
    }
}
