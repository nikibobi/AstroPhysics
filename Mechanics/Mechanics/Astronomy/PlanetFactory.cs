using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    class PlanetFactory
    {
        private const float STATIC = 0; // for speed = 0
        private const float SCALE = 0.01f;

        //TODO: swap names of pictires "Name_"<==>"name"
        public static Planet Sun
        {
            get
            {
                return new Planet(Resources.Sun_, PlanetInfo.Sun, STATIC, 0f);
            }
        }
        #region Sun Moons
        public static Planet Mercury
        {
            get
            {
                return new Planet(Resources.Mercury_, PlanetInfo.Mercury, 4.0923f, 252.42f);
            }
        }
        public static Planet Venus
        {
            get
            {
                return new Planet(Resources.Venus_, PlanetInfo.Venus, 1.6021f, 181.78f);
            }
        }
        public static Planet Earth
        {
            get
            {
                return new Planet(Resources.Earth_, PlanetInfo.Earth, 0.9856f, 99.86f);
            }
        }
        public static Planet Mars
        {
            get
            {
                return new Planet(Resources.Mars_, PlanetInfo.Mars, 0.5240f, 359.20f);
            }
        }
        public static Planet Jupiter
        {
            get
            {
                return new Planet(Resources.Jupiter_, PlanetInfo.Jupiter, 0.0830f, 36.20f);
            }
        }
        public static Planet Saturn
        {
            get
            {
                return new Planet(Resources.Saturn_, PlanetInfo.Saturn, 0.0334f, 45.93f);
            }
        }
        public static Planet Uranus
        {
            get
            {
                return new Planet(Resources.Uranus_, PlanetInfo.Uranus, 0.0117f, 316.57f);
            }
        }
        public static Planet Neptune
        {
            get
            {
                return new Planet(Resources.Neptune_, PlanetInfo.Neptune, 0.0059f, 303.98f);
            }
        }
        #endregion
        #region Earth moons
        public static Planet Moon
        {
            get
            {
                return new Planet(Resources.Moon_, PlanetInfo.Moon, 13.186f * SCALE, 0f);
            }
        }
        #endregion
        #region Mars moons
        public static Planet Phobos
        {
            get
            {
                return new Planet(Resources.Phobos_, PlanetInfo.Phobos, 12.5786f, 0f);
            }
        }
        public static Planet Deimos
        {
            get
            {
                return new Planet(Resources.Deimos_, PlanetInfo.Deimos, 3.1695f, 0f);
            }
        }
        #endregion
        #region Jupiter moons
        public static Planet Io
        {
            get
            {
                return new Planet(Resources.Io_, PlanetInfo.Io, 203.5048f * SCALE, 0f);
            }
        }
        public static Planet Europa
        {
            get
            {
                return new Planet(Resources.Europa_, PlanetInfo.Europa, 101.3770f * SCALE, 0f);
            }
        }
        public static Planet Ganymede
        {
            get
            {
                return new Planet(Resources.Ganymede_, PlanetInfo.Ganymede, 50.3179f * SCALE, 0f);
            }
        }
        public static Planet Callistro
        {
            get
            {
                return new Planet(Resources.Callisto_, PlanetInfo.Callisto, 21.5710f * SCALE, 0f);
            }
        }
        #endregion
        #region Saturn moons
        public static Planet Mimas
        {
            get
            {
                return new Planet(Resources.Mimas_, PlanetInfo.Mimas, 382.1656f * SCALE, 0f);
            }
        }
        public static Planet Enceladus
        {
            get
            {
                return new Planet(Resources.Enceladus_, PlanetInfo.Enceladus, 262.773f * SCALE, 0f);
            }
        }
        public static Planet Tethys
        {
            get
            {
                return new Planet(Resources.Tethys_, PlanetInfo.Tethys, 190.7790f * SCALE, 0f);
            }
        }
        public static Planet Dione
        {
            get
            {
                return new Planet(Resources.Dione_, PlanetInfo.Dione, 131.53567f * SCALE, 0f);
            }
        }
        public static Planet Rhea
        {
            get
            {
                return new Planet(Resources.Rhea_, PlanetInfo.Rhea, 79.681f * SCALE, 0f);
            }
        }
        public static Planet Titan
        {
            get
            {
                return new Planet(Resources.Titan_, PlanetInfo.Titan, 22.5776f * SCALE, 0f);
            }
        }
        public static Planet Hyperion
        {
            get
            {
                return new Planet(Resources.Hyperion_, PlanetInfo.Hyperion, 16.9204f * SCALE, 0f);
            }
        }
        public static Planet Iapetus
        {
            get
            {
                return new Planet(Resources.Iapetus_, PlanetInfo.Iapetus, 4.538f * SCALE, 0f);
            }
        }
        public static Planet Phoebe
        {
            get
            {
                return new Planet(Resources.Phoebe_, PlanetInfo.Phoebe, 0.6538f * SCALE, 0f);
            }
        }
        #endregion
        #region Uranus moons
        //public static Planet PuckPlanet
        //{
        //    get
        //    {
        //        return new Planet("Пък", Resources.Ball, 1, COUNTERCLOCKWISE);
        //    }
        //}
        public static Planet Miranda
        {
            get
            {
                return new Planet(Resources.Miranda_, PlanetInfo.Miranda, 254.7049f * SCALE, 0f);
            }
        }
        public static Planet Ariel
        {
            get
            {
                return new Planet(Resources.Ariel_, PlanetInfo.Ariel, 142.8361f * SCALE, 0f);
            }
        }
        public static Planet Umbriel
        {
            get
            {
                return new Planet(Resources.Umbriel_, PlanetInfo.Umbriel, 86.8690f * SCALE, 0f);
            }
        }
        public static Planet Titania
        {
            get
            {
                return new Planet(Resources.Titania_, PlanetInfo.Titania, 41.3514f * SCALE, 0f);
            }
        }
        public static Planet Oberon
        {
            get
            {
                return new Planet(Resources.Oberon_, PlanetInfo.Oberon, 26.7395f * SCALE, 0f);
            }
        }
        #endregion
        #region Neptune moons
        public static Planet Proteus
        {
            get
            {
                return new Planet(Resources.Proteus_, PlanetInfo.Proteus, 320.7698f * SCALE, 0f);
            }
        }
        public static Planet Triton
        {
            get
            {
                return new Planet(Resources.Triton_, PlanetInfo.Triton, 61.255f * SCALE, 0f);
            }
        }
        public static Planet Nereid
        {
            get
            {
                return new Planet(Resources.Nereid_, PlanetInfo.Nereid, 0.9996f * SCALE, 0f);
            }
        }
        #endregion

        public static Tree<Planet> Tree = 
            new Tree<Planet>(Sun,
                new Tree<Planet>(Mercury),
                new Tree<Planet>(Venus),
                new Tree<Planet>(Earth,
                    new Tree<Planet>(Moon)),
                new Tree<Planet>(Mars,
                    new Tree<Planet>(Phobos),
                    new Tree<Planet>(Deimos)),
                new Tree<Planet>(Jupiter,
                    new Tree<Planet>(Io),
                    new Tree<Planet>(Europa),
                    new Tree<Planet>(Ganymede),
                    new Tree<Planet>(Callistro)),
                new Tree<Planet>(Saturn,
                    new Tree<Planet>(Mimas),
                    new Tree<Planet>(Enceladus),
                    new Tree<Planet>(Tethys),
                    new Tree<Planet>(Dione),
                    new Tree<Planet>(Rhea),
                    new Tree<Planet>(Titan),
                    new Tree<Planet>(Hyperion),
                    new Tree<Planet>(Iapetus),
                    new Tree<Planet>(Phoebe)),
                new Tree<Planet>(Uranus,
                    new Tree<Planet>(Miranda),
                    new Tree<Planet>(Ariel),
                    new Tree<Planet>(Umbriel),
                    new Tree<Planet>(Titania),
                    new Tree<Planet>(Oberon)),
                new Tree<Planet>(Neptune,
                    new Tree<Planet>(Proteus),
                    new Tree<Planet>(Triton),
                    new Tree<Planet>(Nereid))
                );
    }
}
