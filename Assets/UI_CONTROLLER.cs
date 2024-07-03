using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_CONTROLLER : MonoBehaviour
{
   public TextMeshProUGUI leftPlayerScore;
   public TextMeshProUGUI rigthPlayerScore;

   public void setLeftPlayerScore(string text){
    leftPlayerScore.SetText(text);
   }

   public void setRigthPlayerScore(string text){
    rigthPlayerScore.SetText(text);
   }

}
