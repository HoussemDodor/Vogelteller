using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class SightingSQLContext : ISightingContext
    {
        public void ChangeSighting(int xpoint, int ypoint, DateTime timeSeen, Visit visit, Animal animal)
        {
            throw new NotImplementedException();
        }

        public void DeleteSighting(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Sighting> GetAllSightingKind()
        {
            throw new NotImplementedException();
        }

        public List<Sighting> GetAllSightings()
        {
            throw new NotImplementedException();
        }

        public Sighting GetSighting(int ID)
        {
            throw new NotImplementedException();
        }

        public void NewSighting(int xpoint, int ypoint, DateTime timeSeen, Visit visit, Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
