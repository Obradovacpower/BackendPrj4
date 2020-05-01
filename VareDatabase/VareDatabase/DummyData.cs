using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Linq;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase
{
    public class DummyData
    {
        public void InsertDummyData(VareDataModelContext db)
        {
            //Bows
            ItemEntity DeluxeBow = new ItemEntity()
            {
                BuyOutPrice = 5000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Elven Bow BUY NOW",
                UserIdSeller = 12,
                DescriptionOfItem = "Powerful bow that is best at the range of 30-50 meters",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                { 
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Elven"
                    },
                    new TagEntity
                    {
                        Type = "wood"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 200,
                        UserIdBuyer = 30
                    },
                    new BidEntity
                    {
                        Bid = 300,
                        UserIdBuyer = 29
                    }
                }
            };
            db.Add(DeluxeBow);

            ItemEntity BeginnerBow = new ItemEntity()
            {
                BuyOutPrice = 5000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Good beginner bow made of wood",
                UserIdSeller = 35,
                DescriptionOfItem = "Bow for the beginners who are learning to shoot arrows",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Wood"
                    },
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 200,
                        UserIdBuyer = 26
                    },
                    new BidEntity
                    {
                        Bid = 300,
                        UserIdBuyer = 82
                    }
                }
            };
            db.Add(BeginnerBow);

            ItemEntity Longbow = new ItemEntity()
            {
                BuyOutPrice = 5000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                
                Title = "Longbow - 30-50 meters",
                UserIdSeller = 35,
                DescriptionOfItem = "Selling a longbow, great quality!",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Long-Bow"
                    },
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Ranged"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 200,
                        UserIdBuyer = 62
                    },
                    new BidEntity
                    {
                        Bid = 320,
                        UserIdBuyer = 71
                    }
                }
            };
            db.Add(Longbow);

            ItemEntity SeekerQuiver = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Seeker quiver - black",
                UserIdSeller = 64,
                DescriptionOfItem = "Pairs great with a longbow, lighly used",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Quiver"
                    },
                    new TagEntity
                    {
                        Type = "Ranged"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 150,
                        UserIdBuyer = 15
                    },
                    new BidEntity
                    {
                        Bid = 170,
                        UserIdBuyer = 80
                    }
                }
            };
            db.Add(SeekerQuiver);

            ItemEntity HuntingQuiver = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Hunting quiver - Brown",
                UserIdSeller = 37,
                DescriptionOfItem = "can hold up to 15 arrows",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Quiver"
                    },
                    new TagEntity
                    {
                        Type = "Brown"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 160,
                        UserIdBuyer = 11
                    },
                    new BidEntity
                    {
                        Bid = 195,
                        UserIdBuyer = 14
                    }
                }
            };
            db.Add(HuntingQuiver);

            ItemEntity Arrow = new ItemEntity()
            {
                BuyOutPrice = 500,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 6, 5),
                Title = "Arrow with rubber head",
                UserIdSeller = 89,
                DescriptionOfItem = "Arrows, for your bow and quiver, There is a total of 12 arrows all the same quality",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Arrow"
                    },
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Ranged"
                    },
                    new TagEntity
                    {
                        Type = "Quiver"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 40,
                        UserIdBuyer = 11
                    },
                    new BidEntity
                    {
                        Bid = 55,
                        UserIdBuyer = 35
                    }
                }
            };
            db.Add(Arrow);

            ItemEntity Bowset = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2021, 10, 3),
                Title = "Children bow set - beginner",
                UserIdSeller = 77,
                DescriptionOfItem = "Contains 5 arrows, a bow and a small quiver",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Quiver"
                    },
                    new TagEntity
                    {
                        Type = "Ranged"
                    },
                    new TagEntity
                    {
                        Type = "Arrow"
                    },
                    new TagEntity
                    {
                        Type = "Beginner"
                    },
                    new TagEntity
                    {
                        Type = "Set"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 600,
                        UserIdBuyer = 44
                    },
                    new BidEntity
                    {
                        Bid = 650,
                        UserIdBuyer = 6
                    }
                }
            };
            db.Add(Bowset);

            ItemEntity Bowset2 = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = new DateTime(1605, 2, 3),
                ExpirationDate = new DateTime(1605, 5, 12),
                Title = "Bow set - beginner",
                UserIdSeller = 77,
                DescriptionOfItem = "Beginner bow set for adults",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Bow"
                    },
                    new TagEntity
                    {
                        Type = "Quiver"
                    },
                    new TagEntity
                    {
                        Type = "Ranged"
                    },
                    new TagEntity
                    {
                        Type = "Arrow"
                    },
                    new TagEntity
                    {
                        Type = "Beginner"
                    },
                    new TagEntity
                    {
                        Type = "Set"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 400,
                        UserIdBuyer = 65
                    },
                    new BidEntity
                    {
                        Bid = 420,
                        UserIdBuyer = 6
                    }
                }
            };
            db.Add(Bowset2);

            ItemEntity Bowset3 = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Longbow set - beginner",
                UserIdSeller = 98,
                DescriptionOfItem = "Beginner long-bow set for adults, in elven style",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Long-Bow"
                    },
                    new TagEntity
                    {
                        Type = "Quiver"
                    },
                    new TagEntity
                    {
                        Type = "Arrow"
                    },
                    new TagEntity
                    {
                        Type = "Elven"
                    },
                    new TagEntity
                    {
                        Type = "Beginner"
                    },
                    new TagEntity
                    {
                        Type = "Set"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 550,
                        UserIdBuyer = 17
                    },
                    new BidEntity
                    {
                        Bid = 578,
                        UserIdBuyer = 2
                    }
                }
            };
            db.Add(Bowset3);

            //melee
            ItemEntity Warglaive = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = new DateTime(2007, 5, 3),
                ExpirationDate = new DateTime(2007, 12, 24),
                Title = "Warglaives of Azzinoth",
                UserIdSeller = 97,
                DescriptionOfItem = "Drops from BT, and is recreated here in IRL",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Demon-Hunter"
                    },
                    new TagEntity
                    {
                        Type = "One-handed"
                    },
                    new TagEntity
                    {
                        Type = "Warglaive"
                    },
                    new TagEntity
                    {
                        Type = "Melee"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 350,
                        UserIdBuyer = 71
                    },
                    new BidEntity
                    {
                        Bid = 370,
                        UserIdBuyer = 28
                    }
                }
            };
            db.Add(Warglaive);

            DateTime dt = new DateTime(2020, 3, 4);
            ItemEntity OneHandSword = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = dt,
                ExpirationDate = dt.AddDays(10),
                Title = "One handed sword - leather handle",
                UserIdSeller = 22,
                DescriptionOfItem = "One handed sword that is used together with a shield",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Sword"
                    },
                    new TagEntity
                    {
                        Type = "One-hand"
                    },
                    new TagEntity
                    {
                        Type = "Leather-grip"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 550,
                        UserIdBuyer = 71
                    },
                    new BidEntity
                    {
                        Bid = 575,
                        UserIdBuyer = 13
                    }
                }
            };
            db.Add(OneHandSword);

            ItemEntity TwoHandSword = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Two handed sword - leather handle",
                UserIdSeller = 22,
                DescriptionOfItem = "Original Zwei-Hander for RP",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "two-handed"
                    },
                    new TagEntity
                    {
                        Type = "Sword"
                    },
                    new TagEntity
                    {
                        Type = "Melee"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 410,
                        UserIdBuyer = 21
                    },
                    new BidEntity
                    {
                        Bid = 440,
                        UserIdBuyer = 52
                    }
                }
            };
            db.Add(TwoHandSword);

            ItemEntity RoundShieldTree = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Round one handed shield made of wood",
                UserIdSeller = 50,
                DescriptionOfItem = "Rounded shield made of wood and edge of metal",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Shield"
                    },
                    new TagEntity
                    {
                        Type = "Melee"
                    },
                    new TagEntity
                    {
                        Type = "Wood"
                    },
                    new TagEntity
                    {
                        Type = "Metal"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 300,
                        UserIdBuyer = 21
                    },
                    new BidEntity
                    {
                        Bid = 315,
                        UserIdBuyer = 42
                    }
                }
            };
            db.Add(RoundShieldTree);

            ItemEntity RoundShieldMetal = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Round one handed shield of metal",
                UserIdSeller = 50,
                DescriptionOfItem = "Rounded shield for one hand made of metal, has a crest of an eagle",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Shield"
                    },
                    new TagEntity
                    {
                        Type = "one-hand"
                    },
                    new TagEntity
                    {
                        Type = "metal"
                    },
                    new TagEntity
                    {
                        Type = "Crest"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 260,
                        UserIdBuyer = 4
                    },
                    new BidEntity
                    {
                        Bid = 280,
                        UserIdBuyer = 46
                    }
                }
            };
            db.Add(RoundShieldMetal);

            ItemEntity KnightShield = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Knight shield of metal",
                UserIdSeller = 50,
                DescriptionOfItem = "Knight shield made of metal with straps so it can be put on your back",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Shield"
                    },
                    new TagEntity
                    {
                        Type = "Metal"
                    },
                    new TagEntity
                    {
                        Type = "Straps"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 420,
                        UserIdBuyer = 4
                    },
                    new BidEntity
                    {
                        Bid = 450,
                        UserIdBuyer = 25
                    }
                }
            };
            db.Add(KnightShield);

            string[] tags = { "tower", "square", "metal" };
            string[] images = { "empty" };
            
            /*ItemEntity SquareShieldMetal = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 12, 24),
                Title = "Square shield of metal",
                UserIdSeller = 69,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Square shield made of metal. Good for roman formations",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 460,
                        UserIdBuyer = 1
                    },
                    new BidEntity
                    {
                        Bid = 480,
                        UserIdBuyer = 20
                    }
                }
            };
            db.Add(SquareShieldMetal);


            //Rustning/udklædning

            ItemEntity BracersBrownLeather = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 9, 5),
                Type = "Bracers",
                Title = "Brown leather bracers",
                UserIdSeller = 55,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Brown lightweight bracers made of leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 250,
                        UserIdBuyer = 14
                    },
                    new BidEntity
                    {
                        Bid = 270,
                        UserIdBuyer = 5
                    }
                }
            };
            db.Add(BracersBrownLeather);

            /*ItemEntity BracersBlackLeather = new ItemEntity();
            BracersBlackLeather.Type = "Bracers";
            BracersBlackLeather.Description.descriptionOfItem = "Black lightweight bracers made of leather";
            BracersBlackLeather.Description.imageOfItem = "empty";
            BracersBlackLeather.Description.title = "Black leather bracers";
            BracersBlackLeather.Bid.userID_forSeller = 4444;
            BracersBlackLeather.Bid.userID_forLastBid = 1111;
            BracersBlackLeather.Bid.price = 400;
            db.Add(BracersBlackLeather);
            ItemEntity BracersBlackLeather = new ItemEntity()
            {
                BuyOutPrice = 1500,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 11, 27),
                Type = "Bracers",
                Title = "Black leather bracers",
                UserIdSeller = 55,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Black lightweight bracers made of leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 230,
                        UserIdBuyer = 19
                    },
                    new BidEntity
                    {
                        Bid = 240,
                        UserIdBuyer = 53
                    }
                }
            };
            db.Add(BracersBlackLeather);

            /*ItemEntity BracersMetal = new ItemEntity();
            BracersMetal.Type = "Bracers";
            BracersMetal.Description.descriptionOfItem = "Bracers made of metal";
            BracersMetal.Description.imageOfItem = "empty";
            BracersMetal.Description.title = "Metal bracers";
            BracersMetal.Bid.userID_forSeller = 4444;
            BracersMetal.Bid.userID_forLastBid = 3333;
            BracersMetal.Bid.price = 500;
            db.Add(BracersMetal);

            ItemEntity BracersMetal = new ItemEntity()
            {
                BuyOutPrice = 1500,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 1, 20),
                Type = "Bracers",
                Title = "Metal bracers",
                UserIdSeller = 55,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Bracers made of metal",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 240,
                        UserIdBuyer = 24
                    },
                    new BidEntity
                    {
                        Bid = 260,
                        UserIdBuyer = 76
                    }
                }
            };
            db.Add(BracersMetal);

            /*ItemEntity BootsBrownLeather = new ItemEntity();
            BootsBrownLeather.Type = "Boots";
            BootsBrownLeather.Description.descriptionOfItem = "Lightweight boots made of brown leather";
            BootsBrownLeather.Description.imageOfItem = "empty";
            BootsBrownLeather.Description.title = "Brown leather boots";
            BootsBrownLeather.Bid.userID_forSeller = 4444;
            BootsBrownLeather.Bid.userID_forLastBid = 2222;
            BootsBrownLeather.Bid.price = 450;
            db.Add(BootsBrownLeather);
            ItemEntity BootsBrownLeather = new ItemEntity()
            {
                BuyOutPrice = 1750,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 7, 12),
                Type = "Boots",
                Title = "Brown leather boots",
                UserIdSeller = 62,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Lightweight boots made of brown leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 360,
                        UserIdBuyer = 61
                    },
                    new BidEntity
                    {
                        Bid = 395,
                        UserIdBuyer = 15
                    }
                }
            };
            db.Add(BootsBrownLeather);

            /*ItemEntity BootsBlackLeather = new ItemEntity();
            BootsBlackLeather.Type = "Boots";
            BootsBlackLeather.Description.descriptionOfItem = "Lightweight boots made of black leather";
            BootsBlackLeather.Description.imageOfItem = "empty";
            BootsBlackLeather.Description.title = "Black leather boots";
            BootsBlackLeather.Bid.userID_forSeller = 4444;
            BootsBlackLeather.Bid.userID_forLastBid = 5555;
            BootsBlackLeather.Bid.price = 450;
            db.Add(BootsBlackLeather);
            ItemEntity BootsBlackLeather = new ItemEntity()
            {
                BuyOutPrice = 1750,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 2, 7),
                Type = "Boots",
                Title = "Black leather boots",
                UserIdSeller = 52,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Lightweight boots made of black leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 400,
                        UserIdBuyer = 18
                    },
                    new BidEntity
                    {
                        Bid = 410,
                        UserIdBuyer = 61
                    }
                }
            };
            db.Add(BootsBlackLeather);

            /*ItemEntity BootsMetal = new ItemEntity();
            BootsMetal.Type = "Boots";
            BootsMetal.Description.descriptionOfItem = "Heavy boots made of metal";
            BootsMetal.Description.imageOfItem = "empty";
            BootsMetal.Description.title = "Metal boots";
            BootsMetal.Bid.userID_forSeller = 4444;
            BootsMetal.Bid.userID_forLastBid = 5555;
            BootsMetal.Bid.price = 600;
            db.Add(BootsMetal);
            ItemEntity BootsMetal = new ItemEntity()
            {
                BuyOutPrice = 1750,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 7, 3),
                Type = "Boots",
                Title = "Metal boots",
                UserIdSeller = 82,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Heavy boots made of metal",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 400,
                        UserIdBuyer = 18
                    },
                    new BidEntity
                    {
                        Bid = 410,
                        UserIdBuyer = 61
                    }
                }
            };
            db.Add(BootsMetal);

            /*ItemEntity BreastplateBrownLeather = new ItemEntity();
            BreastplateBrownLeather.Type = "Breastplate";
            BreastplateBrownLeather.Description.descriptionOfItem = "Lightweight breastplate made of hardened brown leather";
            BreastplateBrownLeather.Description.imageOfItem = "empty";
            BreastplateBrownLeather.Description.title = "Breastplate - Brown leather";
            BreastplateBrownLeather.Bid.userID_forSeller = 4444;
            BreastplateBrownLeather.Bid.userID_forLastBid = 1111;
            BreastplateBrownLeather.Bid.price = 1200;
            db.Add(BreastplateBrownLeather);

            ItemEntity BreastplateBrownLeather = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 8, 8),
                Type = "Breastplate",
                Title = "Breastplate - Brown leather",
                UserIdSeller = 57,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Lightweight breastplate made of hardened brown leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 1200,
                        UserIdBuyer = 90
                    },
                    new BidEntity
                    {
                        Bid = 1250,
                        UserIdBuyer = 99
                    }
                }
            };
            db.Add(BreastplateBrownLeather);

            /*ItemEntity BreastplateBlackLeather = new ItemEntity();
            BreastplateBlackLeather.Type = "Breastplate";
            BreastplateBlackLeather.Description.descriptionOfItem = "Lightweight breastplate made of hardened black leather";
            BreastplateBlackLeather.Description.imageOfItem = "empty";
            BreastplateBlackLeather.Description.title = "Breastplate - Black leather";
            BreastplateBrownLeather.Bid.userID_forSeller = 4444;
            BreastplateBlackLeather.Bid.userID_forLastBid = 5555;
            BreastplateBlackLeather.Bid.price = 1200;
            db.Add(BreastplateBlackLeather);

            ItemEntity BreastplateBlackLeather = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 6, 1),
                Type = "Breastplate",
                Title = "Breastplate - Black leather",
                UserIdSeller = 57,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Lightweight breastplate made of hardened black leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 1340,
                        UserIdBuyer = 34
                    },
                    new BidEntity
                    {
                        Bid = 1400,
                        UserIdBuyer = 90
                    }
                }
            };
            db.Add(BreastplateBlackLeather);

            /*ItemEntity BreastplateMetal = new ItemEntity();
            BreastplateMetal.Type = "Breastplate";
            BreastplateMetal.Description.descriptionOfItem = "Heavy breastplate made of metal";
            BreastplateMetal.Description.imageOfItem = "empty";
            BreastplateMetal.Description.title = "Breastplate - Metal";
            BreastplateMetal.Bid.userID_forSeller = 3333;
            BreastplateMetal.Bid.userID_forLastBid = 4444;
            BreastplateMetal.Bid.price = 1500;
            db.Add(BreastplateMetal);

            ItemEntity BreastplateMetal = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 3, 26),
                Type = "Breastplate",
                Title = "Breastplate - Metal",
                UserIdSeller = 57,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Heavy breastplate made of metal",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 1600,
                        UserIdBuyer = 34
                    },
                    new BidEntity
                    {
                        Bid = 1700,
                        UserIdBuyer = 90
                    }
                }
            };
            db.Add(BreastplateMetal);

            /*ItemEntity HelmetRoman = new ItemEntity();
            HelmetRoman.Type = "Helmet";
            HelmetRoman.Description.descriptionOfItem = "Roman helmet with red ridge for protection of the head";
            HelmetRoman.Description.imageOfItem = "empty";
            HelmetRoman.Description.title = "Roman ridge helmet";
            HelmetRoman.Bid.userID_forSeller = 3333;
            HelmetRoman.Bid.userID_forLastBid = 2222;
            HelmetRoman.Bid.price = 1200;
            db.Add(HelmetRoman);
            ItemEntity HelmetRoman = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = new DateTime(2020, 3, 14),
                ExpirationDate = new DateTime(2020, 3, 21),
                Type = "Helmet",
                Title = "Roman ridge helmet",
                UserIdSeller = 57,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Roman helmet with red ridge for protection of the head",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 760,
                        UserIdBuyer = 56
                    },
                    new BidEntity
                    {
                        Bid = 800,
                        UserIdBuyer = 59
                    }
                }
            };
            db.Add(HelmetRoman);

            /*ItemEntity HelmetViking = new ItemEntity();
            HelmetViking.Type = "Helmet";
            HelmetViking.Description.descriptionOfItem = "Viking helmet for protection of the head";
            HelmetViking.Description.imageOfItem = "empty";
            HelmetViking.Description.title = "Viking helmet";
            HelmetViking.Bid.userID_forSeller = 3333;
            HelmetViking.Bid.userID_forLastBid = 1111
            HelmetViking.Bid.price = 1000;
            db.Add(HelmetViking);

            ItemEntity HelmetViking = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = new DateTime(2020, 8, 1),
                ExpirationDate = new DateTime(2020, 8, 21),
                Type = "Helmet",
                Title = "Viking helmet",
                UserIdSeller = 57,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Viking helmet for protection of the head",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 600,
                        UserIdBuyer = 41
                    },
                    new BidEntity
                    {
                        Bid = 630,
                        UserIdBuyer = 69
                    }
                }
            };
            db.Add(HelmetViking);

            /*ItemEntity HelmetKnight = new ItemEntity();
            HelmetKnight.Type = "Helmet";
            HelmetKnight.Description.descriptionOfItem = "Knight helmet that covers the whole face";
            HelmetKnight.Description.imageOfItem = "empty";
            HelmetKnight.Description.title = "Knight helmet";
            HelmetKnight.Bid.userID_forSeller = 3333;
            HelmetKnight.Bid.userID_forLastBid = 5555;
            HelmetKnight.Bid.price = 1300;
            db.Add(HelmetKnight);

            ItemEntity HelmetKnight = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = new DateTime(2020, 8, 30),
                ExpirationDate = new DateTime(2020, 9, 30),
                Type = "Helmet",
                Title = "Knight helmet",
                UserIdSeller = 69,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Knight helmet that covers the whole face",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 550,
                        UserIdBuyer = 39
                    },
                    new BidEntity
                    {
                        Bid = 580,
                        UserIdBuyer = 94
                    }
                }
            };
            db.Add(HelmetKnight);

            /*ItemEntity GlovesBrownLeather = new ItemEntity();
            GlovesBrownLeather.Type = "Gloves";
            GlovesBrownLeather.Description.descriptionOfItem = "Medieval gloves made of brown leather";
            GlovesBrownLeather.Description.imageOfItem = "empty";
            GlovesBrownLeather.Description.title = "Gloves - Brown leather";
            GlovesBrownLeather.Bid.userID_forSeller = 5555;
            GlovesBrownLeather.Bid.userID_forLastBid = 3333;
            GlovesBrownLeather.Bid.price = 300;
            db.Add(GlovesBrownLeather);

            ItemEntity GlovesBrownLeather = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = new DateTime(2020, 3, 20),
                ExpirationDate = new DateTime(2020, 5, 3),
                Type = "Gloves",
                Title = "Gloves - Brown leather",
                UserIdSeller = 75,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Medieval gloves made of brown leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 430,
                        UserIdBuyer = 8
                    },
                    new BidEntity
                    {
                        Bid = 480,
                        UserIdBuyer = 43
                    }
                }
            };
            db.Add(GlovesBrownLeather);

            /*ItemEntity GlovesBlackLeather = new ItemEntity();
            GlovesBlackLeather.Type = "Gloves";
            GlovesBlackLeather.Description.descriptionOfItem = "Medieval gloves made of black leather";
            GlovesBlackLeather.Description.imageOfItem = "empty";
            GlovesBlackLeather.Description.title = "Gloves - Black leather";
            GlovesBlackLeather.Bid.userID_forSeller = 5555;
            GlovesBlackLeather.Bid.userID_forLastBid = 3333;
            GlovesBlackLeather.Bid.price = 300;
            db.Add(GlovesBlackLeather);

            ItemEntity GlovesBlackLeather = new ItemEntity()
            {
                BuyOutPrice = 4000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 10, 13),
                Type = "Gloves",
                Title = "Gloves - Black leather",
                UserIdSeller = 16,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Medieval gloves made of black leather",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 550,
                        UserIdBuyer = 39
                    },
                    new BidEntity
                    {
                        Bid = 580,
                        UserIdBuyer = 94
                    }
                }
            };
            db.Add(GlovesBlackLeather);

            /*ItemEntity GlovesMetal = new ItemEntity();
            GlovesBlackLeather.Type = "Gloves";
            GlovesBlackLeather.Description.descriptionOfItem = "Medieval gloves made of metal";
            GlovesBlackLeather.Description.imageOfItem = "empty";
            GlovesBlackLeather.Description.title = "Gloves - Metal";
            GlovesBlackLeather.Bid.userID_forSeller = 5555;
            GlovesBlackLeather.Bid.userID_forLastBid = 1111;
            GlovesBlackLeather.Bid.price = 450;
            db.Add(GlovesMetal);
            ItemEntity GlovesMetal = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = DateTime.Now,
                ExpirationDate = new DateTime(2020, 4, 18),
                Type = "Gloves",
                Title = "Gloves - Metal",
                UserIdSeller = 16,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Medieval gloves made of metal",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 600,
                        UserIdBuyer = 60
                    },
                    new BidEntity
                    {
                        Bid = 670,
                        UserIdBuyer = 44
                    }
                }
            };
            db.Add(GlovesMetal);


            //Tilbehør - Ildkugler, Eliksirer, elverøre, 

            /*ItemEntity ElixirFlaskLarge = new ItemEntity();
            ElixirFlaskLarge.Type = "Accesories";
            ElixirFlaskLarge.Description.descriptionOfItem = "Large glass flask for elixirs";
            ElixirFlaskLarge.Description.imageOfItem = "empty";
            ElixirFlaskLarge.Description.title = "Large elixir flask";
            ElixirFlaskLarge.Bid.userID_forSeller = 2222;
            ElixirFlaskLarge.Bid.userID_forLastBid = 1111;
            ElixirFlaskLarge.Bid.price = 50;
            db.Add(ElixirFlaskLarge);

            ItemEntity ElixirFlaskLarge = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = new DateTime(2020, 7, 19),
                ExpirationDate = new DateTime(2020, 8, 10),
                Type = "Accesories",
                Title = "Large elixir flask",
                UserIdSeller = 70,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Large glass flask for elixirs",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 40,
                        UserIdBuyer = 19
                    },
                    new BidEntity
                    {
                        Bid = 45,
                        UserIdBuyer = 45
                    }
                }
            };
            db.Add(ElixirFlaskLarge);

            /*ItemEntity ElixirFlaskSmall = new ItemEntity();
            ElixirFlaskSmall.Type = "Accesories";
            ElixirFlaskSmall.Description.descriptionOfItem = "Small glass flask for elixirs";
            ElixirFlaskSmall.Description.imageOfItem = "empty";
            ElixirFlaskSmall.Description.title = "Small elixir flask";
            ElixirFlaskSmall.Bid.userID_forSeller = 5555;
            ElixirFlaskSmall.Bid.userID_forLastBid = 1111;
            ElixirFlaskSmall.Bid.price = 25;
            db.Add(ElixirFlaskSmall);

            ItemEntity ElixirFlaskSmall = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = new DateTime(2020, 3, 1),
                ExpirationDate = new DateTime(2020, 3, 11),
                Type = "Accesories",
                Title = "Small elixir flask",
                UserIdSeller = 70,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Small glass flask for elixirs",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 20,
                        UserIdBuyer = 20
                    },
                    new BidEntity
                    {
                        Bid = 30,
                        UserIdBuyer = 32
                    }
                }
            };
            db.Add(ElixirFlaskSmall);

            /*ItemEntity FlaskBag = new ItemEntity();
            ElixirFlaskSmall.Type = "Accesories";
            ElixirFlaskSmall.Description.descriptionOfItem = "Bag to hold you elixir flasks";
            ElixirFlaskSmall.Description.imageOfItem = "empty";
            ElixirFlaskSmall.Description.title = "Elixir flask bag";
            ElixirFlaskSmall.Bid.userID_forSeller = 4444;
            ElixirFlaskSmall.Bid.userID_forLastBid = 2222;
            ElixirFlaskSmall.Bid.price = 350;
            db.Add(ElixirFlaskSmall);

            ItemEntity FlaskBag = new ItemEntity()
            {
                BuyOutPrice = 2000,
                DateCreated = new DateTime(2020, 3, 2),
                ExpirationDate = new DateTime(2020, 3, 28),
                Type = "Accesories",
                Title = "Elixir flask bag",
                UserIdSeller = 55,
                Description = new ImageEntity()
                {
                    DescriptionOfItem = "Bag to hold you elixir flasks",
                    ImageOfItem = "empty"
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 190,
                        UserIdBuyer = 64
                    },
                    new BidEntity
                    {
                        Bid = 240,
                        UserIdBuyer = 47
                    }
                }
            };
            db.Add(FlaskBag);

            ItemEntity DrinkingHorn = new ItemEntity()
            {
                BuyOutPrice = 3000,
                DateCreated = new DateTime(2020, 5, 18),
                ExpirationDate = new DateTime(2020, 5, 25),
                Title = "Drinking Horn from a cow",
                UserIdSeller = 1,
                DescriptionOfItem = "Drops from BT, and is recreated here in IRL",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Accessory"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 150,
                        UserIdBuyer = 23
                    },
                    new BidEntity
                    {
                        Bid = 200,
                        UserIdBuyer = 14
                    }
                }
            };
            db.Add(DrinkingHorn);

            ItemEntity ElfEars = new ItemEntity()
            {
                BuyOutPrice = 600,
                DateCreated = new DateTime(2020, 9,20),
                ExpirationDate = new DateTime(2020, 9, 29),
                Title = "Elf Ears ",
                UserIdSeller = 99,
                DescriptionOfItem = "Perfect for creating an elf character in any RP setting",
                Images = new List<ImageEntity>
                {
                    new ImageEntity
                    {
                        ImageOfItem = "empty"
                    }
                },
                Tags = new List<TagEntity>
                {
                    new TagEntity
                    {
                        Type = "Elven"
                    },
                    new TagEntity
                    {
                        Type = "Accessory"
                    },
                    new TagEntity
                    {
                        Type = "Ears"
                    }
                },
                Bids = new List<BidEntity>
                {
                    new BidEntity
                    {
                        Bid = 10,
                        UserIdBuyer = 25
                    },
                    new BidEntity
                    {
                        Bid = 90000,
                        UserIdBuyer = 85
                    }
                }
            };
            db.Add(FlaskBag);*/
        }
    }
}

