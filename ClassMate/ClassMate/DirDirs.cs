using System;
using System.IO;
using System.Collections;

namespace Category5
{
[Serializable]
    /// <summary>
    ///  A Directory listed in the directories scanned.
    /// </summary>
    class DirDir
    {
        #region DirDir Properties

        public string Name;
        public string FullPath;
        public DirectoryInfo Parent;
        public DateTime Created;
        public FileAttributes Attributes;

        #endregion
        
        public DirDir(DirectoryInfo dir)
        {
            Name = dir.Name;
            FullPath = dir.FullName;
            Parent = dir.Parent;
            Created = dir.CreationTime;
            Attributes = dir.Attributes;
        }
    }

    /// <summary>
    /// Directories listed in the directories scanned.
    /// </summary>
    [Serializable]
    class DirDirs : IEnumerable
    {
        
        public ArrayList m_DirList;

        public DirDirs()
        {
            m_DirList = new ArrayList();
        }

        public DirDir this[int index]
        {
            get
            {
                return (DirDir)m_DirList[index];
            }
            set
            {
                m_DirList[index] = value;
            }
        }

        public void Add(DirDir dirDir)
        {
            m_DirList.Add(dirDir);
        }

        public void Remove(DirDir dirDir)
        {
            m_DirList.Remove(dirDir);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new DirDirEnumerator(this);
        }

        #endregion
    }

    [Serializable]
    class DirDirEnumerator : IEnumerator
    {
        private DirDirs m_DirDirsRef;
        private int m_location;

        public DirDirEnumerator(DirDirs DirDirsRef)
        {
            this.m_DirDirsRef = DirDirsRef;
            m_location = -1;
        }

        #region IEnumerator Members

        public object Current
        {
            get 
            {
             if((m_location < 0) || (m_location > m_DirDirsRef.m_DirList.Count))
                {
                    return null;
                }   
                else
                {
                    return m_DirDirsRef.m_DirList[m_location]; 
                }
                
            }
        }

        public bool MoveNext()
        {
            m_location++;
            return (m_location <= (m_DirDirsRef.m_DirList.Count - 1));
        }

        public void Reset()
        {
            m_location = -1;
        }

        #endregion
    }
}
