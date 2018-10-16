using System;
using Xunit;
using Lab05_OOPPrinciples.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestCat()
        {
            Cat cat = new Cat();
            Assert.Equal("Cats bite!", cat.Bites());
            Assert.Equal("Cats meow to cry.", cat.Cry());
        }

        [Fact]
        public void TestJaguar()
        {
            Jaguar jaguar = new Jaguar();
            Assert.Equal("Jaguars bite!", jaguar.Bites());
            Assert.Equal("Jaguars roar to cry.", jaguar.Cry());
        }

        [Fact]
        public void TestKrill()
        {
            Krill krill = new Krill();
            Assert.Equal("I am food for whales!", krill.BeEaten());

        }

        [Fact]
        public void TestLangostino()
        {
            Langostino langostino = new Langostino();
            Assert.Equal(10, langostino.Legs);
            Assert.Equal(2, langostino.Antennae);
        }

        [Fact]
        public void TestParrot()
        {
            Parrot parrot = new Parrot();
            Assert.Equal("I live in the Amazon!", parrot.TropicalHabitat);
            Assert.True(parrot.ColorfulPlumage);
        }

        [Fact]
        public void TestToucan()
        {
            Toucan toucan = new Toucan();
            Assert.Equal("I don't live in the Amazon!", toucan.TropicalHabitat);
            Assert.False(toucan.ColorfulPlumage);
        }
    }
}
