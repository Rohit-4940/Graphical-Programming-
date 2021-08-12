using Component1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isShape_equalCircle()
        {
            var shapeFactorydef = new ShapeFactoryDef();
            bool result = shapeFactorydef.isCircle("circle");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void isShape_equalRectangle()
        {
            var shapeFactorydef = new ShapeFactoryDef();
            bool result = shapeFactorydef.isRectangle("rectangle");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void isShape_equalTringle()
        {
            var shapeFactorydef = new ShapeFactoryDef();
            bool result = shapeFactorydef.isTringle("tringle");
            Assert.AreEqual(true, result);
        }
    }
}
