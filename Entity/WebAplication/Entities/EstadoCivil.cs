﻿using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class EstadoCivil : BaseEntity
    {
        public string Nombre { get; set; } = null!;
    }
}
