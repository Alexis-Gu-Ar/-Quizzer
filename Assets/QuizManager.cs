using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    private int curQuestion;
    private int numberOfQuestions;
    private QuestionManager question;
    // Start is called before the first frame update
    void Start()
    {
        curQuestion = 0;
        numberOfQuestions = 5;
        activeQuestion(curQuestion, true);
        question = getQuestion(curQuestion);
    }

    // Update is called once per frame
    void Update()
    {
        if (question.IsAnswered && curQuestion < numberOfQuestions - 1)
        {
            activeQuestion(curQuestion, false);
            curQuestion++;
            activeQuestion(curQuestion, true);
            question = getQuestion(curQuestion);
        }
        else if (question.IsAnswered && curQuestion == numberOfQuestions - 1) // is the last question
        {
            activeQuestion(curQuestion, false);
            transform.Find("gameover").gameObject.SetActive(true);
        }
    }

    void activeQuestion(int index, bool active)
    {
        transform.Find("Question" + index.ToString()).gameObject.SetActive(active);
    }

    private QuestionManager getQuestion(int index)
    {
        return transform.Find("Question" + index.ToString()).GetComponent<QuestionManager>();
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
