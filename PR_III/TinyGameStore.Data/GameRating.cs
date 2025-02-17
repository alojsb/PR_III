﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyGameStore.Data
{
    public class GameRating
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int UserGameId { get; set; }
        public virtual UserGame UserGame { get; set; }
    }
}
