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


            //Skjold


            //Rustning/udklædning


            //Tilbehør - Ildkugler, Eliksirer, elverøre, 
    }
}
