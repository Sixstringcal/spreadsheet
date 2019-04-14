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
    /// Doesn't enforce read locks
    /// </summary>
    public class BadReaderWriter30: ReaderWriterLockSlimWrapper
    {
        private HashSet<Thread> lockedThreads = new HashSet<Thread>();

        public override void EnterReadLock ()
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

        public override bool TryEnterReadLock (int n)
        {
            if (n < -1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (lockedThreads.Contains(Thread.CurrentThread))
            {
                throw new LockRecursionException();
            }
            lock (lockedThreads)
            {
                lockedThreads.Add(Thread.CurrentThread);
                return true;
            }
        }

        public override void ExitReadLock ()
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

        public override int CurrentReadCount => lockedThreads.Count;

        public override bool IsReadLockHeld => lockedThreads.Contains(Thread.CurrentThread);
    }
}

