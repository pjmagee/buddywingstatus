
using BuddyWingStatus.PathServiceClient;

namespace BuddyWingStatus.Models
{
    public class PlanetStatus
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string AreaName { get; set; }
        public string Description { get; set; }
        public int HopsReturned { get; set; }
    }

    public enum PlanetId : ulong
    {
        Alderaan = 0x400000014450FB0A,
        BalmorraEmpire = 0x40000000E21DD4EC,
        BalmorraRepublic = 0x4000000510FD7371,
        Belsavis = 0x40000001C0831248,
        Corellia = 0x4000000365D0CBA4,
        Coruscant = 0x4000000024FBCF55,
        DromundKaas = 0x4000000046FD234A,
        Hoth = 0x400000018A146EC8,
        Hutta = 0x4000000051FBC315,
        Ilum = 0x40000004D99C83A6,
        ImperialFleet = 0x4000001CCBDD9A50,
        Korriban = 0x4000000106296B6D,
        NarShaddaa = 0x40000002278FFC5D,
        OrdMantell = 0x4000000051FBCAB7,
        Quesh = 0x40000002BB84E563,
        RepublicFleet = 0x40000029DB8F7920,
        TarisEmpire = 0x4000000C22D43C01,
        TarisRepublic = 0x4000000111629D34,
        Tatooine = 0x400000000003FFE4,
        Tython = 0x4000000055F4C611,
        Voss = 0x400000019E9B4C48,
        TheVaelin = 0x4000000780A847D2,
        ArtusSystem = 0x4000000617C4E17A,
    }

    public interface IPlanet
    {
        string Name { get; }
        PlanetId AreaID { get; }
        string AreaName { get; }
        string Description { get; }
        PathStartEndCompositeType StartEnd { get; }
    }

    public class Coruscant : IPlanet
    {
        public string Name
        {
            get { return "Coruscant"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Coruscant; }
        }

        public string AreaName
        {
            get { return "coruscant_main"; }
        }

        public string Description
        {
            get { return "Black Sun Sector Republic Medical Droid to Justicar Sector Republic Medical Droid"; }
        }

        // <Hotspot Name="Republic Medical Droid" X="-333.1177" Y="-127.099" Z="-31.9786" /> <!-- Black Sun Sector -->
        // <Hotspot Name="Republic Medical Droid" X="145.9739" Y="-106.299" Z="401.7784" /> <!-- Justicar Sector -->
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()    
                    {
                        Flags = 0,
                        X = -333.1177f,
                        Y = -127.099f,
                        Z = -31.9786f
                    },
                    End = new PathHopCompositeType()  
                    {
                        Flags = 0,
                        X = 145.9739f,
                        Y = -106.299f,
                        Z = 401.7784f
                    }
                };
            }
        }
    }

    public class OrdMantell : IPlanet
    {
        public string Name
        {
            get { return "Ord Mantell"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.OrdMantell; }
        }

        public string AreaName
        {
            get { return "ord_resize"; }
        }

        public string Description
        {
            get { return " Drelliad Village Medical Droid to Oradam Village Medical Droid"; }
        }

        //<Hotspot Name="Medical Droid" X="1.0903" Y="1.303836" Z="-46.8569" /><!-- Drelliad Village -->
        //<Hotspot Name="Medical Droid" X="-28.0279" Y="1.284857" Z="-44.7855" /><!-- Oradam Village-->

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() 
                    {
                        Flags = 0,
                        X = 1.0903f,
                        Y = 1.303836f,
                        Z = -46.8569f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -28.0279f,
                        Y = 1.284857f,
                        Z = -44.7855f
                    }
                };
            }
        }
    }

    public class Tython : IPlanet
    {
        public string Name
        {
            get { return "Tython"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Tython; }
        }

        public string AreaName
        {
            get { return "tython_blockout"; }
        }

        public string Description
        {
            get { return "Jedi Temple Republic Medical Droid to Kalikori Village Republic Medical Droid"; }
        }

        //<Hotspot Name="Republic Medical Droid" X="-15.3679" Y="-8.133331" Z="-42.8" /> <!-- Jedi Temple -->
        //<Hotspot Name="Republic Medical Droid" X="13.2112" Y="-0.7676925" Z="-32.1017" /> <!-- Kalikori Village -->
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()          
                    {
                        Flags = 0,
                        X = -15.3679f,
                        Y = -8.133331f,
                        Z = -42.8f
                    },
                    End = new PathHopCompositeType()  
                    {
                        Flags = 0,
                        X = 13.2112f,
                        Y = -0.7676925f,
                        Z = -32.1017f
                    }
                };
            }
        }
    }

    public class TarisEmpire : IPlanet
    {
        public string Name
        {
            get { return "Taris Empire"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.TarisEmpire; } // Taris Empire
        }

        public string AreaName
        {
            get { return "tar2_main"; }
        }

        public string Description
        {
            get { return "Toxic Lake Garrison Medical Droid to Forward Outpost Alpha Medical Droid"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Vendor Name="Imperial Medical Droid" X="-5.921" Y="-25.73079" Z="59.9396" /> <!-- Toxic Lake Garrison -->
                    {
                        Flags = 0,
                        X = -5.921f,
                        Y = -25.73079f,
                        Z = 59.9396f
                    },
                    End = new PathHopCompositeType() // <Vendor Name="Imperial Medical Droid" X="34.3045" Y="-13.30151" Z="-25.9453" /> <!-- Forward Outpost Alpha -->
                    {
                        Flags = 0,
                        X = 34.3045f,
                        Y = -13.30151f,
                        Z = -25.9453f
                    }
                };
            }
        }
    }

    public class Hoth : IPlanet
    {
        public string Name
        {
            get { return "Hoth"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Hoth; }
        }

        public string AreaName
        {
            get { return "hot_main_1"; }
        }

        public string Description
        {
            get { return "Command Center Imperial Medical Droid to Icefall Plains Imperial Medical Droid"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Imperial Medical Droid" X="-262.136" Y="10.22445" Z="82.4589" /> <!-- Command Center -->
                    {
                        Flags = 0,
                        X = -262.136f,
                        Y = 10.22445f,
                        Z = 82.4589f
                    },
                    End = new PathHopCompositeType() // <Hotspot Name="Imperial Medical Droid" X="-161.2258" Y="5.37494" Z="127.397" /> <!-- Icefall Plains -->
                    {
                        Flags = 0,
                        X = -161.2258f,
                        Y = 5.37494f,
                        Z = 127.397f
                    }
                };
            }
        }
    }

    public class TarisRepublic : IPlanet
    {
        public string Name
        {
            get { return "Taris Republic"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.TarisRepublic; } 
        }

        public string AreaName
        {
            get { return "tar_main"; }
        }

        public string Description
        {
            get { return "Aurek Medical Droid to Kanner Medical Droid"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Republic Medical Droid" X="-73.59275" Y="-12.99559" Z="2.690306" /> <!-- Aurek -->
                    {
                        Flags = 0,
                        X = -73.59275f,
                        Y = -12.99559f,
                        Z = 2.690306f
                    },
                    End = new PathHopCompositeType() // <Hotspot Name="Republic Medical Droid" X="34.5292" Y="-13.30151" Z="-25.8913" /> <!-- Kanner -->
                    {
                        Flags = 0,
                        X = 34.5292f,
                        Y = -13.30151f,
                        Z = -25.8913f
                    }
                };
            }
        }
    }

    public class Alderaan : IPlanet
    {
        public string Name
        {
            get { return "Alderaan"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Alderaan; }
        }

        public string AreaName
        {
            get { return "ald_main"; }
        }

        public string Description
        {
            get { return "House Thul Medical Droid to Outpost Talarn Medical Droid"; }
        }

        // <Vendor Name="Hendry" X="69.7124" Y="27.9896" Z="-134.1752" /> <!-- House Thul -->
        // <Vendor Name="Imperial Medical Droid" X="192.6259" Y="21.66723" Z="79.7412" /> <!-- Outpost Talarn -->
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() 
                    {
                        Flags = 0,
                        X = 69.7124f,
                        Y = 27.9896f,
                        Z = -134.1752f
                    },
                    End = new PathHopCompositeType()  
                    {
                        Flags = 0,
                        X = 192.6259f,
                        Y = 21.66723f,
                        Z = 79.7412f
                    }
                };
            }
        }
    }

    public class DromundKaas : IPlanet
    {
        public string Name
        {
            get { return "Dromund Kaas"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.DromundKaas; }
        }

        public string AreaName
        {
            get { return "dro_main"; }
        }

        public string Description
        {
            get { return "Dromund Kaas Spaceport Mailbox to Kaas City Mailbox"; }
        }

        // <Hotspot Name="Dromund Kaas Spaceport" X="93.21328" Y="6.610987" Z="34.19114" />
        // <Hotspot Name="Kaas City" X="-8.517436" Y="4.109" Z="32.67882" />
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 93.21328f,
                        Y = 6.610987f,
                        Z = 34.19114f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -8.517436f,
                        Y = 4.109f,
                        Z = 32.67882f
                    }
                };
            }
        }
    }

    public class Korriban : IPlanet
    {
        public string Name
        {
            get { return "Korriban"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Korriban; }
        }

        public string AreaName
        {
            get { return "kor_rebuild_test"; }
        }

        public string Description
        {
            get { return "From Shuttle to near entrance of Korriban Sith Temple"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 15.43423f,
                        Y = 0.5712913f,
                        Z = 11.92342f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -13.64896f,
                        Y = 1.976912f,
                        Z = 7.666828f
                    }
                };
            }
        }
    }

    public class BalmorraEmpire : IPlanet
    {
        public string Name
        {
            get { return "Balmorra Empire"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.BalmorraEmpire; }
        }

        public string AreaName
        {
            get { return "bal_main"; }
        }

        public string Description
        {
            get { return "Ordnance Officer Aambler to Corporal Hepswick"; }
        }

        // <Hotspot Name="Ordnance Officer Aambler" X="-6.5391" Y="15.45724" Z="164.8408" />
        // <Hotspot Name="Corporal Hepswick" X="83.13216" Y="14.03034" Z="156.0935" />
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -6.5391f,
                        Y = 15.45724f,
                        Z = 164.8408f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 83.13216f,
                        Y = 14.03034f,
                        Z = 156.0935f
                    }
                };
            }
        }
    }

    public class BalmorraRepublic : IPlanet
    {
        public string Name
        {
            get { return "Balmorra Republic"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.BalmorraRepublic;  }
        }

        public string AreaName
        {
            get { return "bal2_main"; }
        }

        public string Description
        {
            get { return "Gorinth Outpost Republic Medical Droid to Barasin Crossing Republic Medical Droid"; }
        }

        // <Hotspot Name="Republic Medical Droid" X="-7.583" Y="15.46973" Z="163.3296" /> <!-- Gorinth Outpost -->
        // <Hotspot Name="Republic Medical Droid" X="52.732" Y="9.260983" Z="139.9565" /> <!-- Barasin Crossing -->
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -7.583f,
                        Y = 15.46973f,
                        Z = 163.3296f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 52.732f,
                        Y = 9.260983f,
                        Z = 139.9565f
                    }
                };
            }
        }
    }

    public class NarShaddaa : IPlanet
    {
        public string Name
        {
            get { return "Nar Shaddaa"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.NarShaddaa; }
        }

        public string AreaName
        {
            get { return "nar_main"; }
        }

        public string Description
        {
            get { return "Network Access Taxi to Mezenti Spaceport Taxi"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 200.8f,
                        Y = -156.299f,
                        Z = 243.4f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -194.197f,
                        Y = 14.501f,
                        Z = -179.3529f
                    }
                };
            }
        }
    }

    public class Tatooine : IPlanet
    {
        public string Name
        {
            get { return "Tatooine"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Tatooine; }
        }

        public string AreaName
        {
            get { return "tat_main"; }
        }

        public string Description
        {
            get { return "Mos Ila Spaceport to Mos Anek"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() //  X="58.6105" Y="51.44746" Z="347.1011"
                    {
                        Flags = 0,
                        X = 58.6105f,
                        Y = 51.44746f,
                        Z = 347.1011f
                    },
                    End = new PathHopCompositeType() //  X="-4.466003" Y="44.6794" Z="32.1252"
                    {
                        Flags = 0,
                        X = -4.466003f,
                        Y = 44.6794f,
                        Z = 32.1252f
                    }
                };
            }
        }
    }

    public class Hutta : IPlanet
    {
        public string Name
        {
            get { return "Hutta"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Hutta; }
        }

        public string AreaName
        {
            get { return "hut_main"; }
        }

        public string Description
        {
            get { return "From Shuttle to near entrance of the Hutt Palace."; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -73.561f,
                        Y = 2.309058f,
                        Z = 28.0584f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -62.58936f,
                        Y = 2.501988f,
                        Z = 43.92438f
                    }
                };
            }
        }
    }

    public class Voss : IPlanet
    {
        public string Name
        {
            get { return "Voss"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Voss; }
        }

        public string AreaName
        {
            get { return "vos_main"; }
        }

        public string Description
        {
            get { return "Jal'Jinis to an Imperial Medical Droid"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Jal'Jinis" X="-13.7149" Y="27.46187" Z="-22.1371" />
                    {
                        Flags = 0,
                        X = -13.7149f,
                        Y = 27.46187f,
                        Z = -22.1371f
                    },
                    End = new PathHopCompositeType()  // <Hotspot Name="Imperial Medical Droid" X="118.9753" Y="1.6012" Z="-79.8429" />
                    {
                        Flags = 0,
                        X = 118.9753f,
                        Y = 1.6012f,
                        Z = -79.8429f
                    }
                };
            }
        }
    }

    public class Corellia : IPlanet
    {
        public string Name
        {
            get { return "Corellia"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Corellia; }
        }

        public string AreaName
        {
            get { return "crl_main"; }
        }

        public string Description
        {
            get { return "Calagott to Sergeant Calle"; }
        }
       
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Calagott" X="-155.3007" Y="4.901" Z="189.091" />
                    {
                        Flags = 0,
                        X = -155.3007f,
                        Y = 4.901f,
                        Z = 189.091f
                    },
                    End = new PathHopCompositeType()  // <Hotspot Name="Sergeant Calle" X="303.7735" Y="20.1139" Z="-125.9355" />
                    {
                        Flags = 0,
                        X = 303.7735f,
                        Y = 20.1139f,
                        Z = -125.9355f
                    }
                };
            }
        }
    }

    public class RepublicFleet : IPlanet
    {
        public string Name
        {
            get { return "Republic Fleet"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.RepublicFleet; }
        }

        public string AreaName
        {
            get { return "republic_fleet"; }
        }

        public string Description
        {
            get { return "Trooper trainer to Captain Tracer"; }
        }

        // <Hotspot Name="Captain Qonbla" Class="Trooper" X="-483.0641" Y="69.401" Z="-455.9018" />
        // <Hotspot Name="Captain Tracer" X="-480.7068" Y="69.801" Z="-459.7619" />

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() 
                    {
                        Flags = 0,
                        X = -483.0641f,
                        Y = 69.401f,
                        Z = -455.9018f
                    },
                    End = new PathHopCompositeType() 
                    {
                        Flags = 0,
                        X = -480.7068f,
                        Y = 69.801f,
                        Z = -459.7619f
                    }
                };
            }
        }
    }

    public class Belsavis : IPlanet
    {
        public string Name
        {
            get { return "Belsavis"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Belsavis; }
        }

        public string AreaName
        {
            get { return "bel_main"; }
        }

        public string Description
        {
            get { return "Imperial Medical Droid to another Imperial Medical Droid"; }
        }
        
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Imperial Medical Droid" X="36.0748" Y="16.66702" Z="-287.7637" />
                    {
                        Flags = 0,
                        X = 36.0748f,
                        Y = 16.66702f,
                        Z = -287.7637f
                    },
                    End = new PathHopCompositeType() // <Hotspot Name="Imperial Medical Droid" X="-247.2969" Y="18.42914" Z="-66.1909" />
                    {
                        Flags = 0,
                        X = -247.2969f,
                        Y = 18.42914f,
                        Z = -66.1909f
                    }
                };
            }
        }
    }

    public class ImperialFleet : IPlanet
    {
        public string Name
        {
            get { return "Imperial Fleet"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.ImperialFleet; }
        }

        public string AreaName
        {
            get { return "imperial_fleet"; }
        }

        public string Description
        {
            get { return "Agent Trainer to Bartender"; }
        }

        // <Hotspot Name="Agent Marxa" Class="Agent" X="479.9584" Y="69.401" Z="453.3768" />
        // <Hotspot Name="Bartender" X="470.0116" Y="70.181" Z="468.5824" />
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 479.9584f,
                        Y = 69.401f,
                        Z = 453.3768f
                    },
                    End = new PathHopCompositeType() 
                    {
                        Flags = 0,
                        X = 470.0116f,
                        Y = 70.181f,
                        Z = 468.5824f
                    }
                };
            }
        }
    }

    public class Quesh : IPlanet
    {
        public string Name
        {
            get { return "Quesh"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Quesh; }
        }

        public string AreaName
        {
            get { return "que_main"; }
        }

        public string Description
        {
            get { return "Imperial Base Medical Droid to Imperial Waystation Medical Droid"; }
        }

        // <Vendor Name="Imperial Medical Droid" X="16.8798" Y="8.508716" Z="165.7795" /> <!-- Imperial Base -->
        // <Trainer Name="Lord Ishla" Class="Warrior" X="26.9574" Y="8.098917" Z="168.6448" />
        // <Vendor Name="Imperial Medical Droid" X="-7.0113" Y="6.281129" Z="54.0048" /> <!-- Imperial Waystation -->
        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = 16.8798f,
                        Y = 8.508716f,
                        Z = 165.7795f
                    },
                    End = new PathHopCompositeType()
                    {
                        Flags = 0,
                        X = -7.0113f,
                        Y = 6.281129f,
                        Z = 54.0048f
                    }
                };
            }
        }
    }

    public class Ilum : IPlanet
    {
        public string Name
        {
            get { return "Ilum"; }
        }

        public PlanetId AreaID
        {
            get { return PlanetId.Ilum; }
        }

        public string AreaName
        {
            get { return "ilm_main1"; }
        }

        public string Description
        {
            get { return "Imperial Base Camp Speeder to Imperial Waystation Speeder"; }
        }

        public PathStartEndCompositeType StartEnd
        {
            get
            {
                return new PathStartEndCompositeType()
                {
                    Start = new PathHopCompositeType() // <Hotspot Name="Imperial Base Camp Speeder" X="37.7573" Y="-0.4667983" Z="-46.1142" />
                    {
                        Flags = 0,
                        X = 37.7573f,
                        Y = -0.4667983f,
                        Z = -46.1142f
                    },
                    End = new PathHopCompositeType()  // ToX="-29.6456" ToY="-1.300103" ToZ="-20.3487" />
                    {
                        Flags = 0,
                        X = -29.6456f,
                        Y = -1.300103f,
                        Z = -20.3487f
                    }
                };
            }
        }
    }
}