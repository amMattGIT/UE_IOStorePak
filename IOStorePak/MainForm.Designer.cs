namespace IOStorePak
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.txtAssetsPath = new System.Windows.Forms.TextBox();
            this.txtChunkNumber = new System.Windows.Forms.TextBox();
            this.chkCleanCooked = new System.Windows.Forms.CheckBox();
            this.chkOpenOutput = new System.Windows.Forms.CheckBox();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.btnPackage = new System.Windows.Forms.Button();
            this.lblUEPath = new System.Windows.Forms.Label();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.lblAssetsPath = new System.Windows.Forms.Label();
            this.lblChunkNumber = new System.Windows.Forms.Label();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.btnBrowseProjectPath = new System.Windows.Forms.Button();
            this.btnBrowseAssetsPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUEPath
            // 
            this.lblUEPath.AutoSize = true;
            this.lblUEPath.Location = new System.Drawing.Point(10, 20);
            this.lblUEPath.Name = "lblUEPath";
            this.lblUEPath.Size = new System.Drawing.Size(140, 13);
            this.lblUEPath.TabIndex = 0;
            this.lblUEPath.Text = "Unreal Engine Directory:";
            // 
            // txtUEPath
            // 
            this.txtUEPath.Location = new System.Drawing.Point(150, 20);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(250, 20);
            this.txtUEPath.TabIndex = 1;
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Location = new System.Drawing.Point(410, 18);
            this.btnBrowseUEPath.Name = "btnBrowseUEPath";
            this.btnBrowseUEPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseUEPath.TabIndex = 2;
            this.btnBrowseUEPath.Text = "Browse...";
            this.btnBrowseUEPath.UseVisualStyleBackColor = true;
            this.btnBrowseUEPath.Click += new System.EventHandler(this.btnBrowseUEPath_Click);
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(10, 60);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(95, 13);
            this.lblProjectPath.TabIndex = 3;
            this.lblProjectPath.Text = "Unreal Project File:";
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(150, 60);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(250, 20);
            this.txtProjectPath.TabIndex = 4;
            // 
            // btnBrowseProjectPath
            // 
            this.btnBrowseProjectPath.Location = new System.Drawing.Point(410, 58);
            this.btnBrowseProjectPath.Name = "btnBrowseProjectPath";
            this.btnBrowseProjectPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseProjectPath.TabIndex = 5;
            this.btnBrowseProjectPath.Text = "Browse...";
            this.btnBrowseProjectPath.UseVisualStyleBackColor = true;
            this.btnBrowseProjectPath.Click += new System.EventHandler(this.btnBrowseProjectPath_Click);
            // 
            // lblAssetsPath
            // 
            this.lblAssetsPath.AutoSize = true;
            this.lblAssetsPath.Location = new System.Drawing.Point(10, 100);
            this.lblAssetsPath.Name = "lblAssetsPath";
            this.lblAssetsPath.Size = new System.Drawing.Size(132, 13);
            this.lblAssetsPath.TabIndex = 6;
            this.lblAssetsPath.Text = "Select Assets to Package:";
            // 
            // txtAssetsPath
            // 
            this.txtAssetsPath.Location = new System.Drawing.Point(150, 100);
            this.txtAssetsPath.Name = "txtAssetsPath";
            this.txtAssetsPath.Size = new System.Drawing.Size(250, 20);
            this.txtAssetsPath.TabIndex = 7;
            // 
            // btnBrowseAssetsPath
            // 
            this.btnBrowseAssetsPath.Location = new System.Drawing.Point(410, 98);
            this.btnBrowseAssetsPath.Name = "btnBrowseAssetsPath";
            this.btnBrowseAssetsPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseAssetsPath.TabIndex = 8;
            this.btnBrowseAssetsPath.Text = "Browse...";
            this.btnBrowseAssetsPath.UseVisualStyleBackColor = true;
            this.btnBrowseAssetsPath.Click += new System.EventHandler(this.btnBrowseAssetsPath_Click);
            // 
            // lblChunkNumber
            // 
            this.lblChunkNumber.AutoSize = true;
            this.lblChunkNumber.Location = new System.Drawing.Point(10, 140);
            this.lblChunkNumber.Name = "lblChunkNumber";
            this.lblChunkNumber.Size = new System.Drawing.Size(80, 13);
            this.lblChunkNumber.TabIndex = 9;
            this.lblChunkNumber.Text = "Chunk Number:";
            // 
            // txtChunkNumber
            // 
            this.txtChunkNumber.Location = new System.Drawing.Point(150, 140);
            this.txtChunkNumber.Name = "txtChunkNumber";
            this.txtChunkNumber.Size = new System.Drawing.Size(50, 20);
            this.txtChunkNumber.TabIndex = 10;
            this.txtChunkNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChunkNumber_KeyPress);
            // 
            // chkCleanCooked
            // 
            this.chkCleanCooked.AutoSize = true;
            this.chkCleanCooked.Location = new System.Drawing.Point(150, 170);
            this.chkCleanCooked.Name = "chkCleanCooked";
            this.chkCleanCooked.Size = new System.Drawing.Size(227, 17);
            this.chkCleanCooked.TabIndex = 11;
            this.chkCleanCooked.Text = "Clean Cooked Folder Before Packaging";
            this.chkCleanCooked.UseVisualStyleBackColor = true;
            // 
            // chkOpenOutput
            // 
            this.chkOpenOutput.AutoSize = true;
            this.chkOpenOutput.Location = new System.Drawing.Point(150, 200);
            this.chkOpenOutput.Name = "chkOpenOutput";
            this.chkOpenOutput.Size = new System.Drawing.Size(198, 17);
            this.chkOpenOutput.TabIndex = 12;
            this.chkOpenOutput.Text = "Open Output Folder After Packaging";
            this.chkOpenOutput.UseVisualStyleBackColor = true;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(150, 230);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(78, 17);
            this.chkDarkMode.TabIndex = 13;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(150, 270);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(100, 30);
            this.btnPackage.TabIndex = 14;
            this.btnPackage.Text = "Package Assets";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.lblUEPath);
            this.Controls.Add(this.txtUEPath);
            this.Controls.Add(this.btnBrowseUEPath);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.btnBrowseProjectPath);
            this.Controls.Add(this.lblAssetsPath);
            this.Controls.Add(this.txtAssetsPath);
            this.Controls.Add(this.btnBrowseAssetsPath);
            this.Controls.Add(this.lblChunkNumber);
            this.Controls.Add(this.txtChunkNumber);
            this.Controls.Add(this.chkCleanCooked);
            this.Controls.Add(this.chkOpenOutput);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.btnPackage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOStorePak";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUEPath;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnBrowseProjectPath;
        private System.Windows.Forms.Label lblAssetsPath;
        private System.Windows.Forms.TextBox txtAssetsPath;
        private System.Windows.Forms.Button btnBrowseAssetsPath;
        private System.Windows.Forms.Label lblChunkNumber;
        private System.Windows.Forms.TextBox txtChunkNumber;
        private System.Windows.Forms.CheckBox chkCleanCooked;
        private System.Windows.Forms.CheckBox chkOpenOutput;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Button btnPackage;
    }
}
