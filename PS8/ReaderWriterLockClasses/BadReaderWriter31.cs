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
    /// Doesn't enforce write locks
    /// </summary>
    public class BadReaderWriter31 : ReaderWriterLockSlimWrapper
    {
        private HashSet<Thread> lockedThreads = new HashSet<Thread>();

        public override void EnterWriteLock()
        {
            lock (lockedThreads)
            {
                if (lockedThreads.Contains(Thread.CurrentThread))
                {
                    throw new LockRecursionException();
                }
                lockedThreads.Add(Thread.CurrentThread);
            }
        }

        public override bool TryEnterWriteLock(int n)
        {
            lock (lockedThreads)
            {
                if (n < -1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (lockedThreads.Contains(Thread.CurrentThread))
                {
                    throw new LockRecursionException();
                }
                lockedThreads.Add(Thread.CurrentThread);
                return true;
            }
        }

        public override void ExitWriteLock()
        {
            lock (lockedThreads)
            {
                if (lockedThreads.Contains(Thread.CurrentThread))
                {
                    lockedThreads.Remove(Thread.CurrentThread);
                }
                else
                {
                    throw new SynchronizationLockException();
                }
            }
        }

        public override bool IsWriteLockHeld => lockedThreads.Contains(Thread.CurrentThread);
    }
}

