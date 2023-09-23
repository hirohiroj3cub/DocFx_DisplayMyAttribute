using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class MyCustomAttribute : Attribute
    {

    }

    [Serializable]
    public class MyClass
    {
        [SerializeField, Range(0, 100), MyCustom]
        public int intField;
    }

}