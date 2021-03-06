using System;
using Core.src.Infrastructure;
using UnityEngine;

namespace Core.src.Commands
{
    public class UnloadUnusedResourcesCommand : ICommand
    {
        public void Execute()
        {
            Resources.UnloadUnusedAssets();
            OnSuccess?.Invoke();
        }

        public void Undo()
        {
        }

        public bool IsAvailable()
        {
            return true;
        }

        public string Description { get; set; }
        public int Priority { get; } = 10000;
        public Action OnSuccess { get; set; }
        public Action<float> OnProgressChanged { get; set; }
        public Action<Exception> OnFail { get; set; }
    }
}