using TMPro;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text[] texts;
    [SerializeField] private StorageData data;
    
    public void SetTexts()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            // TODO: keys like "name" and "age" can be assigned into key list inside data scriptable object.
            
            
            if (texts[i].name.Contains("name"))     // name
            {
                texts[i].text = data.name;
            }
            else if (texts[i].name.Contains("age")) // age
            {
                texts[i].text = data.age.ToString();
            }
            
        }
    }
}
