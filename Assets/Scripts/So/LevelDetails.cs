using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelDetailsSO", menuName = "ScrictableObjects/LevelDetails")]
public class LevelDetails : ScriptableObject
{
    public string levelName;
    public int levelIndex;

    public string levelTheme;
    public float levelTransitionTime;
    
}
