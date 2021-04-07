using UnityEngine;

[CreateAssetMenu(fileName = "NewIntValue", menuName = "Int Value")]
public class IntValue : ScriptableObject
{
    [SerializeField] int _value;
    public int Value => _value;
}
