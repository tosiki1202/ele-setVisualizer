using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
[CustomEditor(typeof(PAData))]
#endif

public class GustData : PAData
{  
    void start()
    {
        FRAME = 54;
        FIRE = 330;
    }
}
