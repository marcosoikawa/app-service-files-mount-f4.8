using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace app_files_mount
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string strFileName;
            string strFilePath;
            string strFilePath2;
            string strFilePath3;
            string strFolder;
            string strFolder2;
            string strFolder3;            
            string baseFolder;

            //choose your option:
            int option = 3;

            //FileShare:
            string fileshare = "\\\\MAOIKA-240402\\sharefiles\\";
            string virtualpath = "/files/";
            string phisicalpath = "C:\\mounts\\mountpath\\";


            int.TryParse(ConfigurationManager.AppSettings["option"], out option);
            fileshare = Convert.ToString(ConfigurationManager.AppSettings["fileshare"]);
            virtualpath = Convert.ToString(ConfigurationManager.AppSettings["virtualpath"]);
            phisicalpath = Convert.ToString(ConfigurationManager.AppSettings["phisicalpath"]);

            switch (option)
            {                
                case 1:
                    {
                        baseFolder = fileshare;
                        strFolder = baseFolder;
                        strFolder2 = string.Format("{0}important\\", baseFolder);
                        strFolder3 = string.Format("{0}important\\superimportant\\", baseFolder);
                        break;

                    }
                case 2:
                    {                        
                        baseFolder = virtualpath;
                        strFolder = Server.MapPath(baseFolder);
                        strFolder2 = Server.MapPath(string.Format("{0}important/", baseFolder));
                        strFolder3 = Server.MapPath(string.Format("{0}important/superimportant/", baseFolder));
                        break;

                    }
                default:
                    {                        
                        baseFolder = phisicalpath;
                        strFolder = baseFolder;
                        strFolder2 = string.Format("{0}important\\", baseFolder);
                        strFolder3 = string.Format("{0}important\\superimportant\\", baseFolder);
                        break;

                    }
            }

            // Retrieve the name of the file that is posted.
            strFileName = oFile.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);
            if (oFile.Value != "")
            {
                // Create the folder if it does not exist.
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Save the uploaded file to the server.
                strFilePath = strFolder + strFileName;
                strFilePath2 = strFolder2 + strFileName;
                strFilePath3 = strFolder3 + strFileName;

                if (!Directory.Exists(strFolder))
                    Directory.CreateDirectory(strFolder);
                if (!Directory.Exists(strFolder2))
                    Directory.CreateDirectory(strFolder2);
                if (!Directory.Exists(strFolder3))
                    Directory.CreateDirectory(strFolder3);

                if (File.Exists(strFilePath))
                {
                    lblUploadResult.Text = strFileName + " already exists on the server " + strFilePath;
                }
                else
                {
                    oFile.PostedFile.SaveAs(strFilePath);
                    oFile.PostedFile.SaveAs(strFilePath2);
                    oFile.PostedFile.SaveAs(strFilePath3);
                    lblUploadResult.Text = strFileName + " has been successfully uploaded on: " + strFilePath;
                }
            }
            else
            {
                lblUploadResult.Text = "Click 'Choose File' to select the file to upload.";
            }
            // Display the result of the upload.
            frmConfirmation.Visible = true;
        }
    }
}