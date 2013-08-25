﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
