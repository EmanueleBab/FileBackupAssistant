using System;
using System.IO;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace FileBackup
{
    public partial class Form1 : Form
    {
        public static string fileToSave;
        public static string destination;
        public static bool canSave, running = false;
        Thread thread1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
            RunThread();
        }

        private void RunThread()
        {
            if(canSave && !running)
            {
                 thread1 = new Thread(Run);
                thread1.Start();
            }
        }

        private void applicamodificheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((destination != null && fileToSave != null))
            {
                StreamWriter sw = File.CreateText(@".\data.txt");

                canSave = true;
                sw.WriteLine(fileToSave);
                sw.WriteLine(destination);
                sw.Close();
                RunThread();

            }
            else
            {
                MessageBox.Show("error a directory hasn't been selected", "error", MessageBoxButtons.OK);
            }
        }

        private void rICORDAGIGGIODIAGESTIREGLIERRORINELLEAPPACASOQUINDINONFARESTRONZATEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private static void Initialize()
        {
            if (!File.Exists(@".\data.txt"))
            {
                using (StreamWriter sw = File.AppendText(@".\data.txt"))
                {
                    canSave = false;
                    sw.Close();
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(@".\data.txt"))
                {
                    fileToSave = sr.ReadLine();
                    if (fileToSave == null)
                    {
                        canSave = false;
                        return;
                    }
                    destination = sr.ReadLine();
                    canSave = true;
                }
            }
            catch
            {
                canSave = false;
            }

        }

        private static void Run()
        {
            if (!running)
            {
                running = true;
                // Create a new FileSystemWatcher and set its properties.
                using (FileSystemWatcher watcher = new FileSystemWatcher())
                {
                    watcher.Path = fileToSave;

                    // Watch for changes in LastAccess and LastWrite times, and
                    // the renaming of files or directories.
                    watcher.NotifyFilter = NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName
                                         | NotifyFilters.DirectoryName;

                    // Only watch text files.

                    // Add event handlers.
                    watcher.Changed += OnChanged;
                    watcher.Created += OnChanged;


                    // Begin watching.
                    watcher.EnableRaisingEvents = true;

                    // Wait for the user to quit the program.
                    while (true) ;
                }
            }

        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (canSave)
            {

                // Specify what is done when a file is changed, created, or deleted.


                string[] files = System.IO.Directory.GetFiles(fileToSave);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(destination, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
        }

        private void DirToSave(object sender, EventArgs e)
        {

            fileToSave = GetFile();
            canSave = false;
        }

       

        private void TargetDir(object sender, EventArgs e)
        {
            destination = GetFile();

            canSave = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            Application.Exit();
        }

        private void Menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public string GetFile()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                return browser.SelectedPath;
            }
            return null;
        }
    }
}
