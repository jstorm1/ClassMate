using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMate
{
    [Serializable]
    /// <summary>
    ///  A single class time.
    /// </summary>
    public class ClassTime
    {
        #region ClassTime Properties
        public string classTimeClass;
        public string classTimeTime;
        #endregion
        
        public ClassTime(string className, string classTime)
        {
            classTimeClass = className;
            classTimeTime = classTime;
        }
    }


    /// <summary>
    /// Collection of times for a given class.
    /// </summary>
    [Serializable]
    public class ClassTimes : IEnumerable
    {

        public ArrayList m_TimeList;

        public ClassTimes()
        {
            m_TimeList = new ArrayList();
        }

        public ClassTime this[int index]
        {
            get
            {
                return (ClassTime)m_TimeList[index];
            }
            set
            {
                m_TimeList[index] = value;
            }
        }

        public void Add(ClassTime classTime)
        {
            m_TimeList.Add(classTime);
        }

        public void Remove(ClassTime classTime)
        {
            m_TimeList.Remove(classTime);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new ClassTimeEnumerator(this);
        }

        #endregion
    }

    [Serializable]
    class ClassTimeEnumerator : IEnumerator
    {
        private ClassTimes m_TimesRef;
        private int m_location;

        public ClassTimeEnumerator(ClassTimes ClassTimeRef)
        {
            this.m_TimesRef = ClassTimeRef;
            m_location = -1;
        }

        #region IEnumerator Members

        public object Current
        {
            get
            {
                if ((m_location < 0) || (m_location > m_TimesRef.m_TimeList.Count))
                {
                    return null;
                }
                else
                {
                    return m_TimesRef.m_TimeList[m_location];
                }

            }
        }

        public bool MoveNext()
        {
            m_location++;
            return (m_location <= (m_TimesRef.m_TimeList.Count - 1));
        }

        public void Reset()
        {
            m_location = -1;
        }

        #endregion
    }
}
