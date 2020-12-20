using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class pause : MonoBehaviour
{
    [FormerlySerializedAs("canvis")] public GameObject canvas;
    [FormerlySerializedAs("newCanvis")] public GameObject newCanvas;

    public GameObject pauseFirstSelect;

    private NewControls _inputs;

    // Start is called before the first frame update
    private void Awake()
    {
        _inputs = new NewControls();

        _inputs.player.esc.performed += context => Show();
    }

    private void Start()
    {
        Hide();
    }

    private void OnEnable()
    {
        _inputs.Enable();
    }

    private void OnDisable()
    {
        _inputs.Disable();
    }

    public void Show()
    {
        if (Time.timeScale == 0f)
        {
            Hide();
        }
        else
        {
            Time.timeScale = 0f;
            canvas.SetActive(false);
            newCanvas.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(pauseFirstSelect);
        }
    }

    public void Hide()
    {
        Time.timeScale = 1f;
        canvas.SetActive(true);
        newCanvas.SetActive(false);
    }
}