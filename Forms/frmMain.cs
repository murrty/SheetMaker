using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetMaker {
    public partial class frmMain : Form {
        List<string> cueM = new List<string>();
        List<string> cueS = new List<string>();
        List<string> m3u8 = new List<string>();

        List<string> cueTitle = new List<string>();
        List<string> cueArtist = new List<string>();
        List<string> cueIndex = new List<string>();

        List<string> ScueTitle = new List<string>();
        List<string> ScueArtist = new List<string>();
        List<string> ScueIndex = new List<string>();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);

        public frmMain() {
            InitializeComponent();
            SendMessage(txtName.Handle, 0x1501, (IntPtr)1, "Enter a file name...");

            SendMessage(txtCueTitle.Handle, 0x1501, (IntPtr)1, "Playlist title");
            SendMessage(txtCuePerformer.Handle, 0x1501, (IntPtr)1, "Performer");
            SendMessage(txtCueGenre.Handle, 0x1501, (IntPtr)1, "Genre");
            SendMessage(txtCueDate.Handle, 0x1501, (IntPtr)1, "Year");

            SendMessage(txtScueTitle.Handle, 0x1501, (IntPtr)1, "Playlist title");
            SendMessage(txtScuePerformer.Handle, 0x1501, (IntPtr)1, "Performer");
            SendMessage(txtScueGenre.Handle, 0x1501, (IntPtr)1, "Genre");
            SendMessage(txtScueDate.Handle, 0x1501, (IntPtr)1, "Year");
        }

        #region Cue (multiple)
        private void lbCUE_SelectedIndexChanged(object sender, EventArgs e) {
            txtTitle.Text = cueTitle[lbCUE.SelectedIndex];
            txtPerformer.Text = cueArtist[lbCUE.SelectedIndex];
            txtIndex.Text = cueIndex[lbCUE.SelectedIndex];
        }

        private void txtTitle_TextChanged(object sender, EventArgs e) {
            cueTitle[lbCUE.SelectedIndex] = txtTitle.Text;
        }
        private void txtPerformer_TextChanged(object sender, EventArgs e) {
            cueArtist[lbCUE.SelectedIndex] = txtPerformer.Text;
        }
        private void txtIndex_TextChanged(object sender, EventArgs e) {
            cueIndex[lbCUE.SelectedIndex] = txtIndex.Text;
        }
        #endregion

        #region Cue (single)
        private void btnBrws_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog() { Title = "Select a file...", Multiselect = false };
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtCueFile.Text = ofd.FileName;
                ScueTitle.Add(Path.GetFileName(ofd.FileName));
                ScueArtist.Add("( artist name here )");
                ScueIndex.Add("00:00:00");
                lbCueTracks.Items.Add("Track 1");
                cueS.Add("Track 1");
            }
        }

        private void lbCueTracks_SelectedIndexChanged(object sender, EventArgs e) {
            txtStTitle.Text = ScueTitle[lbCueTracks.SelectedIndex];
            txtStArtist.Text = ScueArtist[lbCueTracks.SelectedIndex];
            txtStIndex.Text = ScueIndex[lbCueTracks.SelectedIndex];
        }

        private void txtStTitle_TextChanged(object sender, EventArgs e) {
            ScueTitle[lbCueTracks.SelectedIndex] = txtStTitle.Text;
        }
        private void txtStArtist_TextChanged(object sender, EventArgs e) {
            ScueArtist[lbCueTracks.SelectedIndex] = txtStArtist.Text;
        }
        private void txtStIndex_TextChanged(object sender, EventArgs e) {
            ScueIndex[lbCueTracks.SelectedIndex] = txtStIndex.Text;
        }
        #endregion

        #region m3u8
             //————————————————————————————————————————————————\\
            //        The race was definitely underway.         \\
           // I'd wintnessed the start, I was sure of that much. \\
          //                    But what now?                     \\
         //                   What comes next?                     \\
        //——————————————————————————————————————————————————————————\\
        #endregion

        private void btnGenerate_Click(object sender, EventArgs e) {
            string fileName = "output";
            string output = string.Empty;

            if (!string.IsNullOrEmpty(txtName.Text))
                fileName = txtName.Text;

            switch (tcMain.SelectedIndex) {
                case 0:
                    // cue (multiple)
                    if (!fileName.EndsWith(".cue"))
                        fileName += ".cue";

                    if (!string.IsNullOrEmpty(txtCueGenre.Text))
                        output += "REM GENRE " + txtCueGenre.Text + "\n";
                    if (!string.IsNullOrEmpty(txtCueDate.Text))
                        output += "REM DATE " + txtCueDate.Text + "\n";
                    if (!string.IsNullOrEmpty(txtCuePerformer.Text))
                        output += "PERFORMER \"" + txtCuePerformer.Text + "\"\n";
                    if (!string.IsNullOrEmpty(txtCueTitle.Text))
                        output += "TITLE \"" + txtCueTitle.Text + "\"\n";

                    for (int y = 0; y < cueM.Count; y++) {
                        if (Path.GetFileName(cueM[y]).EndsWith(".mp3"))
                            output += "FILE \"" + Path.GetFileName(cueM[y]) + "\" MP3\n";
                        else if (Path.GetFileName(cueM[y]).EndsWith(".aiff"))
                            output += "FILE \"" + Path.GetFileName(cueM[y]) + "\" AIFF\n";
                        else
                            output += "FILE \"" + Path.GetFileName(cueM[y]) + "\" WAVE\n";

                        output += "  TRACK 0" + (y + 1).ToString() + " AUDIO\n";
                        output += "    TITLE \"" + ScueTitle[y] + "\"\n";

                        if (cueArtist[y] != "( arist name here )") {
                            output += "    PERFORMER \"" + ScueArtist[y] + "\"\n";
                        }

                        if (y == 0 && cueIndex[y] == "00:00:00" && cueIndex[y + 1] != "00:00:00") {
                            output += "    INDEX 01 " + ScueIndex[y] + "\n";
                        }
                        else if (cueIndex[y] != "00:00:00") {
                            output += "    INDEX 01 " + ScueIndex[y] + "\n";
                        }
                    }

                    File.WriteAllText(Environment.CurrentDirectory + "\\" + fileName, output);
                    Debug.Print("\n\n\n" + output);

                    if (Properties.Settings.Default.clearAfterGen) {
                        lbCUE.Items.Clear();

                        txtCueGenre.Clear();
                        txtCueDate.Clear();
                        txtCuePerformer.Clear();
                        txtCueTitle.Clear();
                        txtTitle.Clear();
                        txtPerformer.Clear();
                        txtIndex.Clear();

                        cueTitle.Clear();
                        cueArtist.Clear();
                        cueIndex.Clear();

                        cueM.Clear();

                        txtName.Clear();
                    }
                    break;
                case 1:
                    // cue (single)
                    if (!fileName.EndsWith(".cue"))
                        fileName += ".cue";

                    if (!string.IsNullOrEmpty(txtScueGenre.Text))
                        output += "REM GENRE " + txtScueGenre.Text + "\n";
                    if (!string.IsNullOrEmpty(txtScueDate.Text))
                        output += "REM DATE " + txtScueDate.Text + "\n";
                    if (!string.IsNullOrEmpty(txtScuePerformer.Text))
                        output += "PERFORMER \"" + txtScuePerformer.Text + "\"\n";
                    if (!string.IsNullOrEmpty(txtScueTitle.Text))
                        output += "TITLE \"" + txtScueTitle.Text + "\"\n";

                    if (Path.GetFileName(txtCueFile.Text).EndsWith(".mp3"))
                        output += "FILE \"" + Path.GetFileName(txtCueFile.Text) + "\" MP3\n";
                    else if (Path.GetFileName(txtCueFile.Text).EndsWith(".aiff"))
                        output += "FILE \"" + Path.GetFileName(txtCueFile.Text) + "\" AIFF\n";
                    else
                        output += "FILE \"" + Path.GetFileName(txtCueFile.Text) + "\" WAVE\n";

                    for (int y = 0; y < cueS.Count; y++) {
                        output += "  TRACK 0" + (y + 1).ToString() + " AUDIO\n";
                        output += "    TITLE \"" + ScueTitle[y] + "\"\n";

                        if (ScueArtist[y] != "( arist name here )") {
                            output += "    PERFORMER \"" + ScueArtist[y] + "\"\n";
                        }

                        if (y == 0 && ScueIndex[y] == "00:00:00" && ScueIndex[y + 1] != "00:00:00") {
                            output += "    INDEX 01 " + ScueIndex[y] + "\n";
                        }
                        else if (ScueIndex[y] != "00:00:00") {
                            output += "    INDEX 01 " + ScueIndex[y] + "\n";
                        }
                    }

                    File.WriteAllText(Environment.CurrentDirectory + "\\" + fileName, output);
                    Debug.Print("\n\n\n" + output);
                    if (Properties.Settings.Default.clearAfterGen) {
                        lbCueTracks.Items.Clear();
                        cueS.Clear();
                        ScueTitle.Clear();
                        ScueArtist.Clear();
                        ScueIndex.Clear();

                        txtScueTitle.Clear();
                        txtScuePerformer.Clear();
                        txtScueGenre.Clear();
                        txtScueDate.Clear();
                        txtStTitle.Clear();
                        txtStArtist.Clear();
                        txtStIndex.Clear();

                        txtName.Clear();
                    }
                    break;
                case 2:
                    // m3u8
                    if (!fileName.EndsWith(".m3u8"))
                        fileName += ".m3u8";
                    for (int y = 0; y < m3u8.Count; y++)
                        output += Path.GetFileName(m3u8[y]) + "\n";
                    
                    File.WriteAllText(Environment.CurrentDirectory + "\\" + fileName, output);
                    Debug.Print("\n\n\n" + output);
                    if (Properties.Settings.Default.clearAfterGen) {
                        lbM3U8.Items.Clear();
                        m3u8.Clear();
                        txtName.Clear();
                    }
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (tcMain.SelectedIndex == 1) {
                lbCueTracks.Items.Add("Track " + (lbCueTracks.Items.Count + 1).ToString());

                cueS.Add("Track " + (cueS.Count + 1).ToString());

                if (string.IsNullOrEmpty(txtStTitle.Text))
                    ScueTitle.Add("No title");
                else
                    ScueTitle.Add(txtStTitle.Text);

                if (string.IsNullOrEmpty(txtStArtist.Text))
                    ScueArtist.Add("( artist name here )");
                else
                    ScueArtist.Add(txtStArtist.Text);

                if (string.IsNullOrEmpty(txtStIndex.Text))
                    ScueIndex.Add("00:00:00");
                else
                    ScueIndex.Add(txtStIndex.Text);
            }
            else {
                OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, CheckFileExists = true };
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    for (int y = 0; y < ofd.FileNames.Length; y++) {
                        if (tcMain.SelectedIndex == 0) {
                            lbCUE.Items.Add(Path.GetFileName(ofd.FileNames[y]));
                            cueM.Add(ofd.FileNames[y]);
                            cueTitle.Add(Path.GetFileNameWithoutExtension(ofd.FileNames[y]));
                            cueArtist.Add("( arist name here )");
                            cueIndex.Add("00:00:00");
                        }
                        else if (tcMain.SelectedIndex == 2) {
                            lbM3U8.Items.Add(Path.GetFileName(ofd.FileNames[y]));
                            m3u8.Add(ofd.FileNames[y]);
                        }
                    }
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            switch (tcMain.SelectedIndex) {
                case 0:
                    cueM.RemoveAt(lbCUE.SelectedIndex);
                    cueArtist.RemoveAt(lbCUE.SelectedIndex);
                    cueTitle.RemoveAt(lbCUE.SelectedIndex);
                    cueIndex.RemoveAt(lbCUE.SelectedIndex);
                    lbCUE.Items.RemoveAt(lbCUE.SelectedIndex);
                    break;
                case 1:
                    cueS.RemoveAt(lbCueTracks.SelectedIndex);
                    ScueArtist.RemoveAt(lbCueTracks.SelectedIndex);
                    ScueTitle.RemoveAt(lbCueTracks.SelectedIndex);
                    ScueIndex.RemoveAt(lbCueTracks.SelectedIndex);
                    lbCueTracks.Items.RemoveAt(lbCUE.SelectedIndex);
                    break;
                case 2:
                    m3u8.RemoveAt(lbM3U8.SelectedIndex);
                    lbM3U8.Items.RemoveAt(lbM3U8.SelectedIndex);
                    break;
            }
        }
        
        private void mSettings_Click(object sender, EventArgs e) {
            frmSettings settings = new frmSettings();
            settings.Show();
        }
        private void mAbout_Click(object sender, EventArgs e) {
            About frmAbout = new About();
            frmAbout.Show();
        }
    }
}
