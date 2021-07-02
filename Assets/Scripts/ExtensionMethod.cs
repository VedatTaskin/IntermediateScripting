using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// extension methods are static

public static class ExtensionMethod 
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }

}
