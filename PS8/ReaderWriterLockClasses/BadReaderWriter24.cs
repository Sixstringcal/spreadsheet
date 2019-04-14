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
    /// Behaves just like it is supposed to behave except that writers are forced to wait until there are no
    /// readers waiting.
    /// </summary>
    public class BadReaderWriter24: ReaderWriterLockSlimWrapper
    {
        private readonly object sync = new object();

        public override void EnterWriteLock ()
        {
            while (true)
            {
                lock(sync)
                {
                    if (base.CurrentReadCount == 0 && !base.IsWriteLockHeld)
                    {
                        base.EnterWriteLock();
                        return;
                    }
                }
                Thread.Sleep(10);
            }
        }

        public override void EnterReadLock()
        {
            lock (sync)
            {
                base.EnterReadLock();
            }
        }

        public override bool TryEnterReadLock(int n)
        {
            lock (sync)
            {
                return base.TryEnterReadLock(n);
            }
        }
    }
}

