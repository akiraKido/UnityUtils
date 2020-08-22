using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtils
{
    public interface IInitializable<in T>
    {
        void Initialize(T value);
    }

    public static class InitializableExtensions
    {
        public static TInstance Instantiate<TInstance, TValue>(this TInstance initializable, TValue value)
            where TInstance : MonoBehaviour, IInitializable<TValue>
        {
            var obj = Object.Instantiate(initializable);
            obj.Initialize(value);
            return obj;
        }
    }
}