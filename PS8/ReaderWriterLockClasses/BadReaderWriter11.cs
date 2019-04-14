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
    /// ExitWriteLock doesn't throw SynchronizationLockException
    /// </summary>
    public class BadReaderWriter11 : ReaderWriterLockSlimWrapper
    {
        public override void ExitWriteLock ()
        {
            try
            {
                base.ExitWriteLock();
            }
            catch (SynchronizationLockException)
            {
            }
        }
    }
}
