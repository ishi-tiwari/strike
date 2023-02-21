using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    public Animator CounterTextAnimator;
    public TextMeshProUGUI CounterText;
    public Button Positive;
    public Button Negative;
    public Button TextButton;
    public int CurrentCounterValue;

    void Start()
    {
        CurrentCounterValue = int.Parse(CounterText.text);
        Positive.onClick.AddListener(OnClickPositive);
        Negative.onClick.AddListener(OnClickNegative);
        TextButton.onClick.AddListener(OnClickText);
    }
    public void OnClickText()
    {
        CounterTextAnimator.SetTrigger("Entry");
    }
    public void OnClickPositive()
    {
        StartCoroutine(OnClickPositiveRoutine());
    }
    IEnumerator OnClickPositiveRoutine()
    {
        CounterTextAnimator.SetTrigger("Increase");
        CurrentCounterValue = CurrentCounterValue + 1;
        yield return new WaitForSeconds(0.2f);
        ChangeText(CurrentCounterValue);
    }
    public void OnClickNegative()
    {
        StartCoroutine(OnClickNegativeRoutine());    
    }
    IEnumerator OnClickNegativeRoutine()
    {
        CounterTextAnimator.SetTrigger("Decrease");
        CurrentCounterValue = CurrentCounterValue - 1;
        yield return new WaitForSeconds(0.2f);
        ChangeText(CurrentCounterValue);
    }

    public void ChangeText(int Value)
    {
        CounterText.text = Value.ToString();
    }
}
