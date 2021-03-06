﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Salle2.model
{
    public class Table
    {
        public int tableX;
        public int tableY;
        public enumTableClient client;
        public enumTableProprete proprete;
        public int place;
        public bool ok;


        public Table()
        {
            client = enumTableClient.vide;
            proprete = enumTableProprete.propre;
            tableX = 0;
            tableY = 0;
        }

        public Table(int x, int y, int _place)
        {
            enumTableClient client = enumTableClient.vide;
            enumTableProprete proprete = enumTableProprete.propre;
            tableX = x;
            tableY = y;
            place = _place;
        }

        public enumTableClient enumTableClient
        {
            get => default(enumTableClient);
            set
            {
            }
        }

        public Serveur Serveur
        {
            get => default(Serveur);
            set
            {
            }
        }

        internal baseDataSet baseDataSet
        {
            get => default(baseDataSet);
            set
            {
            }
        }

        public (int, int) getTableCoord()
        {
            return (tableX, tableY);
        }

        public bool getLibre(int group)
        {
            if (place <= group)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }
    }
}