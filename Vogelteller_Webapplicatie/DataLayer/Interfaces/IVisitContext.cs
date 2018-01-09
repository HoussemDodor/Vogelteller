﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public interface IVisitContext
    {
        Visit GetVisitByID(int ID);
        void NewVisit(string fullName);
        void AddSighting(Visit v, Sighting sighting);
        void EndVisit(int ID);      
    }
}
