using UnityEngine;
using System.Collections;

public class TankCameraPos : MonoBehaviour {

    public Camera FPS;
    public int m_PlayerNumber = 1;
    
    // Use this for initialization
    void Start () {

        switch (m_PlayerNumber)
        {
            case 1:
                FPS.rect = new Rect(0f, 0.5f, 0.5f, 0.5f);
                break;
            case 2:
                FPS.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                break;
            case 3:
                FPS.rect = new Rect(0f, 0f, 0.5f, 0.5f);
                break;
            default:
                break;
        }
    }
}
