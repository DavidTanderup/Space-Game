using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class Planet
    {
        private string PlanetName { get; set; }
        private Tuple<double, double> PlanetCoordinate { get; set; }
        private double PlanetSize { get; set; }
        private string PlanetBio { get; set; }
        private bool PlanetExsistance { get; set; }




        /// <summary>
        /// Planet size is based on Earth Scale. Earth = 1
        /// </summary>
        public List<Planet> PlanetSystem()
        {
            List<Planet> Galaxy = new List<Planet>()
        {
                               
            new Planet{PlanetName = "Earth", PlanetSize = 1, PlanetCoordinate = new Tuple <double,double>(0,0), PlanetBio = "", PlanetExsistance = true},
            new Planet{PlanetName = "Moon", PlanetSize = .27, PlanetCoordinate = new Tuple<double, double>(.0002,.00025), PlanetBio = "", PlanetExsistance = true},
            new Planet{PlanetName = "Proxima b", PlanetSize = 1.3, PlanetCoordinate = new Tuple<double, double>(3.47, 2.66), PlanetBio = "", PlanetExsistance = true},
            new Planet{PlanetName = "Krypton", PlanetSize = 1.5, PlanetCoordinate = new Tuple<double, double>(23, -14.5), PlanetBio = Krypton(), PlanetExsistance = false },
            new Planet{PlanetName = "Alderaan", PlanetSize = 1, PlanetCoordinate = new Tuple<double, double>(-18,27),PlanetBio = "", PlanetExsistance = false},
            new Planet{PlanetName = "Klendathu", PlanetSize = 2.6,PlanetCoordinate = new Tuple<double, double>(-15.6,-17.8), PlanetBio = "", PlanetExsistance = true},
            new Planet{PlanetName = "Genesis", PlanetSize = 1.7, PlanetCoordinate = new Tuple<double, double>(7.2,-32), PlanetBio = "", PlanetExsistance = true }




        };


            return Galaxy;
        }
        
        public string  Krypton()
        {
            string kryptonBio =
            "\n\tHistory of Krypton " +
            "\n\tThe new Krypton was approximately 1.5 times larger than the Earth and orbited a red sun called Rao fifty light-years from " +
            "\tour solar system. Krypton's primordial era produced some of the most dangerous organisms in the universe. It was for this reason that 250,000 years ago, Krypton " +
            "\twas chosen as the place to create Doomsday through forced evolution. Until its destruction, many dangerous animals, including ferrophage moles, still existed " +
            "\ton Krypton. Kryptonians had to use their advanced technology to survive. Over 200,000 years ago, Krypton had developed scientific advancements far beyond those" +
            "\tof present - day Earth, and had discovered a way to conquer disease and aging by perfecting cloning; vast banks of clones, kept in stasis, held multiple copies " +
            "\tof each living Kryptonian so that replacement parts were always available in the event of injury. All Kryptonians were now effectively immortal, with all the strength " +
            "\tand vigor of youth maintained, and for millennia they enjoyed an idyllic, sensual existence in an Arcadian paradise. 100,000 years later Kryptonian society was " +
            "\ttipping toward decadence and eventually political strife resulted from the debate as to whether clones were sentient beings and should have rights(sparked by the " +
            "presence of an alien missionary known as the Cleric, who carried \"the Eradicator\"). Eventually this disagreement led to open violent conflict. A woman named " +
            "Nyra, seeking what she considered a suitable mate for her son, Kan-Z, had one of her younger clones removed from stasis.The clone gained full sentience and was " +
            "presented to society as a normal woman.When Kan-Z discovered that his fiancée was in fact his mother's clone, he killed the clone, then publicly killed his mother" +
            "and also attempted his own suicide before being stopped. This key incident ignited the Clone Wars which lasted for 1,000 years, during which Kryptonian science was " +
            "turned to warfare and several superweapons were developed and used. Among them was the device known as the Destroyer. Although the Eradicator's effects (altering " +
            "the DNA of all Kryptonian lifeforms so that they would instantly die upon leaving the planet) were felt immediately, the Destroyer's effects were possibly more " +
            "significant: by the time the Kryptonian government admitted defeat and abolished the clone banks, a pro-clone rights terrorist faction known as Black Zero had " +
            "started the Destroyer, a device which functioned as a giant nuclear gun, projecting massive streams of nuclear energy into the core of Krypton, intended to " +
            "trigger an explosive chain reaction within Krypton's core almost immediately. The use of the Destroyer eliminated the Post-Crisis city of Kandor, but it was " +
            "believed at the time that the device had been stopped before it could achieve planetary destruction (by Van-L, an ancestor of Jor-El). Centuries later, Jor-El " +
            "himself would discover that the reaction had only been slowed to a nearly imperceptible rate and it will eventually destroy the planet as intended."+
            "\n\tPresent Day Krypton" +
            8;

            return kryptonBio;
        }
        
        

    }

   


    public class Resources
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public int Size { get; set; }

    }
}
namespace Graphics
{
    /// <summary>
    /// Represents Map Coordinate
    /// </summary>

    class Coordinate
    {
        public int X { get; set; } //Left
        public int Y { get; set; } //Top
    }

    class Movement
    {
        const ConsoleColor HERO_COLOR = ConsoleColor.Red;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Black;

        public static Coordinate Hero { get; set; } /// our fearless hero

        public void MovementMain(string[] args)
        {
            InitGame();

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveHero(0, -1);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveHero(1, 0);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveHero(0, 1);
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveHero(-1, 0);
                        break;
                }
            }




        }



        private void MoveHero(int x, int y)
        {
            Coordinate newHero = new Coordinate()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero();

                Console.BackgroundColor = HERO_COLOR;
                Console.SetCursorPosition(newHero.X, newHero.Y);
                Console.Write("Our SpaceShip");


                Hero = newHero;
            }


        }

        private void RemoveHero()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write("             ");

        }

        private bool CanMove(Coordinate c)
        {
            if (c.X < 0 || c.X >= Console.WindowWidth)
            {
                return false;
            }
            if (c.Y < 0 || c.Y >= Console.WindowHeight)
            {
                return false;
            }

            return true;
        }


        private void SetBackGroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear();
        }

        /// <summary>
        /// Initiates game by painting background 
        /// and iniating the hero
        /// </summary>

        private void InitGame()
        {
            SetBackGroundColor();

            Hero = new Coordinate()
            {
                X = 0,
                Y = 0
            };

            MoveHero(0, 0);
        }
    }






}

