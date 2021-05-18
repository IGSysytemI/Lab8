﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSBB.Security.Identity
{
    public class Doctor
        : Client
    {
        public Doctor(int userId, string name, int catalogId) 
            : base(userId, name, catalogId, nameof(Doctor))
        {
        }
    }
}
