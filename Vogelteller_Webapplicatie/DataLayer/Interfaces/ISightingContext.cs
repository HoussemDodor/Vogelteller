using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public interface ISightingContext
    {
        void NewSighting(int xpoint, int ypoint, DateTime timeSeen, Visit visit, Animal animal);
        void ChangeSighting(int xpoint, int ypoint, DateTime timeSeen, Visit visit, Animal animal);
        void DeleteSighting(int ID);
        Sighting GetSighting(int ID);
        List<Sighting> GetAllSightings();
        List<Sighting> GetAllSightingKind();

    }
}
