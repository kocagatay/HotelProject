﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room : IEntity
    {
        public int RoomId { get; set; }
        public int CategoryId { get; set; }
    }
}
