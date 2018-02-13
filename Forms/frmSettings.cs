using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetMaker {
    public partial class frmSettings : Form {
        public frmSettings() {
            InitializeComponent();
        }

        private void LoadSettings() {
            chkClear.Checked = Properties.Settings.Default.clearAfterGen;
            chkDisableErrors.Checked = Properties.Settings.Default.disableErrors;
        }

        private void SaveSettings() {
            if (Properties.Settings.Default.clearAfterGen != chkClear.Checked)
                Properties.Settings.Default.clearAfterGen = chkClear.Checked;
            if (Properties.Settings.Default.disableErrors != chkDisableErrors.Checked)
                Properties.Settings.Default.disableErrors = chkDisableErrors.Checked;

            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveSettings();
            this.Dispose();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
