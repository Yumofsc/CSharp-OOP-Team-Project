﻿namespace JustBlueberry.Blueberries
{
    using System.Collections.Generic;

    using JustBlueberry.Particles;
    using JustBlueberry.Blueberries.Contracts;
    using JustBlueberry.Particles.Contracts;

    public class NervousBlueberry : IMatter, IRadioactive
    {
        private bool hasPowerElectron;
        private IEnumerable<IHadron> particles;

        public NervousBlueberry(IList<IHadron> particles)
        {
            this.Particles = particles;
            this.CheckForPowerElectron();
        }

        private void CheckForPowerElectron()
        {
            foreach (var item in this.Particles)
            {
                if (item is GreenElectron)
                {
                    this.HasPowerElectron = true;
                }
            }

            // throw new PowerElectronMissingException
        }

        public bool HasPowerElectron
        {
            get { return this.hasPowerElectron; }
            set { this.hasPowerElectron = value; }
        }

        public IEnumerable<IHadron> Particles
        {
            get { return this.particles; }
            private set { this.particles = value; }
        }
    }
}
