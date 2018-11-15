//*************************************************************
// Solution for the Robot exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Collections.Generic;

namespace RobotNameProject
{
    public class Robot
    {
        private const int NumUppercaseLetters = 2;
        private const int NumIntegers = 3;

        private static readonly List<string> AllNames = new List<string>();
        private static readonly Random Random = new Random();

        public string Name { get; private set; }

        public Robot()
        {
            GenerateRandomUniqueName();
        }

        public void Reset()
        {
            GenerateRandomUniqueName();
        }

        private void GenerateRandomUniqueName()
        {   
            while (AllNames.Contains(Name))
            {
                GenerateRandomName();
            }
        
            AllNames.Add(Name);
        }

        private void GenerateRandomName()
        {
            Name = "";

            for (int i = 0; i < NumUppercaseLetters; i++)
            {
                Name += (char)Random.Next(65, 91);
            }

            for (int i = 0; i < NumIntegers; i++)
            {
                Name += Random.Next(0, 10).ToString();
            }
        }
    }
}