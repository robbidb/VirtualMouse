namespace VirtualMouse.Utility
{
    class SwVersion
    {
        public string getVersion()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            return s;
        }

        public string getName()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return s;
        }
    }
}
