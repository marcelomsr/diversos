using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InboundConsole
{
    public partial class Form1 : Form
    {
        List<string> _files = new List<string>();
        List<string> _exclude_extensions = new List<string>();
        List<string> _exclude_folders = new List<string>();
        List<string> _include_folders = new List<string>();

        public Form1()
        {
            InitializeComponent();

            _exclude_extensions.AddRange(
                new string[] {
                    ".exe", ".ico", ".xsd", ".suo", ".bak", ".pak", ".gitignore", ".gitmodules", ".git", ".gpState", ".dll", ".rpt", ".txt", ".conf",
                    ".log", ".obj", ".pdb", ".idb", ".tlog", ".lastbuildstate", ".wav", ".example", ".user", ".userosscache", ".docstates", ".userprefs",
                    ".json", ".ilk", ".meta", ".pch", ".pgc", ".pgd", ".rsp", ".sbr", ".tlb", ".tli", ".tlh", ".tmp", ".tmp_proj", ".vspscc", ".vssscc",
                    ".builds", ".pidb", ".svclog", ".scc", ".ddp", ".~dfm", ".~ddp", ".~pas", ".dcu", ".~dpr", ".bpl", ".bat", ".~bpl", ".db", ".bmp", ".png",
                    ".lck", ".cfg", ".dof", ".dpr", ".res", ".rpt", "README", "Rakefile", ".gif", ".jpg", ".ocx", ".pdf"
                });
            
            _exclude_folders.AddRange(
                new string[] {
                    "bin", "obj", ".nuget", ".vs", "Properties", "Resources", "packages", ".git", "Lib", "Deploy", "Service References", "GravaçõesEx",
                    "SistemasIntegrados", "DOC", "Doc", "Build", "Davibot", "ext", "Icons", "Debug", "Release",
                    "aparnet.net",
                    "crm.net",
                    "global.net",
                    "Instalação Sistema"
                });

            DirSearch(@"C:\Users\estevaos\Downloads\Repositório\tarifador");
            var lines = 0;

            foreach (var fileName in _files)
            {
                using (var reader = new StreamReader(fileName))
                {
                    // read file line by line 
                    string lineRead;
                    while ((lineRead = reader.ReadLine()) != null)
                    {
                        lines++;
                    }
                }
            }

            Clipboard.SetText(lines.ToString());
        }
        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    if (_exclude_folders.Contains(Path.GetFileName(d)))
                        continue;

                    _include_folders.Add(d);

                    foreach (string f in Directory.GetFiles(d))
                    {
                        if (_exclude_extensions.Contains(Path.GetExtension(f)))
                            continue;

                        _files.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
