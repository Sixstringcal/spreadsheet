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
    /// EnterWriteLock doesn't throw LockRecursionException when write lock already held
    /// </summary>
    public class BadReaderWriter09 : ReaderWriterLockSlimWrapper
    {
        public override void EnterWriteLock ()
        {
            if (!base.IsWriteLockHeld)
            {
                base.EnterWriteLock();
            }
        }
    }
}
