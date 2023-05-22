using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputController : MonoBehaviour
{
    public TextMeshProUGUI score;

    private static InputController instance;

    void Awake()
    {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            instance = this; 
        }
    }

    public static InputController Instance
    {
        get {return instance;}
    }
    public void UpdateButtonValue(int id)
    {
        score.text = ScoreHelper.ModifyValue(id,int.Parse(score.text)).ToString();
    }
}
