using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class SightingSQLContext : ISightingContext
    {
        public void ChangeSighting(Sighting s, int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {
            throw new NotImplementedException();
        }

        public void DeleteSighting(int ID)
        {
            throw new NotImplementedException();
        }

        public List<SightingKind> GetAllSightingKind()
        {
            throw new NotImplementedException();
        }

        public List<Sighting> GetAllSightings()
        {
            throw new NotImplementedException();
        }

        public Sighting GetSightingByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void NewSighting(int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
