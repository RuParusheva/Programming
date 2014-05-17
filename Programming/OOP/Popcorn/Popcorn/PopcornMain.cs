/*Tasks 01-13:
01. The Popcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls to the game. 
You can ONLY edit the PopcornMain.cs file.
02. The Engine class has a hardcoded sleep time (search for "System.Threading.Sleep(500)".
Make the sleep time a field in the Engine and implement a constructor, which takes it as an additional parameter.
03. Search for a "TODO" in the Engine class, regarding the AddRacket method. Solve the problem mentioned there. 
There should always be only one Racket. Note: comment in TODO not completely correct
04. Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
05. Implement a TrailObject class. It should inherit the GameObject class and should have a constructor 
which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns. 
You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the engine through 
the PopcornMain.cs file.
06. Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. 
Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way as the normal ball. 
You must NOT edit any existing .cs file.
07. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
08. Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks 
and will destroy any other block it passes through. The UnpassableBlock should be indestructible. 
Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.
09. Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in PopcornMain.cs file
10. Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. 
You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?
11. Implement a Gift class. It should be a moving object, which always falls down. 
The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket. 
You must NOT edit any existing .cs file. 
12. Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed. 
You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through 
the AcademyPopcornMain.cs file.
13. Implement a shoot ability for the player racket. The ability should only be activated when a Gift object 
falls on the racket. The shot objects should be a new class (e.g. Bullet) and should destroy normal Block objects 
(and be destroyed on collision with any block). Use the engine and ShootPlayerRacket method you implemented in task 4, 
but don't add items in any of the engine lists through the ShootPlayerRacket method. Also don't edit the Racket.cs file. 
Hint: you should have a ShootingRacket class and override its ProduceObjects method.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Popcorn
{
    class PopcornMain
    {
        private const int WorldRows = 23;
        private const int WorldCols = 40;
        private const int RacketLength = 6;

        private static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //Normal blocks
            for (int i = startCol - 1; i < WorldCols - 1; i++)
            {
                Block firstBlock = new Block(new MatrixCoords(startRow, i));
                Block secondBlock = new Block(new MatrixCoords(startRow - 1, i));
                Block thirdBlock = new Block(new MatrixCoords(startRow - 2, i));
                engine.AddObject(firstBlock);
                engine.AddObject(secondBlock);
                engine.AddObject(thirdBlock);
            }

            //Task 01. Indestructible ceiling and walls
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock borderBlockLeft = new IndestructibleBlock(new MatrixCoords(i, 0));
                IndestructibleBlock borderBlockRight = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(borderBlockLeft);
                engine.AddObject(borderBlockRight);
            }

            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock borderCeiling = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(borderCeiling);
            }

            //Tasks 08-09. Test Impassable Block line and Unstoppable Ball
            //for (int i = startCol - 1; i < WorldCols - 1; i++)
            //{
            //    ImpassableBlock impassableBlock = new ImpassableBlock(new MatrixCoords(startRow + 5, i));
            //    engine.AddObject(impassableBlock);
            //}
            ////Making borders also impassable for testing purposes
            //for (int i = WorldRows/2 - 3 ; i < WorldRows; i++)
            //{
            //    ImpassableBlock impassableLeftBorder = new ImpassableBlock(new MatrixCoords(i, 0));
            //    ImpassableBlock impassableRightBorder = new ImpassableBlock(new MatrixCoords(i, WorldCols - 1));
            //    engine.AddObject(impassableLeftBorder);
            //    engine.AddObject(impassableRightBorder);
            //}

            //UnstoppableBall unstoppable = new UnstoppableBall(new MatrixCoords(WorldRows/2, 2), new MatrixCoords(-1, 2));
            //engine.AddObject(unstoppable);

            //Task 10. Explosive block implementation test
            for (int i = startCol - 1; i < WorldCols - 1; i++)
            {
                ExplodingBlock xBlock = new ExplodingBlock((new MatrixCoords(startRow + 1, i)));
                engine.AddObject(xBlock);
            }

            //Task 11. Gift Class test implementation
            //Gift gift = new Gift(new MatrixCoords(WorldRows/2 - 5, WorldCols/2 - 5));
            //engine.AddObject(gift);

            //Task 12. Test GiftBlock implementation
            //for (int i = startCol - 1; i < WorldCols - 1; i++)
            //{
            //    GiftBlock giftBlock = new GiftBlock((new MatrixCoords(startRow + 2, i)));
            //    engine.AddObject(giftBlock);
            //}

            //Tasks 06-07. MeteoriteBall
            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 1), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

            //Test Task 05. TrailObject
            //TrailObject trailObject = new TrailObject(new MatrixCoords(WorldRows /2 - 1, 1), 3);
            //engine.AddObject(trailObject);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            //Test Task 03. Single racket test:
            //Racket newRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
            //engine.AddObject(newRacket);


        }

        private static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            //Task 02. Add Sleep time to Engine constructor
            Engine gameEngine = new Engine(renderer, keyboard, 150);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}


