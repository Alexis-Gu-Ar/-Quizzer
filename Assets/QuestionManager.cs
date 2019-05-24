using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System.Threading;
using System.Threading.Tasks;

public class QuestionManager : MonoBehaviour
{
    private List<Answer> answers;
    private bool isAnswered;
    private PointsManager points;
    
    void Start()
    {
        isAnswered = false;
        answers = new List<Answer>();
        points = GameObject.Find("MyQuiz").gameObject.GetComponent<PointsManager>();
        
        foreach (Transform child in transform)
        {
            Answer childAnswer = child.gameObject.GetComponent<Answer>();
            if (childAnswer)
            {
                answers.Add(childAnswer);
            }
        }
    }

    public void answer(Answer userAnswer)
    {
        foreach (Answer answer in answers)
        {
            answer.highlight();
            answer.disableColider();
        }

        if (userAnswer.isCorrect)
        {
            Debug.Log("The answer is correct!");
            points.increasePoints();
            // TODO: make a correct answer sound
        }
        else
        {
            Debug.Log("The answer is incorrect! :(");
            points.decreasePoints();
            // TODO: make a incorrect answer sound
        }
        int miliseconds = 3000;
        Task.Delay(miliseconds).ContinueWith(t => isAnswered = true);

    }

    public bool IsAnswered
    {
        get { return isAnswered; }
    }

}
