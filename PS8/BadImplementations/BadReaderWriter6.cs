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
    public class BadReaderWriter6 : ReaderWriterLockSlimWrapper
    {
        /// <summary>
        /// EnterReadLock doesn't throw RecursionLockException when read lock already held
        /// </summary>
        public override void EnterReadLock ()
        {
            if (!base.IsReadLockHeld)
            {
                base.EnterReadLock();
            }
        }
    }
}
