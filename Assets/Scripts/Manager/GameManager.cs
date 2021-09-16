using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;
    public int CURRENT_ROW;
    public int PIECES_IN_ROW;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    

    [SerializeField]
    private GameObject paddlePrefab = null;




    private void Awake()
    {
        for (int CURRENT_ROW = 0; CURRENT_ROW <= TOTAL_ROWS; CURRENT_ROW++)
        {
            for (int PIECES_IN_ROW = 0; PIECES_IN_ROW <= PIECE_COUNT_PER_ROW; PIECES_IN_ROW++)
            {
                Instantiate(piecePrefab, new Vector3(PIECES_IN_ROW * PIECE_LENGTH - 6, CURRENT_ROW * ROW_HEIGHT, 0), Quaternion.identity);
            }
        }
    }

    private void Start()
    {
        
    }

    public void Update()
    {


    }


    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with **DONE**
}
