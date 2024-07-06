using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;    
    [SerializeField] HPBar hpBar;   
    
    public void SetData(Pokemon Pokemon)
    {
        nameText.text = Pokemon.Base.Name;
        levelText.text = "Lvl" + Pokemon.Level;
        hpBar.SetHP((float)Pokemon.HP / Pokemon.MaxHp);
    }
}
