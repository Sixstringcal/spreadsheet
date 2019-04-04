// Written by Joseph Zachary for CS 3500
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
    /// Behaves just like it is supposed to behave except that only one reader at a time is allowed when
    /// EnterReadLock is used.
    /// </summary>
    public class BadReaderWriter20: ReaderWriterLockSlimWrapper
    {
        // Used to prevent concurrent reads
        private static readonly object sync = new object();

        public override void EnterReadLock()
        {
            base.EnterReadLock();
            Monitor.Enter(sync);
        }

        public override void ExitReadLock()
        {
            try
            {
                Monitor.Exit(sync);
            }
            catch (SynchronizationLockException)
            {
            }

            base.ExitReadLock();
        }
    }
}

