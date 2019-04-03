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
    /// EnterWriteLock doesn't throw RecursionLockException when read lock already held
    /// </summary>
    public class BadReaderWriter8 : ReaderWriterLockSlimWrapper
    {
        public override void EnterWriteLock ()
        {
            if (!base.IsReadLockHeld)
            {
                base.EnterWriteLock();
            }
        }
    }
}
