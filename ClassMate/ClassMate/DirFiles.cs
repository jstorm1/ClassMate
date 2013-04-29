using System;
using System.IO;
using System.Collections;

namespace Category5
{
    [Serializable]
    /// <summary>
    ///  A File listed in the directories scanned.
    /// </summary>
    class DirFile
    {
        #region DirFile Properties

        public string Name;
        public long Size;
        public string Ext;
        public DirectoryInfo Parent;
        public string FullName;
        public DateTime LastAccessed;
        public DateTime Created;
        public FileAttributes Attributes;

        #endregion
        
        public DirFile(FileInfo file, DirectoryInfo parent)
        {
            Name = file.Name;
            Size = file.Length;
            Ext = file.Extension;
            Parent = parent;
            FullName = file.FullName;
            LastAccessed = file.LastAccessTime;
            Created = file.CreationTime;
            Attributes = file.Attributes;
        }
    }

    /// <summary>
    /// Files listed in the directories scanned.
    /// </summary>
    [Serializable]
    class DirFiles : IEnumerable
    {
        
        public ArrayList m_FileList;

        public DirFiles()
        {
            m_FileList = new ArrayList();
        }

        public DirFile this[int index]
        {
            get
            {
                return (DirFile)m_FileList[index];
            }
            set
            {
                m_FileList[index] = value;
            }
        }

        public void Add(DirFile dirFile)
        {
            m_FileList.Add(dirFile);
        }

        public void Remove(DirFile dirFile)
        {
            m_FileList.Remove(dirFile);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new DirFileEnumerator(this);
        }

        #endregion
    }
    
    [Serializable]
    class DirFileEnumerator : IEnumerator
    {
        private DirFiles m_DirFilesRef;
        private int m_location;

        public DirFileEnumerator(DirFiles DirFilesRef)
        {
            this.m_DirFilesRef = DirFilesRef;
            m_location = -1;
        }

        #region IEnumerator Members

        public object Current
        {
            get 
            {
             if((m_location < 0) || (m_location > m_DirFilesRef.m_FileList.Count))
                {
                    return null;
                }   
                else
                {
                    return m_DirFilesRef.m_FileList[m_location]; 
                }
                
            }
        }

        public bool MoveNext()
        {
            m_location++;
            return (m_location <= (m_DirFilesRef.m_FileList.Count - 1));
        }

        public void Reset()
        {
            m_location = -1;
        }

        #endregion
    }
}
