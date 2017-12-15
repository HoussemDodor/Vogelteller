using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;

namespace Logic
{
    public class SightingLogic
    {
        Sighting s;
        List<Sighting> sightingList;

        // een nieuwe waarneming toevoegen
        public void NewSighting(int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {

        }

        // haalt alle waarnemingsoorten op per diersoort
        public List<SightingKind> GetAllSightingsKindBySpecies(int speciesID)
        {
            throw new NotImplementedException();
        }

        // Haalt alle sightings op van een bepaalde visit
        public List<Sighting> GetAllSightingsByVisit(int VisitID)
        {
            throw new NotImplementedException();
        }

        // Selecteer een waarnemingssoort
        public Sighting SelectSightingKind(int id)
        {
            throw new NotImplementedException();
        }

        // Selecteer een waarnemings
        public Sighting SelectSighting(int id)
        {
            throw new NotImplementedException();
        }

        // Verander een waarneming
        public Sighting ChangeSighting(int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {
            throw new NotImplementedException();
        }

        // Delete een waarneming
        public void DeleteSighting(int id)
        {
            
        }
    }
}
