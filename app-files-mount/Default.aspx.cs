using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            strFolder = Server.MapPath("./files/");
            strFolder2 = Server.MapPath("./files/important/");
            strFolder3 = Server.MapPath("./files/important/superimportant/");
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
                    lblUploadResult.Text = strFileName + " already exists on the server!";
                }
                else
                {
                    oFile.PostedFile.SaveAs(strFilePath);
                    oFile.PostedFile.SaveAs(strFilePath2);
                    oFile.PostedFile.SaveAs(strFilePath3);
                    lblUploadResult.Text = strFileName + " has been successfully uploaded.";
                }
            }
            else
            {
                lblUploadResult.Text = "Click 'Chose File' to select the file to upload.";
            }
            // Display the result of the upload.
            frmConfirmation.Visible = true;
        }
    }
}