﻿using System.Threading.Tasks;

namespace NeuralNetwork.Visualizer.Razor.Infrastructure.Scripts
{
   internal interface IScriptFileRegistrarInclusion
   {
      IScriptRegistrar Include(string fileName);
   }
}