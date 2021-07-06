using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]

[CreateAssetMenu(fileName ="NewEnemyType", menuName ="ScriptableObjects/EnemySpawnWithScriptableObject" )]
public class EnemyType : ScriptableObject
{
    public Color enemyColor = Color.red;
    public float enemySpeed = 5;
    public Vector3 enemyScale = Vector3.one;
    public string enemyTypeName = "type";

}
