using UnityEngine;

public class NameData : ScriptableObject
{
   public string name;

   public void UpdateName(string otherObjectName)
   {
      name = otherObjectName;
   }
}