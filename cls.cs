using System.IO; 

namespace Notepad_DZ
{
    class CRUD  // creat read update delete okay !! 
    {
        //failds !! 
        public static string ttext { get; set; } = null;
        public static bool answer { get; set; } = true;
        public static bool isaved { get; set; } = true;
        public static bool autosave { get; set; } = false;
        public static string path { get; set; } = null; 
        public static string name()=>   path?.Substring(path.LastIndexOf("\\") + 1)??"Untitled" + "  Notepad DZ";
       
        //function !!
      
        public static string Read()
        {
            var read = new StreamReader(path);
            string temp = read.ReadToEnd();
            read.Close();
            return temp; 
        } 
        public static void Update( string text)
        {
           if (File.Exists(path))  File.Delete(path);
           temp(text);  
        }
        public static void temp(string text)
        {
            try
            {
                Creat();
                var write = new StreamWriter(path);
                write.Write(text);
                write.Close();
            }
            catch
            {
                // i don't Care  
            }

        }
        public static void Creat()
        {
            try
            {
                var file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                file.Close();
            }
            catch
            {
                // if he stop here i don't care 
            }
        }
    }
}
