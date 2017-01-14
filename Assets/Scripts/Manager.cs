using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using VRStandardAssets.Utils;

public class Manager : MonoBehaviour
{
    public Text countDownText;
    public Timer timer;

    public RigidbodyFirstPersonController controller;
    public GameObject startUI;
    public SelectionSlider startSlider;
    public GameObject finishUI;
    public SelectionSlider finishSlider;
    public float totalTime = 300.0f;

    void OnEnable()
    {
        startSlider.OnBarFilled += StartTiming;
        finishSlider.OnBarFilled += Exit;
        timer.OnTimerTicked += UpdateUI;
        timer.OnTimerFinished += ShowEndUI;
    }

    void OnDisable()
    {
        startSlider.OnBarFilled -= StartTiming;
        finishSlider.OnBarFilled -= Exit;
        timer.OnTimerTicked -= UpdateUI;
        timer.OnTimerFinished -= ShowEndUI;
    }

    // Use this for initialization
    void Start () {
        controller.enabled = false;
	}

    public void StartTiming()
    {
        controller.enabled = true;
        startUI.SetActive(false);
        timer.StartTimer(totalTime);
    }

    public void Exit()
    {
        Debug.Log("Exiting.....");
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    private void UpdateUI()
    {
        //Debug.Log(timeLeft.ToString("F0"));
        countDownText.text = timer.timeLeft.ToString("F0");
        if (timer.timeLeft < 30.0f)
        {
            countDownText.color = Color.red;
        }
    }

    private void ShowEndUI()
    {
        controller.enabled = false;
        finishUI.SetActive(true);
    }
}
