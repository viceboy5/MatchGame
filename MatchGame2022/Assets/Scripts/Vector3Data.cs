using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public int direction;

    public void UpdateValue(int newDirection)
    {
        direction = newDirection +=1;
    }
}
