using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMate
{
    [Serializable]
    /// <summary>
    ///  A Single assignment type
    /// </summary>
    class ClassAssignmentType
    {
        #region ClassType properties
        public string assignmentTypeName;
        public string assignmentTypeClass;
        #endregion

        public ClassAssignmentType(string typeName, string typeClass)
        {
            assignmentTypeName = typeName;
            assignmentTypeClass = typeClass;
        }
    }

    /// <summary>
    /// Collection of types for a given class.
    /// </summary>
    [Serializable]
    class ClassAssignmentTypes : IEnumerable
    {

        public ArrayList m_typeList;

        public ClassAssignmentTypes()
        {
            m_typeList = new ArrayList();
        }

        public ClassAssignmentType this[int index]
        {
            get
            {
                return (ClassAssignmentType)m_typeList[index];
            }
            set
            {
                m_typeList[index] = value;
            }
        }

        public void Add(ClassAssignmentType assType)
        {
            m_typeList.Add(assType);
        }

        public void Remove(ClassAssignmentType assType)
        {
            m_typeList.Remove(assType);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new ClassAssignmentTypeEnumerator(this);
        }

        #endregion
    }

    [Serializable]
    class ClassAssignmentTypeEnumerator : IEnumerator
    {
        private ClassAssignmentTypes m_assTypesRef;
        private int m_location;

        public ClassAssignmentTypeEnumerator(ClassAssignmentTypes assTypeRef)
        {
            this.m_assTypesRef = assTypeRef;
            m_location = -1;
        }

        #region IEnumerator Members

        public object Current
        {
            get
            {
                if ((m_location < 0) || (m_location > m_assTypesRef.m_typeList.Count))
                {
                    return null;
                }
                else
                {
                    return m_assTypesRef.m_typeList[m_location];
                }

            }
        }

        public bool MoveNext()
        {
            m_location++;
            return (m_location <= (m_assTypesRef.m_typeList.Count - 1));
        }

        public void Reset()
        {
            m_location = -1;
        }

        #endregion
    }
}
