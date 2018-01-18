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
        void NewSighting(int Xpoint, int Ypoint, int sightingKindID, int animalID, DateTime timeSighted);
        void ChangeSighting(Sighting s, int Xpoint, int Ypoint, int sightingKindID, int animalID);
        void DeleteSighting(int ID);
        Sighting GetSightingByID(int ID);
        List<Sighting> GetAllSightings();
        List<SightingKind> GetAllSightingKind();

    }
}
