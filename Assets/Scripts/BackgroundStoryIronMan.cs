using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundStoryIronMan : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI bgStoryText;

    void Start()
    {
        Debug.Log("Displaying info for Ironman");
        nameText.text = "Ironman";
        bgStoryText.text = "Background Story\n\nTony Stark, a genius billionaire inventor, becomes Iron Man using his powered suit of armor equipped with advanced technology and weaponry. Iron Man's suit grants him flight, superhuman strength, and an array of energy-based attacks. Tony Stark uses his intellect and resources to defend the world from threats, balancing his dual identity as both a hero and industrialist.";
    }
}
