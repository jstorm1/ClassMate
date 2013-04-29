using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassMate
{
    class DatabaseClass
    {

        #region Database functions

        /// <summary>
        /// Static method to create or update a class file.
        /// </summary>
        /// <param name="classPass">ClassTree object passed to be saved</param>
        /// <param name="fileName">Name of class file to write to</param>
        public static void CreateClass(ClassTree classPass, string fileName)
        {

            string streamFile = ClassMate.Properties.Settings.Default.SavePath + "\\" + fileName + ".cls";

            try
            {
                Stream stream = File.Open(streamFile, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, classPass);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Static method to read a class file in.
        /// </summary>
        /// <param name="fileName">Name of class file to read in</param>
        public static ClassTree ReadClass(string fileName)
        {
            ClassTree classTree = new ClassTree();

            string streamFile = fileName;
            try
            {
                Stream stream = File.Open(streamFile, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                while (stream.Position < stream.Length)
                {
                    classTree = (ClassTree)bFormatter.Deserialize(stream);
                }

                stream.Close();

                return classTree;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return classTree;
        }

        #endregion
    }
}
