﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Domain.Interfaces
{
    interface IDatabaseSource
    {
        List<string> Save(string input);
    }
}
