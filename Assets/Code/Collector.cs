using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    public Text poinsText;
    public Material mat;
    public GameObject lvl1;
    int Points = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueBall") && mat.color == Color.blue)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(4.69f, -8.67f), 1, Random.Range(-10.96f, 7.14f)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
        else{
            
        }
        if (other.gameObject.CompareTag("RedBall") && mat.color == Color.red)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(4.69f, -8.67f), 1, Random.Range(-10.96f, 7.14f)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
        if (other.gameObject.CompareTag("GreenBall") && mat.color == Color.green)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(4.69f, -8.67f), 1, Random.Range(-10.96f, 7.14f)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
    }

    private void randomColor()
    {
        Color[] colors = new Color[3];
        colors[0] = Color.green;
        colors[1] = Color.red;
        colors[2] = Color.blue;

        mat.color = colors[Random.Range(0, colors.Length)];
    }

    void ReloadLvl()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

//-50, 50
//50, -50*/
