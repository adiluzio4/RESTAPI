using System;
using System.Windows.Forms;  // For displaying MessageBox
using GraphQL;  // GraphQL related namespaces
using GraphQL.Client.Abstractions.Websocket;
using GraphQL.Client.Http;
using GraphQL.Types;
using Newtonsoft.Json;  // Newtonsoft.Json for JSON serialization
using GraphQL.Client.Serializer.Newtonsoft;

namespace RESTexample
{
    internal class GQL
    {
        GraphQLHttpClient client;  // GraphQL HTTP client
        string response;  // Variable to store the response from the GraphQL server

        // Property to get the response from the GraphQL server
        public string Response { get { return response; } }

        // Default constructor
        public GQL() { }

        // Constructor with GraphQL API URL parameter
        public GQL(string gqlApiUrl)
        {
            try
            {
                // Initialize the GraphQL HTTP client with the provided API URL and NewtonsoftJsonSerializer
                client = new GraphQLHttpClient(new GraphQLHttpClientOptions() { EndPoint = new Uri(gqlApiUrl) }, new NewtonsoftJsonSerializer());
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during initialization
                MessageBox.Show(ex.Message + "   |   " + ex.StackTrace);
            }
        }

        // Method to set the GraphQL HTTP client with a new API URL
        public void SetGqlHttpClient(string gqlApiUrl)
        {
            client = new GraphQLHttpClient(new GraphQLHttpClientOptions() { EndPoint = new Uri(gqlApiUrl) }, new NewtonsoftJsonSerializer());
        }

        // Method to execute a GraphQL query
        public void ExecuteGqlQuery(string gqlQuery)
        {
            // Create a GraphQLRequest with the provided query
            var request = new GraphQLRequest
            {
                Query = gqlQuery
            };

            try
            {
                // Send the GraphQL query asynchronously and get the result
                var result = client.SendQueryAsync<string>(request).Result;

                // Check if there are no errors in the result
                if (result.Errors.Length == 0)
                {
                    // Set the response variable with the data from the result
                    response = result.Data;
                }
                else
                {
                    // Set the response variable with the errors from the result
                    response = result.Errors.ToString();
                }
            }
            catch (GraphQLHttpRequestException gqlex)
            {
                // Display an error message if a GraphQL HTTP request exception occurs
                MessageBox.Show(gqlex.Message + "   |   " + gqlex.StackTrace);
            }
            catch (Exception ex)
            {
                // Display an error message for other exceptions
                MessageBox.Show(ex.Message + "   |   " + ex.StackTrace);
            }
        }
    }
}
