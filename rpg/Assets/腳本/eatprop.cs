using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class eatprop : MonoBehaviour
{
    [Header("道具數量")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "洋蔥")
        {
            Destroy(collision.gameObject);
            propCount++;
            textCount.text = "道具數 :" + propCount;

            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }

        }
    }
        private void Update()
        {
            GameOver();
        }
        private void GameOver()
        {
            if (finish)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }





    }
