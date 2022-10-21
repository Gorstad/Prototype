
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static float maxHP = 50;
    public static float HP = 50;
    public Image bar;
    public float fill;
    private void Update()
    {
        if (HP > maxHP) 
        {
            HP = maxHP; 
        }
        fill = HP * 0.02f;
        bar.fillAmount = fill;
    }

        

}
     