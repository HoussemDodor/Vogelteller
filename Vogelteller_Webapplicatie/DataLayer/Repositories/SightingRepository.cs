using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class SightingRepository
    {
        private ISightingContext context;

        public SightingRepository(ContextType contextType)
        {
            switch (contextType)
            {
                case ContextType.Database: this.context = new SightingSQLContext(); break;
                case ContextType.Test: this.context = new SightingTestContext(); break;
            }
        }

        void NewSighting(int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {
            context.NewSighting(xpoint, ypoint, sightingKind, animal);
        }
        void ChangeSighting(Sighting s, int xpoint, int ypoint, SightingKind sightingKind, Animal animal)
        {
            context.ChangeSighting(s, xpoint, ypoint, sightingKind, animal);
        }
        void DeleteSighting(int ID)
        {
            context.DeleteSighting(ID);
        }
        Sighting GetSightingByID(int ID)
        {
            return context.GetSightingByID(ID);
        }
        List<Sighting> GetAllSightings()
        {
            return context.GetAllSightings();
        }
        List<SightingKind> GetAllSightingKind()
        {
            return context.GetAllSightingKind();
        }
    }
}
