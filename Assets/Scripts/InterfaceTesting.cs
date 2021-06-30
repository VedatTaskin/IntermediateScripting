using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTesting : MonoBehaviour, IKillable, IDamageable<float>
{

    public void Kill()
    {
        //Do something
    }

    public void Damage(float damageTaken)
    {
        // Do something
    }

}
