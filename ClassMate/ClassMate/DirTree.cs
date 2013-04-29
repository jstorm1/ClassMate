using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;

namespace Category5
{
    [Serializable]
    /// <summary>
    ///  A tree of directories and files listed in the directories scanned.
    /// </summary>
    class DirTree
    {
        public string Name;
        public string FullPath;
        public DirectoryInfo Parent;
        public DateTime Created;
        public FileAttributes Attributes;
        public DirDirs SubDir;
        public DirFiles SubFiles;
        public DateTime DateAdded;

        public DirTree()
        {

        }
        public DirTree(string rootDir)
        {
            DirectoryInfo di = new DirectoryInfo(rootDir);
            DirectoryInfo[] subDirs = di.GetDirectories();
            FileInfo[] files = di.GetFiles("*.*");

            Name = di.Name;
            FullPath = di.FullName;
            Parent = di.Parent;
            Created = di.CreationTime;
            Attributes = di.Attributes;
            AddSubDirectories(subDirs);
            AddFiles(files);
            DateAdded = DateTime.Now;

        }

       private void AddSubDirectories(DirectoryInfo[] subDirs)
        {
            SubDir = new DirDirs();

           foreach(DirectoryInfo dir in subDirs)
           {
               DirDir dirDir = new DirDir(dir);
               SubDir.Add(dirDir);
           }  
        }

        private void AddFiles(FileInfo[] files)
       {
           SubFiles = new DirFiles();
           foreach(FileInfo file in files)
           {
               DirFile dirFile = new DirFile(file, Parent);
               SubFiles.Add(dirFile);
           }
       }

    }
}
