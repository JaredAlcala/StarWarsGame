using StarWarsGameLibrary;
using System.Reflection;

namespace TestStarWarsGame
{
    public class GameTests
    {
        [Fact]
        public void TestLukeSkywalkerBlock()
        {
            //Arrange
            LukeSkywalker ls = new LukeSkywalker(name: "Luke Skywalker", hitChance: 50, block: 20, maxLife: 25, maxDamage: 8, minDamage: 2, description: "Wanted by The Glactic Empire for destruction of the Death Star and for being a self-proclaimed Jedi Knight.", new Random().Next(2) == 1);
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 25;
            actualBlock = ls.CalcBlock();

            //Assert
            Assert.True(expectedBlock <= 38 && expectedBlock >= 25 && actualBlock <= 38 && actualBlock >= 25);



        }

        [Fact]
        public void TestChewieHit()
        {
            Chewbacca cb = new Chewbacca(name: "Chewbacca", hitChance: 70, block: 8, maxLife: 30, maxDamage: 8, minDamage: 1, description: "Wanted by Jaba the Hutt and The Galactic Empire.", new Random().Next(2) == 1);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 30;
            actualHit = cb.CalcBlock();

            //Assert
            Assert.Equal(expectedHit, actualHit);

        }

        [Fact]
        public void TestHanSoloDamage()
        {
            HanSolo hs = new HanSolo(name: "Han Solo", hitChance: 50, block: 10, maxLife: 25, maxDamage: 4, minDamage: 1, description: "Wanted by Jabba the Hutt and The Galactic Empire, price is around 200,000 credits...", new Random().Next(2) == 1);
            int expectedDamage = 0;
            int actualDamage = 0;
            //Act
            expectedDamage = 3;
            actualDamage = hs.CalcDamage();

            //Assert
            Assert.True(expectedDamage <= 4 && expectedDamage >= 1 && actualDamage <= 4 && actualDamage >= 1);

        }

        [Fact]
        public void TestMythrolBlock()
        {
            TheMythrol my = new TheMythrol(name: "The Mythrol", hitChance: 20, block: 5, maxLife: 10, maxDamage: 10, minDamage: 1, description: "This Male Myhtrol stole credits from one of the Bounty Hunter Guild Leaders, Greef Karga. You can bring him in warm or you can bring him in cold.", 5, 10);
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 10;
            actualBlock = my.CalcBlock();

            //Assert
            Assert.True(expectedBlock <= 20 && expectedBlock >= 5 && actualBlock <= 20 && actualBlock >= 5);
        }

        [Fact]
        public void TestHitLeia()
        {
            LeiaOrgana lo = new (name: "Leia Organa", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15, minDamage: 1, description: "Wanted by The Galactic Empire for helping and leading the Rebel Alliance for a price of 10,000,000 credits.", new Random().Next(2) == 1);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 20;
            actualHit = lo.CalcBlock();

            //Assert
            Assert.True(expectedHit <= 45 && expectedHit >=20 && actualHit <= 45 && actualHit >=20);
        }
    }
}
