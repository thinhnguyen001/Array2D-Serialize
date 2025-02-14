using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public enum EnumTest
    {
        Value1,
        Value2,
        Value3,
    }

    public Array2DSerialize<float> array2DFloat;
    public Array2DSerialize<bool> array2DBool;
    public Array2DSerialize<string> array2DString;
    public Array2DSerialize<EnumTest> array2DEnum;
    public Array2DSerialize<GameObject> array2DObject;
}
