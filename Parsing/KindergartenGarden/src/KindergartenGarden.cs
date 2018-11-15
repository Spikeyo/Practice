//*************************************************************
// Solution for the KindergartenGarden exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace KindergartenGardenProject
{
    public class KindergartenGarden
    {
        public ImmutableList<string> PotentialStudentNames { get; } = new List<string>
        {
            "Alice", "Bob", "Charlie", "David",
            "Eve", "Fred", "Ginny", "Harriet",
            "Ileana", "Joseph", "Kincaid", "Larry"
        }.ToImmutableList();
    
        public ImmutableDictionary<char, Plant> PlantsByChar { get; } = new Dictionary<char, Plant>
        {
            ['V'] = Plant.Violets,
            ['R'] = Plant.Radishes,
            ['C'] = Plant.Clover,
            ['G'] = Plant.Grass
        }.ToImmutableDictionary();

        public ImmutableDictionary<string, Plant[]> PlantsPerStudent { get; }

        public KindergartenGarden(string diagram)
        {
            if (diagram == null)
            {
                throw new ArgumentNullException(nameof(diagram), "diagram cannot be null");
            }
        
            PlantsPerStudent = ParseDiagram(diagram).ToImmutableDictionary();
        }

        public IEnumerable<Plant> GetPlantsOf(string student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "student cannot be null");
            }

            if (PlantsPerStudent.TryGetValue(student, out var plants))
            {
                return plants;
            }
        
            throw new ArgumentException(nameof(student), 
                $"student name ({student}) is invalid.");
        } 

        /// <summary>
        /// Converts the string diagram into a dictionary, where each key represents a student name and the associated value
        ///  represents an array of plants owned by the student.
        /// </summary>
        private Dictionary<string, Plant[]> ParseDiagram(string diagram)
        {
            var plantsPerStudent = new Dictionary<string, Plant[]>();
        
            var split = diagram.Split("\n");

            int numStudents = split[0].Length / 2;

            for (int i = 0; i < numStudents; i++)
            {
                plantsPerStudent[PotentialStudentNames[i]] = 
                (
                    from row in split
                    from plantIndex in Enumerable.Range(i * 2, 2)
                    select PlantsByChar[row[plantIndex]]
                ).ToArray();
            }

            return plantsPerStudent;
        }
    }
}