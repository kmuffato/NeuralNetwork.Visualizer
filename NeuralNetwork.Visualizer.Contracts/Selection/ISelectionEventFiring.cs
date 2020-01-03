﻿using NeuralNetwork.Visualizer.Contracts.Drawing.Core.Primitives;
using System.Threading.Tasks;

namespace NeuralNetwork.Visualizer.Contracts.Selection
{
   public interface ISelectionEventFiring
   {
      Task FireSelectionEvent(Position position, SelectionEvent selectionEvent);
   }
}