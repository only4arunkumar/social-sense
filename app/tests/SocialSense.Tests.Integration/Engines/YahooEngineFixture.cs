﻿namespace SocialSense.Tests.Integration.Engines
{
    using NUnit.Framework;

    using SharpTestsEx;

    using SocialSense.Engines;
    using SocialSense.Extensions;
    using SocialSense.Shared;

    [TestFixture, Category("Engines")]
    public class YahooEngineFixture
    {
        private Engine engine;

        [SetUp]
        public void SetUp()
        {
            this.engine = EngineFactory.Yahoo();
        }

        [TestCase("cultura")]
        [TestCase("yahoo")]
        public void Search_GetResultFromQuery(string term)
        {
            var results = this.engine.Search(new Query { Term = term, MaxResults = 10 });
            results.Count.Should().Be.GreaterThan(0);
        }

        [Test]
        public void Search_GetResultWithPeriod()
        {
            var results = this.engine.Search(new Query { Term = "cultura", Period = Period.Month, MaxResults = 10 });
            results.Count.Should().Be.GreaterThan(0);
        }

        [TestCase(Language.English)]
        public void Search_GetResultWithLanguage(Language language)
        {
            var results = this.engine.Search(new Query { Term = "cultura", Language = language, MaxResults = 10 });
            results.Count.Should().Be.GreaterThan(0);
        }

        [TestCase(Country.Brazil)]
        [TestCase(Country.Spain)]
        public void Search_GetResultWithCoutry(Country country)
        {
            var results = this.engine.Search(new Query { Term = "cultura", Country = country, MaxResults = 10 });
            results.Count.Should().Be.GreaterThan(0);
        }

        [Test]
        public void Search_NavigateInNextPage()
        {
            var results = this.engine.Search(new Query { Term = "cultura", MaxResults = 20 });
            results.Count.Should().Be.GreaterThanOrEqualTo(20);
        }
    }
}
