using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Net;
using System.Text.Json;

namespace RESTexample
{
    // A class representing a simple REST client for making HTTP requests
    internal class RESTclient
    {
        private HttpClient client; // The HttpClient instance used for making HTTP requests

        // An enumeration representing different types of content for HTTP requests
        public enum httpContentType
        {
            str,     // String content
            stream,  // Stream content
            json,    // JSON content (currently commented out due to version compatibility)
        }

        // Default constructor initializing the HttpClient without a base address
        public RESTclient()
        {
            client = new HttpClient();
        }

        // Constructor initializing the HttpClient with a specified base address
        public RESTclient(string url)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
        }

        // Method to set a new base address for the HttpClient
        public void SetBaseAddress(string newUrl)
        {
            client.BaseAddress = new Uri(newUrl);
        }

        // Method to set default request headers for the HttpClient
        public void SetDefaultRequestHeaders(List<string> defaultRequestHeaders)
        {
            foreach (string header in defaultRequestHeaders)
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));
            }
        }

        // Method to generate HttpContent based on content and type
        private HttpContent GenHttpContent(object content, httpContentType type)
        {
            switch (type)
            {
                case httpContentType.str:
                    return new StringContent((string)content, Encoding.UTF8);
                case httpContentType.stream:
                    return new StreamContent((System.IO.Stream)content);
                default:
                    return new StringContent((string)content, Encoding.UTF8);
            }
        }

        // Method to perform a GET request and return the response content as a string
        public string GET(string urlParameters)
        {
            try
            {
                var response = client.GetAsync(urlParameters).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }
            }
            catch (InvalidOperationException invex)
            {
                MessageBox.Show(invex.Message);
                return "Invalid Operation Exception thrown: Invalid URI provided.";
            }
            catch (HttpRequestException httpex)
            {
                MessageBox.Show(httpex.Message);
                return "HTTP Request Exception thrown: The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.";
            }
            catch (TaskCanceledException taskex)
            {
                MessageBox.Show(taskex.Message);
                return "Task Exception thrown: The request failed due to timeout.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return $"Exception thrown: {ex.Message}";
            }
        }

        // Method to perform a POST request and return the response content as a string
        public string POST(object HttpContent, httpContentType type)
        {
            try
            {
                var response = client.PostAsync(client.BaseAddress, this.GenHttpContent(HttpContent, type)).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }
            }
            catch (InvalidOperationException invex)
            {
                MessageBox.Show(invex.Message);
                return "Invalid Operation Exception thrown: Invalid URI provided.";
            }
            catch (HttpRequestException httpex)
            {
                MessageBox.Show(httpex.Message);
                return "HTTP Request Exception thrown: The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.";
            }
            catch (TaskCanceledException taskex)
            {
                MessageBox.Show(taskex.Message);
                return "Task Exception thrown: The request failed due to timeout.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return $"Exception thrown: {ex.Message}";
            }
        }

        // Method to perform a PUT request and return the response content as a string
        public string PUT(object HttpContent, httpContentType type)
        {
            try
            {
                var response = client.PutAsync(client.BaseAddress, this.GenHttpContent(HttpContent, type)).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }
            }
            catch (InvalidOperationException invex)
            {
                MessageBox.Show(invex.Message);
                return "Invalid Operation Exception thrown: Invalid URI provided.";
            }
            catch (HttpRequestException httpex)
            {
                MessageBox.Show(httpex.Message);
                return "HTTP Request Exception thrown: The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.";
            }
            catch (TaskCanceledException taskex)
            {
                MessageBox.Show(taskex.Message);
                return "Task Exception thrown: The request failed due to timeout.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return $"Exception thrown: {ex.Message}";
            }
        }

        // Method to perform a DELETE request and return the response content as a string
        public string DELETE(string urlParameters)
        {
            try
            {
                var response = client.DeleteAsync(urlParameters).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception($"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }
            }
            catch (InvalidOperationException invex)
            {
                MessageBox.Show(invex.Message);
                return "Invalid Operation Exception thrown: Invalid URI provided.";
            }
            catch (HttpRequestException httpex)
            {
                MessageBox.Show(httpex.Message);
                return "HTTP Request Exception thrown: The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.";
            }
            catch (TaskCanceledException taskex)
            {
                MessageBox.Show(taskex.Message);
                return "Task Exception thrown: The request failed due to timeout.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return $"Exception thrown: {ex.Message}";
            }
        }
    }
}
