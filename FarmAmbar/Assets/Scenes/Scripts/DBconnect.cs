using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class DBconnect : MonoBehaviour, IPointerClickHandler
{
    public GameObject Login;
    public GameObject Pass;
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
        print(Log);
        print(Pas);

        // Create a SELECT query
        string query = $"INSERT INTO `player`(`Name`, `Password`) VALUES ('{Log}','{Pas}')";

        // Create a MySqlCommand object
        MySqlCommand command = new MySqlCommand(query, connection);

        // Execute the query and read the results
        MySqlDataReader reader = command.ExecuteReader();

        // Close the reader and connection
        reader.Close();
        // Close the connection
        connection.Close();
    }
}

