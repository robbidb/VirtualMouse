using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualMouse.Utility
{
    /// <summary>
    /// Configuration data
    /// 
    /// Use :
    ///     // [Variable Definition]
    ///     MouseData _o = null;
    /// 
    ///     // [Variable Instance]
    ///     _o = new MouseData();
    ///
    ///     // [File Load]
    ///     _o = _o.XMLDSerialize("C:\config.xml");
    /// 
    ///     // [File Write]
    ///     _o.XMLSerialize("C:\config.xml", _o);
    /// 
    /// </summary>
    [Serializable]
    public class MouseData
    {
        #region --- Variables -----------------------------------------------------------------------------------------
        // Interval beetwen two click
        public int INTERVAL_hours = 0;
        public int INTERVAL_mins = 0;
        public int INTERVAL_secs = 0;
        public int INTERVAL_millis = 0;
        public int INTERVAL_value = 0;
 
        // Click Repeat
        public int  REPEAT_value    = 0;
        public bool REPEAT_infinity = false;
        public int  REPEAT_cnt = 0;

        // Click Options
        public int  TYPE_value = 0;
        public bool TYPE_doubleclick = false;

        /// <summary></summary>
        public struct Item
        {
            /// <summary></summary>
            public Point p;
        }

        /// <summary>Lista Info</summary>
        public List<Item> PointsList = new List<Item>(new Item[] {
        });

        #endregion

        #region --- Methods -------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor
        /// </summary>
        public MouseData()
        {
        }

        #region [SERIALIZATION]
        /// <summary>
        /// Serialize object
        /// </summary>
        /// <param name="filename">File name to write</param>
        /// <param name="o">Class instance</param>
        public void XMLSerialize(String filename, MouseData o)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;

            serializer = new XmlSerializer(typeof(MouseData));
            stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            serializer.Serialize(stream, o);
            if (stream != null)
                stream.Close();
        }

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <param name="filename">File Name to read</param>
        public MouseData XMLDSerialize(String filename)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;
            try
            {
                MouseData o = new MouseData();
                serializer = new XmlSerializer(typeof(MouseData));
                stream = new FileStream(filename, FileMode.Open);
                o = (MouseData)serializer.Deserialize(stream);
                if (stream != null)
                    stream.Close();
                return o;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reading file :  " + filename + Environment.NewLine + "Error : " + ex.Message, "Config File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion
        #endregion
    }
}