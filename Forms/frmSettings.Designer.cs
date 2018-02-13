namespace SheetMaker {
    partial class frmSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDisableErrors = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.Checked = true;
            this.chkClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClear.Location = new System.Drawing.Point(43, 35);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(126, 17);
            this.chkClear.TabIndex = 0;
            this.chkClear.Text = "Clear after generating";
            this.chkClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDisableErrors
            // 
            this.chkDisableErrors.AutoSize = true;
            this.chkDisableErrors.Location = new System.Drawing.Point(43, 70);
            this.chkDisableErrors.Name = "chkDisableErrors";
            this.chkDisableErrors.Size = new System.Drawing.Size(89, 17);
            this.chkDisableErrors.TabIndex = 3;
            this.chkDisableErrors.Text = "Disable errors";
            this.chkDisableErrors.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "the vast emptiness of the settings form is much like how i feel\r\n\r\nempty and nobo" +
    "dy cares";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDisableErrors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkClear);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 258);
            this.MinimumSize = new System.Drawing.Size(382, 258);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDisableErrors;
        private System.Windows.Forms.Label label1;
    }
}