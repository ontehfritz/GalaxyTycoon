using System;
using Nez;

namespace GalaxyTycoon.Entities.Tools
{
    public class LandScraper : Component, ITriggerListener, IUpdatable
    {
        enum Animations
        {
            MoveRight,
            MoveLeft
        }

        public LandScraper()
        {

        }

        public void onTriggerEnter(Collider other, Collider local)
        {
            throw new NotImplementedException();
        }

        public void onTriggerExit(Collider other, Collider local)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
