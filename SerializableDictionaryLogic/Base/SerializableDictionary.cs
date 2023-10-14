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

using System;
using UnityEngine;
using System.Collections.Generic;

namespace Internal.Codebase.Runtime.SerializableDictionaryLogic.Base
{
    [Serializable]
    public sealed class SerializableDictionary
    {
        [field: SerializeField] public List<SerializableDictionaryElement> Dictionary { get; private set; }
    }
}