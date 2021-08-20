﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Description", "Gender", "Name", "Size", "Species" },
                values: new object[,]
                {
                    { 1, "4 months", "This is Ron! Ron and Dust #744354 are two adorable bunnies, looking for a special home to call their own! Ron #744352 and Dust #744354 are bonded which means they must be adopted together. Their combined adoption is only $35! Rabbits are intelligent and complex animals who do well in families with humans who understand that they are prey animals, and do not enjoy being picked up or held. The best way to bond with them is to spend time with them on the floor, and shower them with plenty of greens and Timothy hay! They are domestic rabbits and we recommend that adopters keep them both indoors. The nice thing about having indoor rabbits is that they can come out of their cage for bunny playtime, in a rabbit proof area of the home. It's during this supervised playtime that rabbits often exhibit some of their most fun and interesting behaviors! Ron and Dust #744354 will need a large enclosure - at least 5 ft. x 5 ft. with free roaming time (bigger is always better). Ron and Dust #744354 would love a family who will interact with them daily to keep them active and social! When rabbits get the space and enrichment they need, they often form deep bonds with their humans! Ask an Adoption Counselor to learn more!", "Male", "Ron", "Small", "Rabbit" },
                    { 2, "2 years", "This is Dust! Dust and Ron #744352 are two adorable bunnies, looking for a special home to call their own! Dust #744354 and Ron #744352 are bonded which means they must be adopted together. Their combined adoption is only $35! Rabbits are intelligent and complex animals who do well in families with humans who understand that they are prey animals, and do not enjoy being picked up or held. The best way to bond with them is to spend time with them on the floor, and shower them with plenty of greens and Timothy hay! They are domestic rabbits and we recommend that adopters keep them both indoors. The nice thing about having indoor rabbits is that they can come out of their cage for bunny playtime, in a rabbit proof area of the home. It's during this supervised playtime that rabbits often exhibit some of their most fun and interesting behaviors! Dust and Ron #744352 will need a large enclosure - at least 5 ft. x 5 ft. with free roaming time (bigger is always better). Dust and Ron #744352 would love a family who will interact with them daily to keep them active and social! When rabbits get the space and enrichment they need, they often form deep bonds with their humans! Ask an Adoption Counselor to learn more!", "Male", "Dust", "Small", "Rabbit" },
                    { 3, "2 years", "Meet Simba! Simba is a high energy cat that is also a little bit shy. In his previous home he lived with a young child and did not like them, so we suggest Simba not go home with young children. He also is not a fan of other cats, but he did live with some small dogs and got along well with them. Simba prefers to keep all four feet on the floor and does not enjoy being picked up or manhandled - but who can blame him. What Simba does love is to run around and play with his mice toys. He's also a fan of gentle head scratches, on his own terms. If you're looking for a playful guy with a mind of his own, Simba may be your man - come on in today to talk to an adoption counselor.", "Male", "Simba", "Medium", "Cat" },
                    { 4, "10 years", "This is Luci! Luci is a sweet old soul looking for a home where she can take long cat naps and spend time with her trusted humans. She has lived her whole life in one home, so this transition has been difficult for her. Luci will need patient adopters who can give her ample time to adjust. Once she is feeling comfortable, she enjoys gentle petting and taking naps on your lap! Luci would do best in a quiet home, without rambunctious children. She does have some age related medical concerns, such as dental disease, that her adopters will need to keep an eye on. Does this beautiful cat sound like the one for you? Ask an Adoption Counselor to learn more!", "Female", "Potato", "Medium", "Pig" },
                    { 5, "1 year", "Meet Cooper! Cooper is a Beagle mix so we strongly recommend doing your research before committing to an adoption. Beagle's are an extremely vocal breed, so please make sure that your environment is appropriate for all of that 'baying' and howling. Cooper is a sweet boy who lacks self-control and seeks instant gratification by demanding the things that he enjoys (attention, walks, treats, etc.). In Cooper's world, he has learned that behaviors like jumping and pulling get him what he desires. Cooper is eager to learn and will need a human that is patient and will teach him that calm behaviors are rewarded with his favorite things. Cooper has lots and lots of love to give but just doesn't know how to express it appropriately! Adequate exercise will be essential for giving Cooper an outlet for all of his teenage energy. How about a game of fetch, or frisbee? Another outlet will be training games, where Cooper can learn 'wait', 'leave it', or 'settle'. Learning calm behaviors will not only help Cooper live in your home peacefully, but will also make him less anxious and frustrated. Training is a bonding experience, and Cooper is sure to be a loyal companion. Due to Cooper's high energy and impulsive behavior, he would do best in an adult-only home. If you are enthusiastic about training and looking for your next loving companion, please make an appointment with our adoptions team today!", "Male", "Copper", "Large", "Dog" },
                    { 6, "6 months", "Meet Eva! She is a wonderful guinea pig looking for a home to call her own. Eva enjoys snacks, her comfy house, and play time with her favorite humans! Guinea pigs are incredibly social animals who need to be kept in pairs to thrive. Luckily Eva came in with her best bud Robin #750469! These two are required to go home together. Guinea pigs need a lot of ground space to run around and stay healthy. Two guinea pigs will need a minimum of 10 sq feet of space (more is better!) to call home. An easy and inexpensive way to give your pigs a DIY piggy palace is called a C&C fleece lined cage. Guinea pigs need lots of daily timothy hay to munch on, extra space to run around in, and toys to keep them active and enriched! Healthy greens and veggies are also an essential part of their diet, as well as a daily dose of vitamin C in the form of a supplement or a slice of orange! If you'd like to learn more, book an appointment today!", "Female", "Eva", "Small", "Guinea Pig" },
                    { 7, "1 years", "Hermione has been a bit shy while in SDHS care but is becoming more social as she gets comfortable. She's very food motivated and really loves her peanut butter and veggies!", "Female", "Hermione", "Large", "Pig" },
                    { 8, "5 years", "This is Tuktuk! Tuktuk came in with her best friend, Lucy #744931. They are bonded and they must go home together! Their combined adoption fee is $70! Lucy is an independent gal who likes to take life at her own pace. She only like to be pet on her own terms and prefers her alone time or spending time with Lucy. Both cats will need plenty of time to adjust to their new home and will need a family who can be patient with them. They have had some litterbox issues that are related to stress and they would do best in a quiet home without very much change. Just think of the special bond that you'll share when you help them come out of their shells! Ask an Adoption Counselor to learn more!", "Male", "Tuktuk", "Large", "Cat" },
                    { 9, "4 years", "This handsome shaggy boy is Balthazar! He was brought to us from another shelter, and we quickly saw he needed the support SDHS could provide at our Behavior Center. As he's gotten to know his regular caregivers, Balthazar has made progress with his shy/fearful behavior using positive reinforcement. We've paired treats and toys (some of his favorite things) with the scary parts of life - like new people, new places, and new things. He's started to open up, but Balthazar will need to find a compassionate home with adopters who are eager to help him continue growing. His next family should all be over 18, with no other animals. They should be experienced with very shy dogs, and have an understanding of husky quirks. Any neighbors should also be on board with Balthazar's 'talking' and vocalizing in many different situations. To best set him up for success, Balthazar will need a secure yard attached to a room where he can slowly acclimate at his own pace. We've fallen in love with Balthazar during his time with us, and we're committed to finding his perfect match. Can you help him become the Best Boy he was meant to be? Come see us today!", "Male", "Balthazar", "Large", "Dog" },
                    { 10, "3 years", "This is Loki! Loki is a particular kind of gal and change can make her uncomfortable. She can be very shy with new faces and places and it can take her months to adjust to anything new. Loki will need to go to a cat-savvy, adult-only home with a small family size. Ideally the home shouldn't have too many visitors or too much hustle and bustle. She cannot go to a home with dogs and she may do best as your only feline friend. Loki's new owners will need to keep her confined in one room, until she is feeling more comfortable. Once she adjusts, she's a mellow cat who enjoys lounging on her cat tree and hanging out near her trusted people. Before adopting Loki, the whole family will need to speak with one of our trainers, who will help set you up for success! Just think of the special bond that you will share, after you help her to come out of her shell! Ask an Adoption Counselor to learn more!", "Female", "Loki", "Medium", "Cat" },
                    { 11, "5 months", "This little Hammy dreams of having their own place where they have plenty of space to burrow, forage, and chew! Hamsters are solitary animals who need a LOT of daily enrichment to keep them from becoming bored. They need a large amount of room with plenty of bedding to dig intricate tunnels where they can do secret hamster things away from prying eyes. Although hamsters are very small, they need plenty of space to run, forage for food, and most importantly burrow! The bare minimum amount of space for a hamster this size is 600 sq inches of ground space. An easy and affordable way to give your hammy the space they needs is to make a 'Hamster Bin Cage' (google it!). Hamsters haven't been domesticated for long so they aren't always easy to tame. Hamsters are a good fit for older children or adults who aren't looking for a pet to cuddle with. The best way to interact with your hamster is to use a hamster playpen! You can sit inside and let them climb all over you while they explore paper towel tunnels! This sweetie has done well with handling in their pervious home. They would love to find a human who will spend time slowly building a bond of trust and love with them! So, if Remi is the hamster for you, come visit us at the San Diego location and talk to an Adoption Counselor some more about her!", "Female", "Remi", "Tiny", "Hamster" },
                    { 12, "5 months", "Mojo is a super sweet hamster who would love to find a family to call home. Hamsters are burrowers! They would love to have a large habitat with deep layers of bedding that they can burrow into! In the wild hamsters dig burrows up to three feet deep! Mojo dreams of having a space large enough to have a separate burrow for all of their favorite activities (sleeping, eating, and pooping)! They may be small, but Mojo has a lot of energy! They will thrive in a home where they has various outlets for their energy. It's important to them that they have plenty of space in their habitat to run around, as well as a large wheel to run on, and plenty of safe playtime outside of their habitat with their human. A great way to give your hammy a spacious, but inexpensive habitat is to build a DIY hamster bin cage (google it!). Mojo is an intelligent creature who likes to keep their mind sharp. They would love a human who can make them plenty of toys, and daily enrichment to keep them entertained! If you'd love to give Mojo the hammy home of their dreams then come on down to the San Diego campus to adopt him!", "Male", "Mojo-Jojo", "Tiny", "Hamster" },
                    { 13, "7 years", "This is Skylar! Skylar might be a big puppy, but she kind of thinks she's a cat. Although she is friendly, affectionate, and confident, Skylar likes to make friends and build trust on her own terms. She can be sensitive to handling and doesn't like being picked up or restrained. Our behavior and training team is able to discuss Skylar's behavior and continued management before going home. You'd also have the opportunity to meet her with one of her trainers to ensure the adoption is the right fit. She has previously cohabitated with other cats, and has good social skills with the other dogs she's met. Skylar can get excited and jumpy, so because of this she will need an adult only home. Her favorite things include long walks with her favorite people, cucumbers, carrots, and chew toys! Ready to bring her home? Come visit us at the San Diego Campus to speak with a counselor today!", "Male", "Skylar", "Large", "Dog" },
                    { 14, "9 months", "This is Desmond! Desmond is looking for a human who will spend plenty of time with him everyday. Desmond is a social rattie who enjoys getting head pets from his humans. He isn't used to being held yet, but with a gentle and patient human, we think he will let his guard down quickly. Rats generally do better in groups, but Desmond was separated from his brothers due to fighting and may be fine living on his own. Rats need need at least two square feet of cage space (per rat). In addition to a spacious home base, this guy will need plenty of soft fleece hammocks, toys, activities, and daily time to explore outside of his cage to keep him busy, especially if he lives alone! We recommend doing lots of research on rat parenthood before bringing him home. Ask an Adoption Counselor to learn more!", "Male", "Desmond", "Tiny", "Rat" },
                    { 15, "9 months", "This is Tootles! Are you looking for a hamster that loves to be held and cuddled? Then Tootles is NOT the hamster for you! Tootles has not been socialized and will need a lot of work, time, treats, and patience in order to not scream at everything she hates. Tootles is a busy little girl who dreams of having her own place where she has plenty of space to burrow, forage, and chew! Hamsters need a LOT of daily enrichment to keep themselves from becoming bored. Tootles needs a large amount of room with plenty of bedding to dig intricate tunnels where she can do secret hamster things away from prying eyes. Tootles would love to find a human who will spend time slowly building a bond of trust and love with her! In addition, Tootles teeth have grown at an odd angle. This may correct itself in time with a correct diet, but Tootles should be taken to a veterinarian to ensure she is healthy and her teeth are on the right path (the straight and narrow, as it were). Ask an Adoption Counselor to learn more about her today so that you can start engineering some cardboard creations together!", "Male", "Tootles", "Tiny", "Hamster" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
