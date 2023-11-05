using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.Selection;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using BlackjackStrategy.Methods.Commands;

namespace BlackjackStrategy.GeneticAlgorythm
{
    public class GeneticAlgorythm : IGeneticAlgorythm
    {
        public ISpecimenModel FinalSpecimen { get; private set; }
        public int Generations { get; private set; }
        public int Iterations { get; private set; }
        public int PopulationSize { get; private set; }
        public List<ISpecimenModel> CurrentPopulation { get; set; }
        public ISpecimenModel EliteSpecimen { get; set; }
        public List<ISpecimenModel> Parents { get; set; }      
        public List<int> MutationFactor { get; set; }      
        

        ////////////////////////////////////////////////////
        public void WriteScoresToFile() 
        {
            List<double> scores = CurrentPopulation.Select(x=>x.Score).OrderByDescending(x=>x).ToList();

            IWriteScoresToFile _scoresToFile = Factory.CreateWriteScoresToFileMethod();
            _scoresToFile.WriteScoresToFile(scores.First(),scores.Last(),scores.Sum()/scores.Count);

        }

        /// //////////////////////////////////////////////////
        public GeneticAlgorythm()
        {
            Generations = 10;
            Iterations = 100;
            PopulationSize = 200;
            CurrentPopulation = new List<ISpecimenModel>();
            EliteSpecimen = Factory.CreateSpecimenModelInstance(new List<int>() {1});
            MutationFactor = new() {   
                0, 0, 0, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            };
        }

        public void CreatePopulation()
        {
            ICreatePopulation _createPopulation = Factory.CreatePopulationMethod();

            _createPopulation.InitialUnit = 1;
            _createPopulation.SystemLength = 5;
            _createPopulation.MaxUnit = 6;
            _createPopulation.MinUnit = 1;
            CurrentPopulation.Clear();
            List<List<int>> generatedLists = new List<List<int>>();

            generatedLists = _createPopulation.CollectBettingSystems(PopulationSize);
            foreach (List<int> bettingSystem in generatedLists)
            {
                CurrentPopulation.Add(Factory.CreateSpecimenModelInstance(bettingSystem));
            }
            //CurrentPopulation.Add(Factory.CreateSpecimenModelInstance(new() { 2,1,3,1,5,1,7}));
        }
        public void ChooseEliteSpecimen()
        {
            CurrentPopulation = CurrentPopulation.OrderByDescending(x => x.Score).ToList();
            EliteSpecimen = CurrentPopulation.First();
            CurrentPopulation.RemoveAt(0);
        }
        public void NormalizeScore()
        {   
            INormalize _normalize = Factory.CreateNormalizeMethod();
            _normalize.Normalize(CurrentPopulation); 
        }        
        public void Selection() 
        {
            ISelection _selection = Factory.CreateSelectionMethod();
            Parents = _selection.ParentSelection(CurrentPopulation);
            Parents.Add(EliteSpecimen);
        }
        public void MakeChildren(int generationNumber) 
        {
            IMakeChildren _childrenGenerator = Factory.CreateMakeChildrenMethod();
            CurrentPopulation = _childrenGenerator.MakeChildren(Parents,MutationFactor,PopulationSize,generationNumber);
            CurrentPopulation.Add(EliteSpecimen);
        }
        public void AlgorythmSummary() 
        {
            Console.WriteLine("Best specimen:");
            foreach(var unit in EliteSpecimen.BettingSystem)
            {
                Console.Write($"{unit}/");
            }
            Console.WriteLine();
            Console.WriteLine($"Score: {EliteSpecimen.Score}");
        }
    }
}
