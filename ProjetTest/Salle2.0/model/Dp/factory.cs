﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Salle.model;

namespace Salle2.0.model.Dp
{
    abstract class Taste
    {
        private string personnalTaste;

        public Taste()
        {
            this.CreateTaste();
        }

        public abstract void CreateTaste();
    }

    class rapid : Taste
    {
        public override void CreateTaste()
        {
            //personnalTaste = "Rapid";
        }
    }
}