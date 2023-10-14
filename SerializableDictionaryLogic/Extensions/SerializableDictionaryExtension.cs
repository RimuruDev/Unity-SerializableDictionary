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

using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using Internal.Codebase.Runtime.SerializableDictionaryLogic.Base;

namespace Internal.Codebase.Runtime.SerializableDictionaryLogic.Extensions
{
    public static class SerializableDictionaryExtension
    {
        public static Dictionary<string, GameObject> ToDictionary(this SerializableDictionary serializableDictionary)
        {
            var newDictionary = new Dictionary<string, GameObject>();

            serializableDictionary.Dictionary.Where(element => element != null).ToList().ForEach(element =>
            {
                newDictionary.Add(element.key, element.value);
            });

            return newDictionary;
        }
    }
}
