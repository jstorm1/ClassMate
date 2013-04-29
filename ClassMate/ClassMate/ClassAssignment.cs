using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMate
{
    [Serializable]
    /// <summary>
    ///  A singular assignment.
    /// </summary>
    public class ClassAssignment
    {
        #region ClassAssignment properties
        public string assignmentTitle;
        public string assignmentType;
        public string assignmentDescription;
        public string assignmentNote;
        public string assignmentClass;
        public DateTime assignmentDue;
        public bool assignmentComplete;
        #endregion

        public ClassAssignment(string title, string type, string description, string note, string assClass, DateTime due, bool complete)
        {
            assignmentTitle = title;
            assignmentType = type;
            assignmentDescription = description;
            assignmentNote = note;
            assignmentClass = assClass;
            assignmentDue = due;
            assignmentComplete = complete;
        }
    }

     /// <summary>
    /// Collection of assignments for a given class. 
    /// </summary>
    [Serializable]
    public class ClassAssignments  : IEnumerable
    {
        public ArrayList m_assList;
        public ClassAssignments()
        {
            m_assList = new ArrayList();
        }

        public ClassAssignment this[int index]
        {
            get
            {
                return (ClassAssignment)m_assList[index];
            }
            set
            {
                m_assList[index] = value;
            }
        }

        public void Add(ClassAssignment classAss)
        {
            m_assList.Add(classAss);
        }

        public void Remove(ClassAssignment classAss)
        {
            m_assList.Remove(classAss);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new ClassAssEnumerator(this);
        }

        #endregion
    }

    [Serializable]
    class ClassAssEnumerator : IEnumerator
    {
        private ClassAssignments m_ClassAsssRef;
        private int m_location;

        public ClassAssEnumerator(ClassAssignments ClassAsssRef)
        {
            this.m_ClassAsssRef = ClassAsssRef;
            m_location = -1;
        }

        #region IEnumerator Members

        public object Current
        {
            get 
            {
             if((m_location < 0) || (m_location > m_ClassAsssRef.m_assList.Count))
                {
                    return null;
                }   
                else
                {
                    return m_ClassAsssRef.m_assList[m_location]; 
                }
                
            }
        }

        public bool MoveNext()
        {
            m_location++;
            return (m_location <= (m_ClassAsssRef.m_assList.Count - 1));
        }

        public void Reset()
        {
            m_location = -1;
        }

        #endregion
    }

}
