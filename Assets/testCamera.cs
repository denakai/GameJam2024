using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testCamera : MonoBehaviour
{
    public FollowCamera followCamera;
    public Button button;
    
    public void playGame() {
        followCamera.switchTarget();
        button.interactable = false;
    }
}
