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
    /// ExitReadLock doesn't throw SynchronizationLockException
    /// </summary>
    public class BadReaderWriter10 : ReaderWriterLockSlimWrapper
    {
        public override void ExitReadLock ()
        {
            try
            {
                base.ExitReadLock();
            }
            catch (SynchronizationLockException)
            {
            }
        }
    }
}
