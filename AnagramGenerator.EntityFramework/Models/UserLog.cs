﻿using System;
using System.Collections.Generic;

namespace AnagramGenerator.EF.DatabaseFirst.Models
{
    public partial class UserLog
    {
        public int Id { get; set; }
        public string UserIp { get; set; }
        public string SearchedWord { get; set; }
        public DateTime? Date { get; set; }
    }
}
