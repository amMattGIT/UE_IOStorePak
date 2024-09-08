using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
using System.Collections.Generic;

namespace IOStorePak
{
    public partial class MainForm : Form
    {
        private string configFilePath = "config.json";
        private string logFilePath = "IOStorePak.log";

        public MainForm()
        {
            InitializeComponent();
            LoadConfig();
            ApplyTheme();

            // Attach the FormClosing event to ensure configuration is saved
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void ApplyTheme()
        {
            if (chkDarkMode.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.WhiteSmoke;
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox || control is Button)
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }
                    else
                    {
                        control.BackColor = Color.Black;
                        control.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox || control is Button)
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }
                    else
                    {
                        control.BackColor = Color.WhiteSmoke;
                        control.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the configuration when the form is closing
            SaveConfig();
        }

        private void Log(string message)
        {
            if (chkDebug.Checked)
            {
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}\n");
            }
        }

        private string BrowseForFolderModern()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Folder";
                openFileDialog.Filter = "Folders|\n";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return Path.GetDirectoryName(openFileDialog.FileName);
                }
            }
            return string.Empty;
        }

        private List<string> BrowseForMultipleFiles(string filter)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = filter;
                dialog.Multiselect = true; // Allow multi-selection
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return new List<string>(dialog.FileNames);
                }
            }
            return new List<string>();
        }

        private string BrowseForFile(string filter)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = filter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }
            }
            return string.Empty;
        }

        private void ChooseSelectionType()
        {
            using (Form choiceForm = new Form())
            {
                choiceForm.Text = "Choose Selection Type";
                choiceForm.Size = new Size(240, 140);
                choiceForm.StartPosition = FormStartPosition.CenterParent;
                choiceForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                choiceForm.MaximizeBox = false;
                choiceForm.MinimizeBox = false;

                Button btnSelectFiles = new Button() { Text = "Select Files", Location = new Point(20, 50), Size = new Size(80, 30) };
                btnSelectFiles.Click += (s, e) =>
                {
                    var selectedFiles = BrowseForMultipleFiles("Unreal Asset Files (*.uasset;*.uexp;*.ubulk)|*.uasset;*.uexp;*.ubulk");
                    txtAssetsPath.Text = string.Join(";", selectedFiles);
                    choiceForm.Close();
                };

                Button btnSelectFolder = new Button() { Text = "Select Folder", Location = new Point(120, 50), Size = new Size(80, 30) };
                btnSelectFolder.Click += (s, e) =>
                {
                    txtAssetsPath.Text = BrowseForFolderModern();
                    choiceForm.Close();
                };

                choiceForm.Controls.Add(btnSelectFiles);
                choiceForm.Controls.Add(btnSelectFolder);

                // Apply the theme to the choiceForm based on the dark mode state
                if (chkDarkMode.Checked)
                {
                    ApplyThemeToForm(choiceForm);
                }
                else
                {
                    ApplyLightThemeToForm(choiceForm);
                }

                choiceForm.ShowDialog();
            }
        }

        private void ApplyThemeToForm(Form targetForm)
        {
            targetForm.BackColor = Color.Black;
            targetForm.ForeColor = Color.WhiteSmoke;
            foreach (Control control in targetForm.Controls)
            {
                if (control is TextBox || control is Button)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
                else
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.WhiteSmoke;
                }
            }
        }

        private void ApplyLightThemeToForm(Form targetForm)
        {
            targetForm.BackColor = Color.WhiteSmoke;
            targetForm.ForeColor = Color.Black;
            foreach (Control control in targetForm.Controls)
            {
                if (control is TextBox || control is Button)
                {
                    control.BackColor = Color.WhiteSmoke;
                    control.ForeColor = Color.Black;
                }
                else
                {
                    control.BackColor = Color.WhiteSmoke;
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void LoadConfig()
        {
            if (File.Exists(configFilePath))
            {
                Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configFilePath));
                txtUEPath.Text = config.UnrealEnginePath;
                txtProjectPath.Text = config.UnrealProjectPath;
                chkCleanCooked.Checked = config.CleanCookedFolder;
                chkOpenOutput.Checked = config.OpenOutputFolder;
                chkDarkMode.Checked = config.DarkMode;
                chkDebug.Checked = config.DebugMode;
                chkCleanOutput.Checked = config.CleanOutputFolder;
                chkCompression.Checked = config.EnableCompression;
            }
        }

        private void SaveConfig()
        {
            Config config = new Config
            {
                UnrealEnginePath = txtUEPath.Text,
                UnrealProjectPath = txtProjectPath.Text,
                CleanCookedFolder = chkCleanCooked.Checked,
                OpenOutputFolder = chkOpenOutput.Checked,
                DarkMode = chkDarkMode.Checked,
                DebugMode = chkDebug.Checked,
                CleanOutputFolder = chkCleanOutput.Checked,
                EnableCompression = chkCompression.Checked
            };
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config));
        }

        private void PackageAssets()
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txtUEPath.Text) || string.IsNullOrEmpty(txtProjectPath.Text) || string.IsNullOrEmpty(txtAssetsPath.Text))
            {
                MessageBox.Show("Please provide all required paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string projectDir = Path.GetDirectoryName(txtProjectPath.Text);
            string projectDirName = Path.GetFileNameWithoutExtension(txtProjectPath.Text);
            string cookedBasePath = Path.Combine(projectDir, "Saved", "Cooked", "WindowsNoEditor", projectDirName, "Content");
            string tmpPackagingPath = Path.Combine(projectDir, "Saved", "TmpPackaging");
            string tmpPackagingWindowsPath = Path.Combine(tmpPackagingPath, "WindowsNoEditor");
            string pakchunkPath = Path.Combine(tmpPackagingWindowsPath, $"pakchunk{txtChunkNumber.Text}.txt");
            string pakchunkListPath = Path.Combine(tmpPackagingWindowsPath, "pakchunklist.txt");
            string pakchunk0Path = Path.Combine(tmpPackagingWindowsPath, "pakchunk0.txt");
            string pakchunkLayersPath = Path.Combine(tmpPackagingWindowsPath, "pakchunklayers.txt");

            Log("Starting packaging process...");
            Log($"Unreal Engine Path: {txtUEPath.Text}");
            Log($"Project Path: {txtProjectPath.Text}");
            Log($"Cooked Base Path: {cookedBasePath}");

            // Ensure the TmpPackaging and TmpPackaging\WindowsNoEditor directories exist
            if (!Directory.Exists(tmpPackagingPath))
            {
                Directory.CreateDirectory(tmpPackagingPath);
            }
            if (!Directory.Exists(tmpPackagingWindowsPath))
            {
                Directory.CreateDirectory(tmpPackagingWindowsPath);
            }

            // Create an empty pakchunk0.txt file if it doesn't exist
            if (!File.Exists(pakchunk0Path))
            {
                File.WriteAllText(pakchunk0Path, string.Empty);  // Create an empty file
            }

            // Clean the Cooked folder if the checkbox is checked
            if (chkCleanCooked.Checked && Directory.Exists(cookedBasePath))
            {
                Directory.Delete(cookedBasePath, true);
                Directory.CreateDirectory(cookedBasePath);
                Log("Cleaned Cooked folder.");
            }

            // Ensure the destination directories exist
            if (!Directory.Exists(cookedBasePath))
            {
                Directory.CreateDirectory(cookedBasePath);
            }

            // Clean the Output folder if the checkbox is checked
            if (chkCleanOutput.Checked)
            {
                string outputFolderPath = Path.Combine(projectDir, "Saved", "StagedBuilds", "WindowsNoEditor", projectDirName, "Content", "Paks");
                if (Directory.Exists(outputFolderPath))
                {
                    Directory.Delete(outputFolderPath, true);
                    Directory.CreateDirectory(outputFolderPath);
                    Log("Cleaned Output folder.");
                }
            }

            // Initialize a list for the pakchunk file entries
            var pakchunkEntries = new List<string>();

            // Determine if user selected files or a folder
            var assetsPath = new List<string>();

            if (Directory.Exists(txtAssetsPath.Text))
            {
                // User selected a folder, gather all .uasset and .uexp files
                assetsPath.AddRange(Directory.GetFiles(txtAssetsPath.Text, "*.uasset", SearchOption.AllDirectories));
                assetsPath.AddRange(Directory.GetFiles(txtAssetsPath.Text, "*.uexp", SearchOption.AllDirectories));
                assetsPath.AddRange(Directory.GetFiles(txtAssetsPath.Text, "*.ubulk", SearchOption.AllDirectories));

            }
            else if (!string.IsNullOrEmpty(txtAssetsPath.Text))
            {
                // User selected individual files, split by ';' if multiple
                assetsPath.AddRange(txtAssetsPath.Text.Split(';'));
            }

            // Process each selected asset
            foreach (var asset in assetsPath)
            {
                // Ensure "Content" only appears once in the path
                int contentIndex = asset.IndexOf("Content", StringComparison.OrdinalIgnoreCase);
                string relativePath = asset.Substring(contentIndex + "Content".Length).TrimStart('\\', '/');

                string destinationPath = Path.Combine(cookedBasePath, relativePath);

                // Ensure the destination directory exists
                string destinationDir = Path.GetDirectoryName(destinationPath);
                if (!Directory.Exists(destinationDir))
                {
                    Directory.CreateDirectory(destinationDir);
                }

                // Copy the asset to the Cooked folder
                File.Copy(asset, destinationPath, true);

                // Add the full path (without extension) to the pakchunk list
                string pakchunkEntry = destinationPath.Replace(Path.GetExtension(asset), "");
                if (!pakchunkEntries.Contains(pakchunkEntry))
                {
                    pakchunkEntries.Add(pakchunkEntry);
                }
            }

            // Write the pakchunk entries to the .txt file
            File.WriteAllLines(pakchunkPath, pakchunkEntries);
            Log($"Created pakchunk{txtChunkNumber.Text}.txt with {pakchunkEntries.Count} entries.");

            // Create the pakchunklist.txt file with required entries
            var pakchunkListEntries = new List<string>
            {
                "pakchunk0.txt",
                $"pakchunk{txtChunkNumber.Text}.txt"
            };
            File.WriteAllLines(pakchunkListPath, pakchunkListEntries);
            Log("Created pakchunklist.txt.");

            // Create the pakchunklayers.txt file with a "0" for each pakchunk
            var pakchunkLayersEntries = pakchunkListEntries.Select(_ => "0").ToList();
            File.WriteAllLines(pakchunkLayersPath, pakchunkLayersEntries);
            Log("Created pakchunklayers.txt.");

            // Modify DefaultGame.ini to enable chunking
            string defaultGameIniPath = Path.Combine(projectDir, "Config", "DefaultGame.ini");
            EnsureDefaultGameIniConfig(defaultGameIniPath);
            Log("Modified DefaultGame.ini for chunking.");

            // Run the UAT command with visible window
            string runUAT = Path.Combine(txtUEPath.Text, "Engine", "Build", "BatchFiles", "RunUAT.bat");
            string arguments = $"BuildCookRun -project=\"{txtProjectPath.Text}\" -skipcook -pak -iostore -skipstage";

            if (chkCompression.Checked)
            {
                arguments += " -compressed";  // Add the compression argument
                Log("Compression enabled (-compressed).");
            }

            if (chkDebug.Checked)
            {
                arguments += " & pause";  // Keep UAT window open
                Log("Running UAT in debug mode with pause.");
            }

            var processInfo = new ProcessStartInfo(runUAT, arguments)
            {
                CreateNoWindow = !chkDebug.Checked,  // Show window if debugging
                UseShellExecute = true,  // Set to true to make the window visible
            };
            var process = Process.Start(processInfo);
            process.WaitForExit();
            Log("UAT process finished.");

            // Open the folder with the packaged assets if checkbox is checked
            if (chkOpenOutput.Checked)
            {
                string outputPath = Path.Combine(projectDir, "Saved", "StagedBuilds", "WindowsNoEditor", projectDirName, "Content", "Paks");
                Process.Start("explorer.exe", outputPath);
                Log("Opened Output folder.");
            }

            // Show a "Done" message box
            MessageBox.Show("Packaging Completed!", "IOStorePak", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save the configuration on close
            SaveConfig();
            Log("Configuration saved.");
        }

        private void EnsureDefaultGameIniConfig(string iniFilePath)
        {
            // Check if DefaultGame.ini exists
            if (!File.Exists(iniFilePath))
            {
                MessageBox.Show("DefaultGame.ini not found in the Config folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(iniFilePath).ToList();
            var configEntries = new List<string>
            {
                "[/Script/UnrealEd.ProjectPackagingSettings]",
                "Build=IfProjectHasCode",
                "BuildConfiguration=PPBC_Shipping",
                "BuildTarget=",
                "FullRebuild=False",
                "ForDistribution=False",
                "IncludeDebugFiles=False",
                "BlueprintNativizationMethod=Disabled",
                "bIncludeNativizedAssetsInProjectGeneration=False",
                "bExcludeMonolithicEngineHeadersInNativizedCode=False",
                "UsePakFile=True",
                "bUseIoStore=True",
                "bGenerateChunks=True",
                "bGenerateNoChunks=False",
                "bChunkHardReferencesOnly=False",
                "bForceOneChunkPerFile=False",
                "MaxChunkSize=0",
                "bBuildHttpChunkInstallData=False",
                "HttpChunkInstallDataDirectory=(Path=\"\")",
                "PakFileCompressionFormats=",
                "PakFileAdditionalCompressionOptions=",
                "HttpChunkInstallDataVersion=",
                "IncludePrerequisites=True",
                "IncludeAppLocalPrerequisites=False",
                "bShareMaterialShaderCode=True",
                "bSharedMaterialNativeLibraries=True",
                "ApplocalPrerequisitesDirectory=(Path=\"\")",
                "IncludeCrashReporter=False",
                "InternationalizationPreset=English",
                "-CulturesToStage=en",
                "+CulturesToStage=en",
                "LocalizationTargetCatchAllChunkId=0",
                "bCookAll=False",
                "bCookMapsOnly=False",
                "bCompressed=False",
                "bSkipEditorContent=False",
                "bSkipMovies=True",
                "",
                "[/Script/Engine.AssetManagerSettings]",
                "bOnlyCookProductionAssets=False",
                "bShouldManagerDetermineTypeAndName=False",
                "bShouldGuessTypeAndNameInEditor=True",
                "bShouldAcquireMissingChunksOnLoad=False",
                "MetaDataTagsForAssetRegistry=()"
            };

            // Check if each config entry is already present, if not, add it
            foreach (var entry in configEntries)
            {
                if (!lines.Any(line => line.Trim().Equals(entry, StringComparison.OrdinalIgnoreCase)))
                {
                    lines.Add(entry);
                }
            }

            // Write back the modified content to DefaultGame.ini
            File.WriteAllLines(iniFilePath, lines);
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            PackageAssets();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void txtChunkNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBrowseUEPath_Click(object sender, EventArgs e)
        {
            txtUEPath.Text = BrowseForFolderModern();
        }

        private void btnBrowseProjectPath_Click(object sender, EventArgs e)
        {
            txtProjectPath.Text = BrowseForFile("Unreal Project Files (*.uproject)|*.uproject");
        }

        private void btnBrowseAssetsPath_Click(object sender, EventArgs e)
        {
            ChooseSelectionType();
        }

        private void txtAssetsPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void chkCleanOutput_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
