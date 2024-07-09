using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject exampleChip;
    public bool isInstatiated = false;
    public float row = 3.0f;
    public int column = 5;
    public Vector3 target;
    public Vector3 SpawnPosition;
    public float speed = 5f;
    public MoveCoin moveCoinScript;




    Player activePlayer = Player.One;

    


    public void Awake()
    {
        if (exampleChip == null)
        {
            Debug.LogError("You must set 'exampleChip to a valid game prefab.'");
        }

        // SpawnPoint exampleChip
        SpawnPosition = BoardPositions.GetWorldPositionAboveBoard(column);

        // Target exampleChip
        // target = BoardPositions.GetWorldPosition(row, column);

        // Test BoardPosition unabhängiges target 
        // target = new Vector3 (3, 3, 0);
      

        


    }


    // The state of the board
    Player[,] boardData = new Player[6,7]
    {
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE },
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE },
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE },
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE },
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE },
        { Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE, Player.NONE }
    };




    void AddStone(int column)
    {
        Debug.Log($"Add Stone {activePlayer} to column {column}.");


        // Münze (exampleChip) über Spielbrett spawnen
        Vector3 SpawnPosition = BoardPositions.GetWorldPositionAboveBoard(column);
        Instantiate(exampleChip, SpawnPosition, Quaternion.identity);
        // isInstatiated = true;

        if (column == 0)
        {
            // MoveCoin();
        }





        /*

        if (isInstatiated == true)
        {
            Debug.Log("Chip sollte sich eig bewegen");
          
            exampleChip.transform.position = Vector3.MoveTowards(SpawnPosition, target, _speed);

            Debug.Log("x = " + exampleChip.transform.position.x + " & y = " + exampleChip.transform.position.y);

        }

        else
        {
            Debug.Log("Chip bewegt sich nicht");
        }
        */

    }


    private void Update()
    {
        
    }

    /*
    void MoveStone()
    {
        Vector3 WolrdPosition = BoardPositions.GetWorldPosition(1f, 2);

        if (exampleChip != null)
        {
            exampleChip.transform.position = WolrdPosition;


            Debug.Log(exampleChip.transform.position);
        }
    
    }
    */
}
    







    /*
        void MoveStone()
        {

            // Get Wolrd Position
            Vector3 GetWorldPosition(float row, int column)
            {

                return new Vector3(row, column);

            }

            if (isInstatiated == true)
            {
                Debug.Log(" is Instatiated = true ");
            }

            // Versuch 3:
            if (isInstatiated == true)
            {
                Debug.Log("Chip sollte sich eig bewegen");

                exampleChip.transform.position = GetWorldPosition(3.0f, 2);
                //exampleChip.transform.position = Vector3.MoveTowards(SpawnPosition,target, speed);

                Debug.Log("x = " + exampleChip.transform.position.x + " & y = " + exampleChip.transform.position.y);
            }

            else
            {
                Debug.Log("Chip bewegt sich nicht");
            }


                // Versuch 2:

                //transform.position = transform.position + new Vector3(0, -1, 0);

                // Versuch 1:


                //GameObject SpawnCoin = Instantiate(exampleChip,SpawnPosition, Quaternion.identity);
                //SpawnCoin.transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime;

                // Münze in row fallen lassen 
        }



        /* 

         private void Update()
         {
            AddStone(column);
            //MoveStone();
         }

        */

















