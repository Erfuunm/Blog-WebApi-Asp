﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class RefreshTokenInfo
    {
        public int Id { get; set; }
        public string? Token { get; set; } // refresh token
        public int UserId { get; set; }
    }
}
