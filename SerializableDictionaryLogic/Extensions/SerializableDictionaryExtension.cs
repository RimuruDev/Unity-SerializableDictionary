// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using System.Collections.Generic;
using System.Linq;
using Internal.Codebase.Runtime.SerializableDictionaryLogic.Base;
using UnityEngine;

namespace Internal.Codebase.Runtime.SerializableDictionaryLogic.Extensions
{
    public static class SerializableDictionaryExtension
    {
        public static Dictionary<string, GameObject> ToDictionary(this SerializableDictionary serializableDictionary)
        {
            var newD = new Dictionary<string, GameObject>();

            serializableDictionary.Dictionary.Where(element => element != null).ToList().ForEach(element =>
            {
                newD.Add(element.key, element.value);
            });

            return newD;
        }
    }
}