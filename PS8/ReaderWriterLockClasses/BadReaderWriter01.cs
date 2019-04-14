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
    /// Bad CurrentReadCount return value
    /// </summary>
    public class BadReaderWriter1 : ReaderWriterLockSlimWrapper
    {
        public override int CurrentReadCount =>
            (base.CurrentReadCount == 0) ? 0 : base.CurrentReadCount + 1;
    }
}
