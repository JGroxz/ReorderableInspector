using System.Collections;
using System.Collections.Generic;
using Malimbe.PropertySerializationAttribute;
using UnityEngine;

public class ReorderableListMalimbeSerializedTest : MonoBehaviour
{
    [Serialized]
    public List<bool> malimbeList { get; set; } = new List<bool>() {false, false, true};
}
