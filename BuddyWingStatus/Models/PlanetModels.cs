
using System.Collections.Generic;
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

    public class PathStartEndRequest
    {
        public string Description { get; set; }
        public PathStartEndCompositeType StartEndCompositeType { get; set; }
    }

    public interface IPlanet
    {
        string Name { get; }
        PlanetId AreaID { get; }
        string AreaName { get; }
        IList<PathStartEndRequest> Requests { get; }
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

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Black Sun Sector Republic Medical Droid to Justicar Sector Republic Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
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
                        }
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

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Drelliad Village Medical Droid to Oradam Village Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
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
                        }
                    }
                };
            }
        }
    }

    public class Tython : IPlanet
    {
        public string Name { get { return "Tython"; } }

        public PlanetId AreaID { get { return PlanetId.Tython; } }

        public string AreaName { get { return "tython_blockout"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Jedi Temple Republic Medical Droid to Kalikori Village Republic Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -15.3679f, Y = -8.133331f, Z = -42.8f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 13.2112f, Y = -0.7676925f, Z = -32.1017f
                            }
                        }
                    }
                };
            }
        }     
    }

    public class TarisEmpire : IPlanet
    {
        public string Name { get { return "Taris Empire"; } }

        public PlanetId AreaID { get { return PlanetId.TarisEmpire; } }

        public string AreaName { get { return "tar2_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Toxic Lake Garrison Medical Droid to Forward Outpost Alpha Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0, 
                                X = -5.921f, Y = -25.73079f, Z = 59.9396f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 34.3045f, Y = -13.30151f, Z = -25.9453f
                            }
                        }
                    }
                };
            }
        }
    }

    public class Hoth : IPlanet
    {
        public string Name { get { return "Hoth"; } }

        public PlanetId AreaID { get { return PlanetId.Hoth; } }

        public string AreaName { get { return "hot_main_1"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Command Center Imperial Medical Droid to Icefall Plains Imperial Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -262.136f, Y = 10.22445f, Z = 82.4589f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -161.2258f, Y = 5.37494f, Z = 127.397f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Highmount Road Republic Medical Droid to Lieutenant Dav Pold Trooper Trainer",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -145.9131f, Y = 4.895034f, Z = 35.1911f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -346.861f, Y = 9.226f, Z = -124.3613f
                            }
                        }
                    }
                };
            }
        }  
    }

    public class TarisRepublic : IPlanet
    {
        public string Name { get { return "Taris Republic"; } }

        public PlanetId AreaID { get { return PlanetId.TarisRepublic; }  }

        public string AreaName { get { return "tar_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Aurek Medical Droid to Kanner Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -73.59275f, Y = -12.99559f, Z = 2.690306f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 34.5292f, Y = -13.30151f, Z = -25.8913f
                            }
                        }
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

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                           {
                               new PathStartEndRequest()
                                   {
                                       Description = "House Thul Hendry to Outpost Talarn Imperial Medical Droid",
                                       StartEndCompositeType = new PathStartEndCompositeType()
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
                                                                   }
                                   }
                           };
            }
        }
    }

    public class DromundKaas : IPlanet
    {
        public string Name { get { return "Dromund Kaas"; } }

        public PlanetId AreaID { get { return PlanetId.DromundKaas; } }

        public string AreaName { get { return "dro_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Dromund Kaas Spaceport Mailbox to Kaas City Mailbox",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 93.21328f, Y = 6.610987f, Z = 34.19114f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -8.517436f, Y = 4.109f, Z = 32.67882f
                            }
                        }
                    }
                };
            }
        }        
    }

    public class Korriban : IPlanet
    {
        public string Name { get { return "Korriban"; } }

        public PlanetId AreaID { get { return PlanetId.Korriban; } }

        public string AreaName { get { return "kor_rebuild_test"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "From Shuttle to near entrance of Korriban Sith Temple",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 15.43423f, Y = 0.5712913f, Z = 11.92342f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -13.64896f,Y = 1.976912f, Z = 7.666828f
                            }
                        }
                    }
                };
            }
        }
    }

    public class BalmorraEmpire : IPlanet
    {
        public string Name { get { return "Balmorra Empire"; } }
        
        public PlanetId AreaID { get { return PlanetId.BalmorraEmpire; } }

        public string AreaName { get { return "bal_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Ordnance Officer Aambler to Corporal Hepswick",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -6.5391f, Y = 15.45724f, Z = 164.8408f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 83.13216f, Y = 14.03034f, Z = 156.0935f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Tyrlena to Bugtown Outpost Mailbox",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -17.60075f, Y = 6.011f, Z = 85.30432f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 27.78399f, Y = -0.05346774f, Z = -8.176604f
                            }
                        }
                    }
                };
            }
        }
    }

    public class BalmorraRepublic : IPlanet
    {
        public string Name { get { return "Balmorra Republic"; } }

        public PlanetId AreaID { get { return PlanetId.BalmorraRepublic; } }

        public string AreaName { get { return "bal2_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Gorinth Outpost Republic Medical Droid to Barasin Crossing Republic Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -7.583f, Y = 15.46973f, Z = 163.3296f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 52.732f, Y = 9.260983f, Z = 139.9565f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Farnel Republic Medical Droid to Balmorran Arms Factory Republic Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 26.3384f, Y = 0.1718203f, Z = -12.0117f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 145.2f, Y = 10.45036f, Z = 75.2f
                            }
                        }
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

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Network Access Taxi to Mezenti Spaceport Taxi",
                        StartEndCompositeType = new PathStartEndCompositeType()
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
                        }
                    }
                };
            }
        }
    }

    public class Tatooine : IPlanet
    {
        public string Name { get { return "Tatooine"; } }

        public PlanetId AreaID { get { return PlanetId.Tatooine; } }

        public string AreaName { get { return "tat_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Mos Ila Spaceport to Mos Anek",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 58.6105f, Y = 51.44746f, Z = 347.1011f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -4.466003f, Y = 44.6794f, Z = 32.1252f
                            }
                        }
                    }
                };
            }
        }
    }

    public class Hutta : IPlanet
    {
        public string Name { get { return "Hutta"; } }

        public PlanetId AreaID { get { return PlanetId.Hutta; } }

        public string AreaName { get { return "hut_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "From Shuttle to near entrance of the Hutt Palace.",
                        StartEndCompositeType = new PathStartEndCompositeType()
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
                        }
                    }
                };
            }
        }

    }

    public class Voss : IPlanet
    {
        public string Name { get { return "Voss"; } }

        public PlanetId AreaID { get { return PlanetId.Voss; } }

        public string AreaName { get { return "vos_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Jal'Jinis to an Imperial Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -13.7149f, Y = 27.46187f, Z = -22.1371f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 118.9753f, Y = 1.6012f, Z = -79.8429f
                            }
                        }
                    }
                };
            }
        }        
    }

    public class Corellia : IPlanet
    {
        public string Name { get { return "Corellia"; } }

        public PlanetId AreaID { get { return PlanetId.Corellia; } }

        public string AreaName { get { return "crl_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Calagott to Sergeant Calle",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -155.3007f, Y = 4.901f, Z = 189.091f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 303.7735f, Y = 20.1139f, Z = -125.9355f
                            }
                        }
                    }
                };
            }
        }
    }

    public class RepublicFleet : IPlanet
    {
        public string Name { get { return "Republic Fleet"; } }

        public PlanetId AreaID { get { return PlanetId.RepublicFleet; } }

        public string AreaName { get { return "republic_fleet"; } }

        public IList<PathStartEndRequest> Requests
        {
            get 
            { 
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Trooper trainer to Captain Tracer",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType() 
                            {
                                Flags = 0,
                                X = -483.0641f, Y = 69.401f, Z = -455.9018f
                            },
                            End = new PathHopCompositeType() 
                            {
                                Flags = 0,
                                X = -480.7068f, Y = 69.801f, Z = -459.7619f
                            }
                        }
                    }
                }; 
            }
        }
    }

    public class Belsavis : IPlanet
    {
        public string Name { get { return "Belsavis"; } }

        public PlanetId AreaID { get { return PlanetId.Belsavis; } }

        public string AreaName { get { return "bel_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Imperial Medical Droid to another Imperial Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 36.0748f, Y = 16.66702f, Z = -287.7637f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -247.2969f, Y = 18.42914f, Z = -66.1909f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Technician Yaspers to The Gran Exile Republic Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 114.8312f, Y = 30.00613f, Z = 26.1915f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -173.0105f, Y = 30.37509f, Z = 120.2804f
                            }
                        }
                    },
                };
            }
        }
    }

    public class ImperialFleet : IPlanet
    {
        public string Name { get { return "Imperial Fleet"; } }
       
        public PlanetId AreaID { get { return PlanetId.ImperialFleet; } }

        public string AreaName { get { return "imperial_fleet"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Agent Trainer to Bartender",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 479.9584f, Y = 69.401f, Z = 453.3768f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 470.0116f, Y = 70.181f, Z = 468.5824f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Bartender to Agent Trainer",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 470.0116f, Y = 70.181f, Z = 468.5824f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 479.9584f, Y = 69.401f, Z = 453.3768f
                            }
                        }
                    }
                };
            }
        }
    }

    public class Quesh : IPlanet
    {
        public string Name { get { return "Quesh"; } }
        public PlanetId AreaID { get { return PlanetId.Quesh; } }
        public string AreaName { get { return "que_main"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest()
                    {
                        Description = "Imperial Base Medical Droid to Imperial Waystation Medical Droid",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 16.8798f, Y = 8.508716f, Z = 165.7795f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -7.0113f, Y = 6.281129f, Z = 54.0048f
                            }
                        }
                    },
                    new PathStartEndRequest()
                    {
                        Description = "Republic Cantina Vendor Keshani to Captain Jesh",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 73.9392f, Y = 8.6448f, Z = 0.6577f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X =  44.3682f, Y = 10.5775f, Z = 72.12734f
                            }
                        }
                    }
                };
            }
        }
    }

    public class Ilum : IPlanet
    {
        public string Name { get { return "Ilum"; } }

        public PlanetId AreaID { get { return PlanetId.Ilum; } }

        public string AreaName { get { return "ilm_main1"; } }

        public IList<PathStartEndRequest> Requests
        {
            get
            {
                return new List<PathStartEndRequest>()
                {
                    new PathStartEndRequest
                    {
                        Description = "Imperial Base Camp Speeder to Imperial Waystation Speeder",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 37.7573f, Y = -0.4667983f, Z = -46.1142f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -29.6456f, Y = -1.300103f, Z = -20.387f
                            }
                        }
                    },
                    new PathStartEndRequest
                    {
                        Description = "Republic Base Camp Mailbox to Republic Waystation Mailbox",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 52.30401f, Y = -3.181149f, Z = 57.53582f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 0.8723124f, Y = -0.6387f, Z = 20.90055f
                            }
                        }
                    },
                    new PathStartEndRequest
                    {
                        Description = "Imperial Base Camp Speeder to Major Dermian",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 37.7573f, Y = -0.4667983f, Z = -46.1142f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 50.9064f, Y = -0.9466487f, Z = -40.3699f
                            }
                        }
                    },
                    new PathStartEndRequest
                    {
                        Description = "Imperial Waystation Speeder to Imperial Base Camp Speeder",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                               Flags = 0,
                                X = -29.6456f, Y = -1.300103f, Z = -20.387f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = 37.7573f, Y = -0.4667983f, Z = -46.1142f
                            }
                        }
                    },
                    new PathStartEndRequest
                    {
                        Description = "Imperial Shuttle to Talz Communication Network Tower",
                        StartEndCompositeType = new PathStartEndCompositeType()
                        {
                            Start = new PathHopCompositeType()
                            {
                               Flags = 0,
                                X = 37.22869f, Y = -0.4733714f, Z = -43.97261f
                            },
                            End = new PathHopCompositeType()
                            {
                                Flags = 0,
                                X = -18.09827f, Y = -2.41514f, Z = -56.46548f
                            }
                        }
                    },

                };
            }
        }
    }
}