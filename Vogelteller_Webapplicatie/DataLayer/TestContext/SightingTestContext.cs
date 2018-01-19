using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class SightingTestContext : ISightingContext
    {
        List<Sighting> sightings = new List<Sighting>();
        List<SightingKind> sightingKinds = new List<SightingKind>();

        public void NewSighting(int xpoint, int ypoint, int sightingKindID, int animalID, DateTime timeSighted)
        {
            Sighting s = new Sighting(xpoint, ypoint, sightingKindID, animalID, timeSighted);
            sightings.Add(s);
        }

        public void ChangeSighting(Sighting s, int Xpoint, int Ypoint, int sightingKindID, int animalID)
        {
            s.Xpoint = Xpoint;
            s.Ypoint = Ypoint;
            s.sightingKindID = sightingKindID;
            s.animalID = animalID;
        }

        public void DeleteSighting(int ID)
        {
            foreach (Sighting s in sightings)
            {
                if (s.ID == ID)
                {
                    sightings.Remove(s);
                }
            }
        }

        public List<SightingKind> GetAllSightingKind()
        {
            return sightingKinds;
        }

        public List<Sighting> GetAllSightings()
        {
            return sightings;
        }

        public Sighting GetSightingByID(int ID)
        {
            foreach (Sighting s in sightings)
            {
                if (s.ID == ID)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
