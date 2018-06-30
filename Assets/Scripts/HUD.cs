using UnityEngine;

public class HUD : MonoBehaviour {

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
