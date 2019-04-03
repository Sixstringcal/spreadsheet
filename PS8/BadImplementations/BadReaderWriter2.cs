﻿// Written by Joseph Zachary for CS 3500
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
    /// Bad IsReadLockHeld return value
    /// </summary>
    public class BadReaderWriter2 : ReaderWriterLockSlimWrapper
    {
        public override bool IsReadLockHeld => false;
    }
}
