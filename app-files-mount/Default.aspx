<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="app_files_mount._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Using Azure Files to store files with mount of App Services</h1>
            <p class="lead">This is a simple code that save files in a Azure Files using App Services</p>
            <p><a target="_blank" href="https://learn.microsoft.com/en-us/azure/app-service/configure-connect-to-azure-storage?pivots=code-windows&tabs=basic%2Cportal#configure-your-app-with-azure-storage">Microsoft Documentation &raquo;</a></p>



        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Upload content</h2>
                <p>
                    <input id="oFile" type="file" runat="server" name="oFile">
                    <p></p>
                    <asp:Button ID="btnUpload" type="submit" Text="Upload" runat="server" OnClick="btnUpload_Click" class="btn btn-primary btn-md" Width="140px"></asp:Button>
                    <asp:Panel ID="frmConfirmation" Visible="False" runat="server">
                        <asp:Label ID="lblUploadResult" runat="server"></asp:Label>
                    </asp:Panel>
                </p>

            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Use Storage Explorer</h2>
                <p>
                    Upload, download, and manage Azure Storage blobs, files, queues, and tables, as well as Azure Data Lake Storage entities and Azure managed disks. Configure storage permissions and access controls, tiers, and rules.
                </p>
                <p>
                    <a class="btn btn-default" target="_blank" href="https://azure.microsoft.com/en-us/products/storage/storage-explorer">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Use Kudu</h2>
                <p>
                    Kudu is the engine behind some features in Azure App Service that are related to source-control-based deployment and other deployment methods, like Dropbox and OneDrive sync.
                </p>
                <p>App not in the Isolated tier: https://<app-name>.scm.azurewebsites.net</p>
                <p>Internet-facing app in the Isolated tier (App Service Environment): https://<app-name>.scm.<ase-name>.p.azurewebsites.net</p>
                <p>Internal app in the Isolated tier (App Service Environment for internal load balancing): https://<app-name>.scm.<ase-name>.appserviceenvironment.net</p>
               
                <p>
                    <a class="btn btn-default"  target="_blank" href="https://learn.microsoft.com/en-us/azure/app-service/resources-kudu">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
