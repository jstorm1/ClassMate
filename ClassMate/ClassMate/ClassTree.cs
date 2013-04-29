using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMate
{
    [Serializable]
    /// <summary>
    ///  A Tree of assignments, class times, and class types. 
    /// </summary>
    public class ClassTree
    {
        #region ClassTree Properties
        public string ClassTitle;
        public ClassTimes ClassTreeTimes;
        public ClassAssignments ClassTreeAssignments;
        public string ClassLocation;
        public string ClassWebSite;
        public string ClassCreditHours;
        public string ClassTeacher;
        public string ClassTeacherOffice;
        public string ClassTeacherOfficeHours;
        public string ClassTeacherEmail;
        public string ClassTeacherPhone;
        public string ClassNote;
        #endregion
       
        public ClassTree()
        {
        
        }
        
        public ClassTree(string title, ClassTimes classTimes, ClassAssignments classAssignments, 
            string location, string webSite, string creditHours, string teacher, string teacherOffice,
            string officeHours, string teacherEmail, string teacherPhone, string classNote)
        {
            ClassTitle = title;
            ClassTreeTimes = classTimes;
            ClassTreeAssignments = classAssignments;
            ClassLocation = location;
            ClassWebSite = webSite;
            ClassCreditHours = creditHours;
            ClassTeacher = teacher;
            ClassTeacherOffice = teacherOffice;
            ClassTeacherOfficeHours = officeHours;
            ClassTeacherEmail = teacherEmail;
            ClassTeacherPhone = teacherPhone;
            ClassNote = classNote;
        }

        public override string ToString()
        {
            return ClassTitle;
        }
    }
}
