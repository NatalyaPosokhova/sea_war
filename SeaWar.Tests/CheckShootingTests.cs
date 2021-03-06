﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;

namespace SeaWar.Tests
{
    class CheckShootingTests
    {

        [Test]
        public void SuccessShipHitTest()
        {
            Ship ship = new Ship(new Point { x = 4, y = 4 }, 1, ShipDirection.Vertical);
            Assert.IsTrue(ship.CheckShooting(new Point { x = 4, y = 4 }));
            Assert.That(ship.State == ShipState.Died);
        }

        [Test]
        public void CheckThatShipInjuredTest()
        {
            Ship ship = new Ship(new Point { x = 4, y = 4 }, 2, ShipDirection.Horizontal);
            ship.CheckShooting(new Point { x = 5, y = 4 });
            Assert.That(ship.State == ShipState.Injured);
        }

        [Test]
        public void MissedShootTest()
        {
            Ship ship = new Ship(new Point { x = 8, y = 8 }, 2, ShipDirection.Vertical);
            Assert.IsFalse(ship.CheckShooting(new Point { x = 6, y = 6 }));
        }
    }
}
