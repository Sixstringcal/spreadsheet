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
    /// Bad WaitingWriteCount return value
    /// </summary>
    public class BadReaderWriter5 : ReaderWriterLockSlimWrapper
    {
        public override int WaitingWriteCount => 
            (base.WaitingWriteCount == 0) ? 0 : base.WaitingWriteCount + 1;
    }
}
