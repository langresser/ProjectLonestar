﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ITargetable
{
    // Dep this
    // bool IsTargetable { get; set; }
    bool IsTargetable();
    void SetupTargetIndicator(TargetIndicator indicator);
    event TargetEventHandler BecameTargetable;
    event TargetEventHandler BecameUntargetable;
}

public delegate void TargetEventHandler(ITargetable sender);