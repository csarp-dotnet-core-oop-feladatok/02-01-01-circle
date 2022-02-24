using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using CircleProject;
using CircleProject.Models;

namespace CircleProject.Tests
{
    [TestClass()]
    public class TestsSetter
    {
        [TestMethod()]
        public void TestCircle()
        {
            Circle c1 = new Circle(4.25);          
            double expectedRadius = 4.25;
            double actualRadius = c1.Radius;
            Assert.AreEqual(expectedRadius, actualRadius, "A Circle konstruktora nem jól határozza meg a sugarat!");
                        
            c1.Radius = 5.25;
            expectedRadius = 5.25;
            actualRadius = c1.Radius;
            Assert.AreEqual(expectedRadius, actualRadius, 0.01,"A Circle Radius tulajdonság set vagy get metódusa nem megfelelően működik!");

            double expectedDistrict = 32.9867;
            double actualDistrict = c1.Perimeter;
            Assert.AreEqual(expectedDistrict, actualDistrict, 0.01, "A Circle District tulajdonság get metódusa nem megfelelően működik!");

            double expectedArea = 86.5901;
            double actualArea = c1.Area;
            Assert.AreEqual(expectedArea, actualArea,0.01, "A Circle Area tulajdonság get metódusa nem megfelelően működik!");

            string toString = c1.ToString();
            string radius = c1.Radius.ToString();
            string roundedPrerimeter= Math.Round(c1.Perimeter, 2).ToString() ;
            string roundedArea = Math.Round(c1.Area, 2).ToString();

            bool haveRadius = toString.Contains(radius);
            bool haveParimeter = toString.Contains(roundedPrerimeter);
            bool haveArea = toString.Contains(roundedArea);

            Assert.IsTrue(haveRadius, "A ToString metódus nem jeleníti meg a sugarat!");
            Assert.IsTrue(haveParimeter, "A ToString metódus nem jeleníti meg a kerületet két tizedes jegy pontossággal!");
            Assert.IsTrue(haveArea, "A ToString metódus nem jeleníti meg a területet két tizedes jegy pontosságal.");
        }
    }
}
