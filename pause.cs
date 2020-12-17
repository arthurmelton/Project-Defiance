using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pause : MonoBehaviour
{
    public GameObject canvis;
    public GameObject newCanvis;

    public NewControls inputs;

    public GameObject pauseFirstSelect;
    // Start is called before the first frame update
    private void Awake()
    {
        inputs = new NewControls();

        inputs.player.esc.performed += context => show();
    }

    private void Start()
    {
        hide();
    }

    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }

    public void show()
    {
        if(Time.timeScale == 0f)
        {
            hide();
        }
        else
        {
            Time.timeScale = 0f;
            canvis.SetActive(false);
            newCanvis.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(pauseFirstSelect);
        }
    }

    public void hide()
    {
        Time.timeScale = 1f;
        canvis.SetActive(true);
        newCanvis.SetActive(false);
    }
}
