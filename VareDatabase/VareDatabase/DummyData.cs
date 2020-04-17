using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase
{
    public class DummyData
    {
        public void InsertDummyData()
        {
            using var db = new VareDataModelContext();

            //Bows
            ItemEntity DeluxeBow = new ItemEntity();
            DeluxeBow.Type = "Bow";
            DeluxeBow.Description.descriptionOfItem = "Powerful bow that is best at the range of 30-50 meters";
            DeluxeBow.Description.imageOfItem = "empty";
            DeluxeBow.Description.title = "Deluxebow - 30-50 meters";
            DeluxeBow.Bid.userID_forSeller = 2222;
            DeluxeBow.Bid.userID_forLastBid = 1111;
            DeluxeBow.Bid.price = 300;
            db.Add(DeluxeBow);

            ItemEntity BeginnerBow = new ItemEntity();
            BeginnerBow.Type = "Bow";
            BeginnerBow.Description.descriptionOfItem = "Bow for the beginners who are learning to shoot arrows";
            BeginnerBow.Description.imageOfItem = "empty";
            BeginnerBow.Description.title = "Begginer bow - 10-30 meters";
            BeginnerBow.Bid.userID_forSeller = 2222;
            BeginnerBow.Bid.userID_forLastBid = 5555;
            BeginnerBow.Bid.price = 300;
            db.Add(BeginnerBow);

            ItemEntity Longbow = new ItemEntity();
            Longbow.Type = "Bow";
            Longbow.Description.descriptionOfItem = "Longbow that is best at range of 50-100 meters";
            Longbow.Description.imageOfItem = "empty";
            Longbow.Description.title = "Longbow - 30-50 meters";
            Longbow.Bid.userID_forSeller = 1111;
            Longbow.Bid.userID_forLastBid = 3333;
            Longbow.Bid.price = 450;
            db.Add(Longbow);

            ItemEntity SeekerQuiver = new ItemEntity();
            SeekerQuiver.Type = "Quiver";
            SeekerQuiver.Description.descriptionOfItem = "Quiver to hold your arrows and hold on your back";
            SeekerQuiver.Description.imageOfItem = "empty";
            SeekerQuiver.Description.title = "Seeker quiver - black";
            SeekerQuiver.Bid.userID_forSeller = 1111;
            SeekerQuiver.Bid.userID_forLastBid = 4444;
            SeekerQuiver.Bid.price = 150;
            db.Add(SeekerQuiver);

            ItemEntity HuntingQuiver = new ItemEntity();
            HuntingQuiver.Type = "Quiver";
            HuntingQuiver.Description.descriptionOfItem = "Quiver for hunting to hold your arrows and hold on your back";
            HuntingQuiver.Description.imageOfItem = "empty";
            HuntingQuiver.Description.title = "Hunting quiver - Brown";
            HuntingQuiver.Bid.userID_forSeller = 1111;
            HuntingQuiver.Bid.userID_forLastBid = 4444;
            HuntingQuiver.Bid.price = 175;
            db.Add(HuntingQuiver);

            ItemEntity Arrow = new ItemEntity();
            Arrow.Type = "Arrow";
            Arrow.Description.descriptionOfItem = "Arrow with rubber head. Made for bows that shoot between 30-50 meters";
            Arrow.Description.imageOfItem = "empty";
            Arrow.Description.title = "Arrow with rubber head - 30-50 meters";
            Arrow.Bid.userID_forSeller = 2222;
            Arrow.Bid.userID_forLastBid = 4444;
            Arrow.Bid.price = 25;
            db.Add(Arrow);

            ItemEntity Bowset = new ItemEntity();
            Bowset.Type = "Bowset";
            Bowset.Description.descriptionOfItem = "Beginner bow set for children";
            Bowset.Description.imageOfItem = "empty";
            Bowset.Description.title = "Children bow set - beginner";
            Bowset.Bid.userID_forSeller = 2222;
            Bowset.Bid.userID_forLastBid = 5555;
            Bowset.Bid.price = 500;
            db.Add(Bowset);

            ItemEntity Bowset2 = new ItemEntity();
            Bowset2.Type = "Bowset";
            Bowset2.Description.descriptionOfItem = "Beginner bow set for adults";
            Bowset2.Description.imageOfItem = "empty";
            Bowset2.Description.title = "Bow set - beginner";
            Bowset2.Bid.userID_forSeller = 2222;
            Bowset2.Bid.userID_forLastBid = 5555;
            Bowset2.Bid.price = 500;
            db.Add(Bowset2);

            ItemEntity Bowset3 = new ItemEntity();
            Bowset3.Type = "Bowset";
            Bowset3.Description.descriptionOfItem = "Beginner longbow set for adults";
            Bowset3.Description.imageOfItem = "empty";
            Bowset3.Description.title = "Longbow set - beginner";
            Bowset3.Bid.userID_forSeller = 2222;
            Bowset3.Bid.userID_forLastBid = 5555;
            Bowset3.Bid.price = 600;
            db.Add(Bowset3);

            ItemEntity Dagger = new ItemEntity();
            Dagger.Type = "Dagger";
            Dagger.Description.descriptionOfItem = "Small dagger to used by theifs and scoundrels";
            Dagger.Description.imageOfItem = "empty";
            Dagger.Description.title = "Dagger - leather handle";
            Dagger.Bid.userID_forSeller = 1111;
            Dagger.Bid.userID_forLastBid = 3333;
            Dagger.Bid.price = 200;
            db.Add(Dagger);

            //Sværd
            ItemEntity OneHandSword = new ItemEntity();
            OneHandSword.Type = "Sword";
            OneHandSword.Description.descriptionOfItem = "One handed sword that is used together with a shield";
            OneHandSword.Description.imageOfItem = "empty";
            OneHandSword.Description.title = "One handed sword - leather handle";
            OneHandSword.Bid.userID_forSeller = 1111;
            OneHandSword.Bid.userID_forLastBid = 3333;
            OneHandSword.Bid.price = 200;
            db.Add(OneHandSword);

            ItemEntity TwoHandSword = new ItemEntity();
            TwoHandSword.Type = "Sword";
            TwoHandSword.Description.descriptionOfItem = "Two handed sword that for combat";
            TwoHandSword.Description.imageOfItem = "empty";
            TwoHandSword.Description.title = "Two handed sword - leather handle";
            TwoHandSword.Bid.userID_forSeller = 3333;
            TwoHandSword.Bid.userID_forLastBid = 4444;
            TwoHandSword.Bid.price = 300;
            db.Add(TwoHandSword);

            //Skjold
            ItemEntity RoundShieldTree = new ItemEntity();
            RoundShieldTree.Type = "Shield";
            RoundShieldTree.Description.descriptionOfItem = "Round shield for one hand made af tree with edge of metal";
            RoundShieldTree.Description.imageOfItem = "empty";
            RoundShieldTree.Description.title = "Round one handed shield of tree";
            RoundShieldTree.Bid.userID_forSeller = 5555;
            RoundShieldTree.Bid.userID_forLastBid = 1111;
            RoundShieldTree.Bid.price = 275;
            db.Add(RoundShieldTree);

            ItemEntity RoundShieldMetal = new ItemEntity();
            RoundShieldMetal.Type = "Shield";
            RoundShieldMetal.Description.descriptionOfItem = "Round shield for one hand made af metal";
            RoundShieldMetal.Description.imageOfItem = "empty";
            RoundShieldMetal.Description.title = "Round one handed shield of metal";
            RoundShieldMetal.Bid.userID_forSeller = 5555;
            RoundShieldMetal.Bid.userID_forLastBid = 3333;
            RoundShieldMetal.Bid.price = 300;
            db.Add(RoundShieldMetal);

            ItemEntity KnightShield = new ItemEntity();
            KnightShield.Type = "Shield";
            KnightShield.Description.descriptionOfItem = "Knight shield made of metal with straps so it can be put on your back";
            KnightShield.Description.imageOfItem = "empty";
            KnightShield.Description.title = "Knight shield of metal";
            KnightShield.Bid.userID_forSeller = 2222;
            KnightShield.Bid.userID_forLastBid = 3333;
            KnightShield.Bid.price = 275;
            db.Add(KnightShield);


            ItemEntity SquareShieldMetal = new ItemEntity();
            SquareShieldMetal.Type = "Shield";
            SquareShieldMetal.Description.descriptionOfItem = "Square shield made of metal. Good for roman formations";
            SquareShieldMetal.Description.imageOfItem = "empty";
            SquareShieldMetal.Description.title = "Square shield of metal";
            SquareShieldMetal.Bid.userID_forSeller = 5555;
            SquareShieldMetal.Bid.userID_forLastBid = 2222;
            SquareShieldMetal.Bid.price = 325;
            db.Add(SquareShieldMetal);


            //Rustning/udklædning
            ItemEntity BracersBrownLeather = new ItemEntity();
            BracersBrownLeather.Type = "Bracers";
            BracersBrownLeather.Description.descriptionOfItem = "Brown lightweight bracers made of leather";
            BracersBrownLeather.Description.imageOfItem = "empty";
            BracersBrownLeather.Description.title = "Brown leather bracers";
            BracersBrownLeather.Bid.userID_forSeller = 4444;
            BracersBrownLeather.Bid.userID_forLastBid = 2222;
            BracersBrownLeather.Bid.price = 400;
            db.Add(BracersBrownLeather);

            ItemEntity BracersBlackLeather = new ItemEntity();
            BracersBlackLeather.Type = "Bracers";
            BracersBlackLeather.Description.descriptionOfItem = "Black lightweight bracers made of leather";
            BracersBlackLeather.Description.imageOfItem = "empty";
            BracersBlackLeather.Description.title = "Black leather bracers";
            BracersBlackLeather.Bid.userID_forSeller = 4444;
            BracersBlackLeather.Bid.userID_forLastBid = 1111;
            BracersBlackLeather.Bid.price = 400;
            db.Add(BracersBlackLeather);

            ItemEntity BracersMetal = new ItemEntity();
            BracersMetal.Type = "Bracers";
            BracersMetal.Description.descriptionOfItem = "Bracers made of metal";
            BracersMetal.Description.imageOfItem = "empty";
            BracersMetal.Description.title = "Metal bracers";
            BracersMetal.Bid.userID_forSeller = 4444;
            BracersMetal.Bid.userID_forLastBid = 3333;
            BracersMetal.Bid.price = 500;
            db.Add(BracersMetal);

            ItemEntity BootsBrownLeather = new ItemEntity();
            BootsBrownLeather.Type = "Boots";
            BootsBrownLeather.Description.descriptionOfItem = "Lightweight boots made of brown leather";
            BootsBrownLeather.Description.imageOfItem = "empty";
            BootsBrownLeather.Description.title = "Brown leather boots";
            BootsBrownLeather.Bid.userID_forSeller = 4444;
            BootsBrownLeather.Bid.userID_forLastBid = 2222;
            BootsBrownLeather.Bid.price = 450;
            db.Add(BootsBrownLeather);

            ItemEntity BootsBlackLeather = new ItemEntity();
            BootsBlackLeather.Type = "Boots";
            BootsBlackLeather.Description.descriptionOfItem = "Lightweight boots made of black leather";
            BootsBlackLeather.Description.imageOfItem = "empty";
            BootsBlackLeather.Description.title = "Black leather boots";
            BootsBlackLeather.Bid.userID_forSeller = 4444;
            BootsBlackLeather.Bid.userID_forLastBid = 5555;
            BootsBlackLeather.Bid.price = 450;
            db.Add(BootsBlackLeather);

            ItemEntity BootsMetal = new ItemEntity();
            BootsMetal.Type = "Boots";
            BootsMetal.Description.descriptionOfItem = "Heavy boots made of metal";
            BootsMetal.Description.imageOfItem = "empty";
            BootsMetal.Description.title = "Metal boots";
            BootsMetal.Bid.userID_forSeller = 4444;
            BootsMetal.Bid.userID_forLastBid = 5555;
            BootsMetal.Bid.price = 600;
            db.Add(BootsMetal);

            ItemEntity BreastplateBrownLeather = new ItemEntity();
            BreastplateBrownLeather.Type = "Breastplate";
            BreastplateBrownLeather.Description.descriptionOfItem = "Lightweight breastplate made of hardened brown leather";
            BreastplateBrownLeather.Description.imageOfItem = "empty";
            BreastplateBrownLeather.Description.title = "Breastplate - Brown leather";
            BreastplateBrownLeather.Bid.userID_forSeller = 4444;
            BreastplateBrownLeather.Bid.userID_forLastBid = 1111;
            BreastplateBrownLeather.Bid.price = 1200;
            db.Add(BreastplateBrownLeather);

            ItemEntity BreastplateBlackLeather = new ItemEntity();
            BreastplateBlackLeather.Type = "Breastplate";
            BreastplateBlackLeather.Description.descriptionOfItem = "Lightweight breastplate made of hardened black leather";
            BreastplateBlackLeather.Description.imageOfItem = "empty";
            BreastplateBlackLeather.Description.title = "Breastplate - Black leather";
            BreastplateBrownLeather.Bid.userID_forSeller = 4444;
            BreastplateBlackLeather.Bid.userID_forLastBid = 5555;
            BreastplateBlackLeather.Bid.price = 1200;
            db.Add(BreastplateBlackLeather);

            ItemEntity BreastplateMetal = new ItemEntity();
            BreastplateMetal.Type = "Breastplate";
            BreastplateMetal.Description.descriptionOfItem = "Heavy breastplate made of metal";
            BreastplateMetal.Description.imageOfItem = "empty";
            BreastplateMetal.Description.title = "Breastplate - Metal";
            BreastplateMetal.Bid.userID_forSeller = 3333;
            BreastplateMetal.Bid.userID_forLastBid = 4444;
            BreastplateMetal.Bid.price = 1500;
            db.Add(BreastplateMetal);

            ItemEntity HelmetRoman = new ItemEntity();
            HelmetRoman.Type = "Helmet";
            HelmetRoman.Description.descriptionOfItem = "Roman helmet with red ridge for protection of the head";
            HelmetRoman.Description.imageOfItem = "empty";
            HelmetRoman.Description.title = "Roman ridge helmet";
            HelmetRoman.Bid.userID_forSeller = 3333;
            HelmetRoman.Bid.userID_forLastBid = 2222;
            HelmetRoman.Bid.price = 1200;
            db.Add(HelmetRoman);

            ItemEntity HelmetViking = new ItemEntity();
            HelmetViking.Type = "Helmet";
            HelmetViking.Description.descriptionOfItem = "Viking helmet for protection of the head";
            HelmetViking.Description.imageOfItem = "empty";
            HelmetViking.Description.title = "Viking helmet";
            HelmetViking.Bid.userID_forSeller = 3333;
            HelmetViking.Bid.userID_forLastBid = 1111
            HelmetViking.Bid.price = 1000;
            db.Add(HelmetViking);

            ItemEntity HelmetKnight = new ItemEntity();
            HelmetKnight.Type = "Helmet";
            HelmetKnight.Description.descriptionOfItem = "Knight helmet that covers the whole face";
            HelmetKnight.Description.imageOfItem = "empty";
            HelmetKnight.Description.title = "Knight helmet";
            HelmetKnight.Bid.userID_forSeller = 3333;
            HelmetKnight.Bid.userID_forLastBid = 5555;
            HelmetKnight.Bid.price = 1300;
            db.Add(HelmetKnight);

            ItemEntity GlovesBrownLeather = new ItemEntity();
            GlovesBrownLeather.Type = "Gloves";
            GlovesBrownLeather.Description.descriptionOfItem = "Medieval gloves made of brown leather";
            GlovesBrownLeather.Description.imageOfItem = "empty";
            GlovesBrownLeather.Description.title = "Gloves - Brown leather";
            GlovesBrownLeather.Bid.userID_forSeller = 5555;
            GlovesBrownLeather.Bid.userID_forLastBid = 3333;
            GlovesBrownLeather.Bid.price = 300;
            db.Add(GlovesBrownLeather);

            ItemEntity GlovesBlackLeather = new ItemEntity();
            GlovesBlackLeather.Type = "Gloves";
            GlovesBlackLeather.Description.descriptionOfItem = "Medieval gloves made of black leather";
            GlovesBlackLeather.Description.imageOfItem = "empty";
            GlovesBlackLeather.Description.title = "Gloves - Black leather";
            GlovesBlackLeather.Bid.userID_forSeller = 5555;
            GlovesBlackLeather.Bid.userID_forLastBid = 3333;
            GlovesBlackLeather.Bid.price = 300;
            db.Add(GlovesBlackLeather);

            ItemEntity GlovesMetal = new ItemEntity();
            GlovesBlackLeather.Type = "Gloves";
            GlovesBlackLeather.Description.descriptionOfItem = "Medieval gloves made of metal";
            GlovesBlackLeather.Description.imageOfItem = "empty";
            GlovesBlackLeather.Description.title = "Gloves - Metal";
            GlovesBlackLeather.Bid.userID_forSeller = 5555;
            GlovesBlackLeather.Bid.userID_forLastBid = 1111;
            GlovesBlackLeather.Bid.price = 450;
            db.Add(GlovesBlackLeather);

            //Tilbehør - Ildkugler, Eliksirer, elverøre, 

            ItemEntity ElixirFlaskLarge = new ItemEntity();
            ElixirFlaskLarge.Type = "Accesories";
            ElixirFlaskLarge.Description.descriptionOfItem = "Large glass flask for elixirs";
            ElixirFlaskLarge.Description.imageOfItem = "empty";
            ElixirFlaskLarge.Description.title = "Large elixir flask";
            ElixirFlaskLarge.Bid.userID_forSeller = 2222;
            ElixirFlaskLarge.Bid.userID_forLastBid = 1111;
            ElixirFlaskLarge.Bid.price = 50;
            db.Add(ElixirFlaskLarge);

            ItemEntity ElixirFlaskSmall = new ItemEntity();
            ElixirFlaskSmall.Type = "Accesories";
            ElixirFlaskSmall.Description.descriptionOfItem = "Small glass flask for elixirs";
            ElixirFlaskSmall.Description.imageOfItem = "empty";
            ElixirFlaskSmall.Description.title = "Small elixir flask";
            ElixirFlaskSmall.Bid.userID_forSeller = 5555;
            ElixirFlaskSmall.Bid.userID_forLastBid = 1111;
            ElixirFlaskSmall.Bid.price = 25;
            db.Add(ElixirFlaskSmall);

            ItemEntity FlaskBag = new ItemEntity();
            ElixirFlaskSmall.Type = "Accesories";
            ElixirFlaskSmall.Description.descriptionOfItem = "Bag to hold you elixir flasks";
            ElixirFlaskSmall.Description.imageOfItem = "empty";
            ElixirFlaskSmall.Description.title = "Elixir flask bag";
            ElixirFlaskSmall.Bid.userID_forSeller = 4444;
            ElixirFlaskSmall.Bid.userID_forLastBid = 2222;
            ElixirFlaskSmall.Bid.price = 350;
            db.Add(ElixirFlaskSmall);


        }
    }
}
