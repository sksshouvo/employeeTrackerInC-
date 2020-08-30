using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using Newtonsoft.Json;
namespace employee_tracker
{
    class upload_to_server
    {
        public void checkFiles() {
           string[] filePaths = Directory.GetFiles(@"C:\\Users\\Public\\Pictures\\it corner online\\media\\"+Form2.login_email, "*.png");

            foreach (string new_file in filePaths) {
                RestClient restClient = new RestClient(Form2.clientApiLink);
                RestRequest restRequest = new RestRequest("/upload");
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.Method = Method.POST;
                restRequest.AddHeader("Authorization", "Authorization");
                restRequest.AddHeader("Content-Type", "multipart/form-data");
                restRequest.AddFile("files", new_file);
                restRequest.AddParameter("_tokens", Form2._tokens);
                var response = restClient.Execute(restRequest);
                fileUploadResponse jsonData = JsonConvert.DeserializeObject<fileUploadResponse>(response.Content);
                if (jsonData != null) {
                    bool status = jsonData.status;
                    if (status == true && File.Exists(new_file))
                    {
                        File.Delete(new_file);
                    }
                }
                
            }
        }
    }
}
