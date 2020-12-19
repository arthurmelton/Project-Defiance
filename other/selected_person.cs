using UnityEngine;

namespace other
{
    public class selected_person : MonoBehaviour
    {
        public int selected;
    
        public void bow()
        {
            selected = 1;

            PlayerPrefs.SetInt("Selcted", selected);
            PlayerPrefs.Save();
        }

        public void Crossbow()
        {
            selected = 2;

            PlayerPrefs.SetInt("Selcted", selected);
            PlayerPrefs.Save();
        }

        public void dual()
        {
            selected = 3;

            PlayerPrefs.SetInt("Selcted", selected);
            PlayerPrefs.Save();
        }

        public void Sniper()
        {
            selected = 4;

            PlayerPrefs.SetInt("Selcted", selected);
            PlayerPrefs.Save();
        }

        public void Uzi()
        {
            selected = 5;

            PlayerPrefs.SetInt("Selcted", selected);
            PlayerPrefs.Save();
        }
    }
}
