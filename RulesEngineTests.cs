﻿using NUnit.Framework;

namespace CorrespondenceCoderetreat
{
    [TestFixture]
    public class RulesEngineTests
    {
        const int MaxNeighbors = 8;
        const int MinNeighbors = 0;

        readonly RulesEngine rulesEngine;

        public RulesEngineTests()
        {
            rulesEngine = new RulesEngine();
        }

        [Test]
        public void LivingCellWithThreeNeighborsShouldSurvive()
        {
            Assert.IsTrue(rulesEngine.WillSurvive(3));
        }

        [Test]
        public void LivingCellWithLessThanTwoNeighborsShouldDie()
        {
            Assert.IsFalse(rulesEngine.WillSurvive(1));
            Assert.IsFalse(rulesEngine.WillSurvive(MinNeighbors));
        }

        [Test]
        public void LivingCellWithMoreThanThreeNeighborsShouldDie()
        {
            Assert.IsFalse(rulesEngine.WillSurvive(4));
            Assert.IsFalse(rulesEngine.WillSurvive(MaxNeighbors));
        }

        [Test]
        public void OnEmptySpaceWithThreeNeighborsShouldBornNewCell()
        {
            Assert.IsTrue(rulesEngine.WillBorn(3));
        }
    }
}