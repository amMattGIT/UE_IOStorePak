namespace IOStorePak
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.TextBox txtAssetsPath;
        private System.Windows.Forms.TextBox txtChunkNumber;
        private System.Windows.Forms.CheckBox chkCleanCooked;
        private System.Windows.Forms.CheckBox chkOpenOutput;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkCleanOutput;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.Button btnBrowseProjectPath;
        private System.Windows.Forms.Button btnBrowseAssetsPath;
        private System.Windows.Forms.Label lblUEPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.Label lblAssetsPath;
        private System.Windows.Forms.Label lblChunkNumber;
        private System.Windows.Forms.GroupBox grpAdvancedSettings;
        private System.Windows.Forms.GroupBox grpRegularSettings;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.txtAssetsPath = new System.Windows.Forms.TextBox();
            this.txtChunkNumber = new System.Windows.Forms.TextBox();
            this.chkCleanCooked = new System.Windows.Forms.CheckBox();
            this.chkOpenOutput = new System.Windows.Forms.CheckBox();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkCleanOutput = new System.Windows.Forms.CheckBox();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.btnBrowseProjectPath = new System.Windows.Forms.Button();
            this.btnBrowseAssetsPath = new System.Windows.Forms.Button();
            this.lblUEPath = new System.Windows.Forms.Label();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.lblAssetsPath = new System.Windows.Forms.Label();
            this.lblChunkNumber = new System.Windows.Forms.Label();
            this.grpAdvancedSettings = new System.Windows.Forms.GroupBox();
            this.grpRegularSettings = new System.Windows.Forms.GroupBox();
            this.grpAdvancedSettings.SuspendLayout();
            this.grpRegularSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUEPath
            // 
            this.txtUEPath.Location = new System.Drawing.Point(12, 29);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(181, 20);
            this.txtUEPath.TabIndex = 0;
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(12, 71);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(181, 20);
            this.txtProjectPath.TabIndex = 1;
            // 
            // txtAssetsPath
            // 
            this.txtAssetsPath.Location = new System.Drawing.Point(12, 113);
            this.txtAssetsPath.Name = "txtAssetsPath";
            this.txtAssetsPath.Size = new System.Drawing.Size(181, 20);
            this.txtAssetsPath.TabIndex = 2;
            this.txtAssetsPath.TextChanged += new System.EventHandler(this.txtAssetsPath_TextChanged);
            // 
            // txtChunkNumber
            // 
            this.txtChunkNumber.Location = new System.Drawing.Point(93, 19);
            this.txtChunkNumber.Name = "txtChunkNumber";
            this.txtChunkNumber.Size = new System.Drawing.Size(138, 20);
            this.txtChunkNumber.TabIndex = 3;
            this.txtChunkNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChunkNumber_KeyPress);
            // 
            // chkCleanCooked
            // 
            this.chkCleanCooked.AutoSize = true;
            this.chkCleanCooked.Location = new System.Drawing.Point(7, 45);
            this.chkCleanCooked.Name = "chkCleanCooked";
            this.chkCleanCooked.Size = new System.Drawing.Size(213, 17);
            this.chkCleanCooked.TabIndex = 0;
            this.chkCleanCooked.Text = "Clean Cooked Folder Before Packaging";
            this.chkCleanCooked.UseVisualStyleBackColor = true;
            // 
            // chkOpenOutput
            // 
            this.chkOpenOutput.AutoSize = true;
            this.chkOpenOutput.Location = new System.Drawing.Point(7, 68);
            this.chkOpenOutput.Name = "chkOpenOutput";
            this.chkOpenOutput.Size = new System.Drawing.Size(198, 17);
            this.chkOpenOutput.TabIndex = 1;
            this.chkOpenOutput.Text = "Open Output Folder After Packaging";
            this.chkOpenOutput.UseVisualStyleBackColor = true;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(7, 91);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(79, 17);
            this.chkDarkMode.TabIndex = 2;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(7, 20);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(88, 17);
            this.chkDebug.TabIndex = 0;
            this.chkDebug.Text = "Debug Mode";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkCleanOutput
            // 
            this.chkCleanOutput.AutoSize = true;
            this.chkCleanOutput.Location = new System.Drawing.Point(7, 43);
            this.chkCleanOutput.Name = "chkCleanOutput";
            this.chkCleanOutput.Size = new System.Drawing.Size(208, 17);
            this.chkCleanOutput.TabIndex = 1;
            this.chkCleanOutput.Text = "Clean Output Folder Before Packaging";
            this.chkCleanOutput.UseVisualStyleBackColor = true;
            // 
            // btnPackage
            // 
            this.btnPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackage.Location = new System.Drawing.Point(12, 341);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(237, 23);
            this.btnPackage.TabIndex = 8;
            this.btnPackage.Text = "Package Assets";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Location = new System.Drawing.Point(199, 29);
            this.btnBrowseUEPath.Name = "btnBrowseUEPath";
            this.btnBrowseUEPath.Size = new System.Drawing.Size(51, 20);
            this.btnBrowseUEPath.TabIndex = 10;
            this.btnBrowseUEPath.Text = "Browse";
            this.btnBrowseUEPath.UseVisualStyleBackColor = true;
            this.btnBrowseUEPath.Click += new System.EventHandler(this.btnBrowseUEPath_Click);
            // 
            // btnBrowseProjectPath
            // 
            this.btnBrowseProjectPath.Location = new System.Drawing.Point(199, 71);
            this.btnBrowseProjectPath.Name = "btnBrowseProjectPath";
            this.btnBrowseProjectPath.Size = new System.Drawing.Size(51, 20);
            this.btnBrowseProjectPath.TabIndex = 11;
            this.btnBrowseProjectPath.Text = "Browse";
            this.btnBrowseProjectPath.UseVisualStyleBackColor = true;
            this.btnBrowseProjectPath.Click += new System.EventHandler(this.btnBrowseProjectPath_Click);
            // 
            // btnBrowseAssetsPath
            // 
            this.btnBrowseAssetsPath.Location = new System.Drawing.Point(199, 113);
            this.btnBrowseAssetsPath.Name = "btnBrowseAssetsPath";
            this.btnBrowseAssetsPath.Size = new System.Drawing.Size(51, 20);
            this.btnBrowseAssetsPath.TabIndex = 12;
            this.btnBrowseAssetsPath.Text = "Browse";
            this.btnBrowseAssetsPath.UseVisualStyleBackColor = true;
            this.btnBrowseAssetsPath.Click += new System.EventHandler(this.btnBrowseAssetsPath_Click);
            // 
            // lblUEPath
            // 
            this.lblUEPath.AutoSize = true;
            this.lblUEPath.Location = new System.Drawing.Point(9, 13);
            this.lblUEPath.Name = "lblUEPath";
            this.lblUEPath.Size = new System.Drawing.Size(122, 13);
            this.lblUEPath.TabIndex = 13;
            this.lblUEPath.Text = "Unreal Engine Directory:";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(9, 55);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(96, 13);
            this.lblProjectPath.TabIndex = 14;
            this.lblProjectPath.Text = "Unreal Project File:";
            // 
            // lblAssetsPath
            // 
            this.lblAssetsPath.AutoSize = true;
            this.lblAssetsPath.Location = new System.Drawing.Point(9, 97);
            this.lblAssetsPath.Name = "lblAssetsPath";
            this.lblAssetsPath.Size = new System.Drawing.Size(132, 13);
            this.lblAssetsPath.TabIndex = 15;
            this.lblAssetsPath.Text = "Select Assets to Package:";
            // 
            // lblChunkNumber
            // 
            this.lblChunkNumber.AutoSize = true;
            this.lblChunkNumber.Location = new System.Drawing.Point(6, 22);
            this.lblChunkNumber.Name = "lblChunkNumber";
            this.lblChunkNumber.Size = new System.Drawing.Size(81, 13);
            this.lblChunkNumber.TabIndex = 16;
            this.lblChunkNumber.Text = "Chunk Number:";
            // 
            // grpAdvancedSettings
            // 
            this.grpAdvancedSettings.Controls.Add(this.chkDebug);
            this.grpAdvancedSettings.Controls.Add(this.chkCleanOutput);
            this.grpAdvancedSettings.Location = new System.Drawing.Point(12, 267);
            this.grpAdvancedSettings.Name = "grpAdvancedSettings";
            this.grpAdvancedSettings.Size = new System.Drawing.Size(237, 68);
            this.grpAdvancedSettings.TabIndex = 7;
            this.grpAdvancedSettings.TabStop = false;
            this.grpAdvancedSettings.Text = "Advanced";
            // 
            // grpRegularSettings
            // 
            this.grpRegularSettings.Controls.Add(this.lblChunkNumber);
            this.grpRegularSettings.Controls.Add(this.txtChunkNumber);
            this.grpRegularSettings.Controls.Add(this.chkCleanCooked);
            this.grpRegularSettings.Controls.Add(this.chkOpenOutput);
            this.grpRegularSettings.Controls.Add(this.chkDarkMode);
            this.grpRegularSettings.Location = new System.Drawing.Point(12, 140);
            this.grpRegularSettings.Name = "grpRegularSettings";
            this.grpRegularSettings.Size = new System.Drawing.Size(237, 121);
            this.grpRegularSettings.TabIndex = 18;
            this.grpRegularSettings.TabStop = false;
            this.grpRegularSettings.Text = "Settings";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(261, 376);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.grpRegularSettings);
            this.Controls.Add(this.grpAdvancedSettings);
            this.Controls.Add(this.txtAssetsPath);
            this.Controls.Add(this.lblAssetsPath);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtUEPath);
            this.Controls.Add(this.lblUEPath);
            this.Controls.Add(this.btnBrowseAssetsPath);
            this.Controls.Add(this.btnBrowseProjectPath);
            this.Controls.Add(this.btnBrowseUEPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOStorePak";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpAdvancedSettings.ResumeLayout(false);
            this.grpAdvancedSettings.PerformLayout();
            this.grpRegularSettings.ResumeLayout(false);
            this.grpRegularSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
