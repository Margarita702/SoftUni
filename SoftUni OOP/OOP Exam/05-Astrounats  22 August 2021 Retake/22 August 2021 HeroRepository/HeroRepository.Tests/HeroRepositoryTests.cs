using System;
using NUnit.Framework;
[TestFixture]
public class HeroRepositoryTests
{

    [Test]
    public void ThrowExceptionIfHeroIsNullWhenCreatingAHroRep()
    {
        HeroRepository heroResp = new HeroRepository();
        Hero hero = null;
        Assert.Throws<ArgumentNullException>(() =>
        { heroResp.Create(hero); });
    }
    [Test]
    public void CreateMethodShouldThrowExceptionWhenAlreadyExist()
    {
        //When there is already present like this

        Assert.Throws<InvalidOperationException>(() =>
        {
            HeroRepository heroResp = new HeroRepository();

            var hero = new Hero("Misho", 25);
            heroResp.Create(hero);
            heroResp.Create(hero);

        });
    }

    [Test]
    public void CreateMethodShouldWork()
    {
        HeroRepository heroResp = new HeroRepository();

        var hero = new Hero("Misho", 25);


        var result = heroResp.Create(hero);

        Assert.AreEqual("Successfully added hero Misho with level 25", result);

    }
    [Test]
    public void ThrowArgumentExceptionIfNullOrWhiteSpace()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            HeroRepository heroResp = new HeroRepository();

            var hero = new Hero(null, 25);
            heroResp.Remove(null);

        });

    }

    [Test]
    public void RemoveShouldReturnFalseIfPresentNotInBag()
    {
        HeroRepository heroResp = new HeroRepository();

        var hero1 = new Hero("Misho", 25);
        bool result = heroResp.Remove("Misho");

        Assert.AreEqual(false, result);
    }

    [Test]
    public void RemoveShouldReturnTrueIfPresentInBag()
    {
        HeroRepository heroResp = new HeroRepository();

        var hero1 = new Hero("Misho", 25);
        heroResp.Create(hero1);

        bool result = heroResp.Remove("Misho");

        Assert.AreEqual(true, result);
    }

    [Test]
    public void GetHerotWithHighestLevel()
    {
        HeroRepository heroResp = new HeroRepository();

        var hero1 = new Hero("Misho", 25);
        var hero2 = new Hero("Pesho", 37);
        var hero3 = new Hero("Gosho", 77);

        heroResp.Create(hero1);
        heroResp.Create(hero2);
        heroResp.Create(hero3);


        Hero heroWithHighestLev = heroResp.GetHeroWithHighestLevel();

        Assert.AreEqual(hero3, heroWithHighestLev);

    }
    [Test]
    public void GetHeroByGivenName()
    {
        HeroRepository heroResp = new HeroRepository();

        var hero1 = new Hero("Misho", 25);
        var hero2 = new Hero("Pesho", 37);
        var hero3 = new Hero("Gosho", 77);

        heroResp.Create(hero1);
        heroResp.Create(hero2);
        heroResp.Create(hero3);


        Hero heroWithHighestLev = heroResp.GetHero("Pesho");


        Assert.AreEqual(hero2, heroWithHighestLev);

    }


}