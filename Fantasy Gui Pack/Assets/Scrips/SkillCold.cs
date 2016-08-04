using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkillCold : MonoBehaviour
{

    public float coldTime = 2;

    private float Timer = 0;
    private bool isStart = false;
    private Image bgImage;


    private void Start()
    {
        bgImage = transform.Find("bg1").GetComponent<Image>();
    }


    private void Update()
    {
        if (isStart)
        {
            Timer += Time.deltaTime;
            bgImage.fillAmount = (coldTime - Timer)/coldTime;

            if (Timer>=coldTime)
            {
                bgImage.fillAmount = 0;
                Timer = 0;
                isStart = false;
            }
        }
    }

    public void EnterCold()
    {
        isStart = true;
    }
}
