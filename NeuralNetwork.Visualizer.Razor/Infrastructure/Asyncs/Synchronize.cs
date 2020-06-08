﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeuralNetwork.Visualizer.Razor.Infrastructure.Asyncs
{
   internal class Synchronize : ISynchronize
   {
      public async Task ForEachhAsync<T>(IEnumerable<T> objects, Func<T, Task> action)
      {
         Task task = Task.CompletedTask;

         foreach (var obj in objects)
         {
            await task.ContinueWith((t) => task = action.Invoke(obj)).ConfigureAwait(false);
         }
      }
   }
}