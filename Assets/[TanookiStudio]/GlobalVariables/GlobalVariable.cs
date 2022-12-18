using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TanookiStudio
{
    public abstract class GlobalVariable<T> : ScriptableObject
    {
        [SerializeField] private T value;
        [SerializeField] private UnityEvent onValueUpdate;

        public T GetValue()
        {
            return this.value;
        }
        public void SetValue(T value)
        {
            this.value = value;
            onValueUpdate?.Invoke();
        }
    }
}