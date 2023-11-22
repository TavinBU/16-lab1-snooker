using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    [SerializeField] private int playerScore;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPositions;
    
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        //set ball on the table
        setBalls(BallColors.White,0);
        setBalls(BallColors.Red,1); 
        setBalls(BallColors.Yellow,2);
        setBalls(BallColors.Green,3);
        setBalls(BallColors.Brown,4);
        setBalls(BallColors.Blue,5);
        setBalls(BallColors.Pink,6);
        setBalls(BallColors.Black,7);
        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void setBalls(BallColors color, int pos)
    {
        GameObject ball = Instantiate(ballPrefab, ballPositions[pos].transform.position, Quaternion.identity);
        Ball b = ball.GetComponent<Ball>();
        b.SetColorAndPoint(color);

    }
}
