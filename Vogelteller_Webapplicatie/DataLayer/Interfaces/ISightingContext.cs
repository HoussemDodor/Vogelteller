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
        void NewSighting(int xpoint, int ypoint, SightingKind sightingKind, Animal animal);
        void ChangeSighting(Sighting s, int xpoint, int ypoint, SightingKind sightingKind, Animal animal);
        void DeleteSighting(int ID);
        Sighting GetSightingByID(int ID);
        List<Sighting> GetAllSightings();
        List<SightingKind> GetAllSightingKind();

    }
}
