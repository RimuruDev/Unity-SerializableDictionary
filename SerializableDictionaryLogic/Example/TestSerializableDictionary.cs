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
using System.Collections.Generic;
using Internal.Codebase.Runtime.SerializableDictionaryLogic.Base;
using Internal.Codebase.Runtime.SerializableDictionaryLogic.Extensions;

namespace Internal.Codebase.Runtime.SerializableDictionaryLogic.Example
{
    [DisallowMultipleComponent]
    public sealed class TestSerializableDictionary : MonoBehaviour
    {
        [SerializeField] private SerializableDictionary inventoryItems;
        private Dictionary<string, GameObject> nonSerializableDictionary;

        private void Start()
        {
            nonSerializableDictionary = inventoryItems.ToDictionary();

            foreach (var keyValuePair in nonSerializableDictionary)
                Debug.Log($"Key: {keyValuePair.Key} || Value: {keyValuePair.Value}");
        }
    }
}