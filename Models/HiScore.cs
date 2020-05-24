using System;
using System.Collections.Generic;

namespace HiScoreWebApp.Models
{
    public partial class HiScore
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int Score { get; set; }
    }
}
