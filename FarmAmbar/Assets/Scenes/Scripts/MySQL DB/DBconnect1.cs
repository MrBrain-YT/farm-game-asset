using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DBconnect1 : MonoBehaviour, IPointerClickHandler
{
    public GameObject Welcome;
    // The database connection string
    private string connectionString = "server=localhost;port=3306;database=players;uid=root;password=root";

    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        // Create a connection to the database
        MySqlConnection connection = new MySqlConnection(connectionString);

        // Open the connection
        connection.Open();

        // Check if the connection is open
        if (connection.State == ConnectionState.Open)
        {
            Debug.Log("Connected to database.");
            
        }
        else
        {
            Debug.Log("Failed to connect to database.");
        }
        string Log = GameObject.Find("TextLogin").GetComponent<TextMeshProUGUI>().text;
        string Pas = GameObject.Find("Pass").GetComponent<TMP_InputField>().text;

        // Create a SELECT query
        string query = $"SELECT Name FROM player WHERE Name = '{Log}'";

        // Create a MySqlCommand object
        MySqlCommand command = new MySqlCommand(query, connection);

        object result = command.ExecuteScalar();
        print(result);
        if (result != null)
        {
            string query1 = $"SELECT Password FROM player WHERE Name = '{Log}'";

            // Create a MySqlCommand object
            MySqlCommand command1 = new MySqlCommand(query1, connection);

            object result1 = command1.ExecuteScalar();
            if (Pas == result1.ToString())
            {
                Welcome.SetActive(true);
                SceneManager.LoadScene(2);
            }
            else
            {
                Welcome.SetActive(false);
            }
        }
        else
        {
            Welcome.SetActive(false);
        }


        
        // Execute the query and read the results
        MySqlDataReader reader = command.ExecuteReader();
        
        //if ()

        // Close the reader and connection
        reader.Close();
        
        // Close the connection
        connection.Close();
    }
}

