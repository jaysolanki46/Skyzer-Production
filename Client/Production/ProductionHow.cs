using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Client.Production
{
    public partial class ProductionHow : Form
    {
        public ProductionHow()
        {
            InitializeComponent();
        }

        private void hideControls()
        {
            buttonMainImage.Visible = false;
            labelMainText.Visible = false;
        }

        private void ProductionHow_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {
            labelHeader.Left = (this.panelHeader.Width - labelHeader.Width) / 2;
            labelHeader.Top = (this.panelHeader.Height - labelHeader.Height) / 2;
        }

        private void ButtonReActivate_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageReActivate;
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageTest;
        }

        private void ButtonSWLoad_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageSWLoad;
        }

        private void ButtonPaperWork_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPagePaperWork;
        }

        private void ButtonKeyLoad_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageKeyLoad;
        }

        private void ButtonSendKey_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageSendKey;
        }

        private void ButtonLogOn_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.SelectedTab = tabPageLogon;
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            hideControls();
            tabControlProduction.Visible = true;
        }

        private void ButtonReactiveTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonTestTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonSWLoadTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonPaperWorkTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonKeyLoadTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonSendKeyTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void ButtonLogOnTutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gFVccNdtrJs");
        }

        private void PanelReactivate_Paint(object sender, PaintEventArgs e)
        {
            labelinitNoteForReActivation.Text = "Check the paper work from which stage you have to start? If it is s/w upgrade only please directly jump to stage 3.";
            labelStage1ForReActivation.Text =  "Open FLIT -> " +
                "Scan the barcode serial number from the back terminal (#1800CT.....) -> " +
                "Click Cancel -> Download (F5) -> Wait till yellow lable turns in blue -> " +
                "Connect USB & Power Cabel -> It will get start the download -> " +
                "let them process utill it shows 'Special Mock-up on screen' -> " +
                "Time to stage 2";
            labelStage2labelStage1ForReActivation.Text = "Make sure terminal connected with S2 USB cabel (comes from CPU) & Power cabel before you start Stage 2 -> Open WinTest ->" +
                "Scan the terminal product reference -> Click 'Yes' -> Scan serial number -> Scan terminal product reference -> Scan terminal IMEI number -> " +
                "Let them test -> Abort -> close the application";
            labelStage3labelStage1ForReActivation.Text = "Disconnect all the connections with terminal -> " +
                "Open FLIT -> Select the file -> search for the product reference file -> Download -> Let that label turns blue -> Connect poer cabel and USB with twerminal ->" +
                "Let them download till terminal screen shows languages 'English' & 'French',";
            labelEndNotelabelStage1ForReActivation.Text = "Make sure terminal screen is not showing any error like 'Unauthorized' or 'Alert Irruption'" +
                "Check and verify terminal with paper work," +
                "Keep terminal in testing section if it service," +
                "If it is S/W upgrade no need to test";
        }

        private void PanelTest_Paint(object sender, PaintEventArgs e)
        {
            labelInItNoteForTest.Text = "If terminal came from service departmaent then and then only you have to perform testing, First, Connect testing pen-drive to terminal, M.box with Ethernet and Modem cabel then connect with Power cabel";
            labelPerformForTest.Text = "Press F4 while starting the terminal -> " +
                "select product reference code like (#ICT220-...) -> " +
                "Let them start -> Press 7-Auto tets -> It will start the testing the terminal -> " +
                "Follow the steps -> After successfull test do LLT by restart your terminal and press MENU -> Delete All";
            labelEndNoteForTest.Text = "If you found any error while testing please note terminal details and update issue to particular Technician who assigned to that terminal for repair.";
        }

        private void PanelSWLoad_Paint(object sender, PaintEventArgs e)
        {
            labelInItNoteForSWLoad.Text = "Connect S/W load pendrive to terminal -> power up your terminal and before you do S/W load terminal should be on LLT (Restart -> MENU) mode";
            labelStage1ForSWLoad.Text = "Clear + FUNC -> F4 (Long press) -> Now you can see the list of stages -> perform stage 1";
            labelStage2ForSWLoad.Text = "Clear + FUNC -> F4 (Long press) -> perform stage 2";
            labelStage3ForSWLoad.Text = "After stage 2 for this terminal check the size in printed paper if it says 32 bits then do 'stage 3'," +
                "but if it showing 16 then you have to change the size to 9 -> do 'Stage 3 - ICT 220'";
            labelStage4ForSWLoad.Text = "Not required if you changed the size from 6 to 9, If not then do stage 4";
            labelStage5ForSWLoad.Text = "N/A";
            labelStage6ForSWLoad.Text = "N/A";
            labelStage7ForSWLoad.Text = "N/A";
            labelEndNoteForSWLoad.Text = "Func -> 99 -> verify the s/w load was correct?";
        }
    }
}
