﻿using SeeAllClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Abstract
{
    public interface IModelsRepository
    {
        IEnumerable<Datetime> Datetimes { get; }
        IEnumerable<Downtime> Downtimes { get; }
    }
}
