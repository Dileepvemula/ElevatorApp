using NUnit.Framework;
using System;
using System.IO;

namespace ElevatorApp.Tests
{
    [TestFixture]
    public class ElevatorTests
    {
        private Elevator _elevator;

        [SetUp]
        public void Setup()
        {
            _elevator = new Elevator(10); // Assuming 10 floors in the building
        }

        [Test]
        public void IsMoving_InitiallyNotMoving_ReturnsFalse()
        {
            Assert.That(_elevator.IsMoving(), Is.False);
        }

        [Test]
        public void StartAtGround_ElevatorStartsAtGround_CurrentFloorIsZero()
        {
            _elevator.StartAtGround();
            Assert.That(_elevator.GetCurrentFloor(), Is.EqualTo(0));
        }

        [Test]
        public void ProcessNextRequest_NoRequests_ElevatorNotMoving()
        {
            _elevator.ProcessNextRequest();
            Assert.That(_elevator.IsMoving(), Is.False);
        }
        //
        // // Add more Elevator class test cases as described earlier
        //
        // // Main program test cases
        // [Test]
        // public void Main_UserInputTotalFloors_ValidInput_ElevatorInitialized()
        // {
        //     string input = "10"; // Assuming user enters "10" for total floors
        //     using (StringReader sr = new StringReader(input))
        //     {
        //         Console.SetIn(sr);
        //         using (StringWriter sw = new StringWriter())
        //         {
        //             Console.SetOut(sw);
        //             Program.Main(new string[] { });
        //             string expectedOutput = "Enter the total number of floors of the building:";
        //             Assert.That(sw.ToString(), Does.Contain(expectedOutput));
        //         }
        //     }
        // }
    }
}
