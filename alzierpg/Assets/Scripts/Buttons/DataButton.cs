using System;
using UnityEngine;
using UnityEngine.UI;

public class DataButton : NormalButton
{
    [SerializeField] private InputField[] fields;
    [SerializeField] private StorageData data;
    
    // TODO: Move data button scripts into scene handler, execute at the end of the scene.
    public void SetData()
    {
        for (int i=0; i<fields.Length; i++)
        {
            InputField field = fields[i];

            if (field.name.Contains("name"))        // name
            {
                if (field.text == "")
                {
                    throw new Exception("");
                }
                data.name = field.text;
            }
            else if (field.name.Contains("age"))    // age
            {
                data.age = Int32.Parse(field.text);
            }
        }
    }
    
    public void onClick()
    {
        try
        {
            SetData();
            changeScene(1);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}