using UnityEngine;

[CreateAssetMenu]
public class CharacterDataBank : ScriptableObject
{
    public float ground = 1f;
    public void UpdateValue(float amount)
    {
        ground += amount;
    }
}