using System;
using UnityEngine;
using UnityEngine.Events;

namespace Utils.Bindings
{
    [Serializable]
    public abstract class ValueBindings<T> : UnityEvent<T>
    {
        [SerializeField]protected Animator animator;
        [SerializeField]protected String parameter;

        protected T value;
        public abstract T Value { get; set; }
    }
}