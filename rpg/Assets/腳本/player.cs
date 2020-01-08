
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("動畫參數名稱")]

    public string perRun = "跑步開關";



    public Animator ani;

    private void Run()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);
    }
    private void Update()
    {
        Run();

    }
}
