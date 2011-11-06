﻿using NUnit.Framework;

namespace ClassLibraryWithTests
{
    public class SpiderManTests
    {
        [Test]
        public void SpiderMan_should_know_his_own_catch_phrase()
        {
            var spidey = new SpiderMan();

            var thePhrase = spidey.SayCatchPhrase();

            Assert.That(thePhrase, Is.EqualTo("It's your Friendly Neighborhood Spider-Man!"));
        }
    }
}
