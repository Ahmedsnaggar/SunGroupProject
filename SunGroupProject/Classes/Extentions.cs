namespace SunGroupProject.Classes
{
    public static class Extentions
    {
        public static string UpperStr(this string str)
        {
            return str.ToUpper();
        }
        public static bool IsNumber(this int i, string str, out int s)
        {
            if(int.TryParse(str,out s))
            {
               return  true;
            }
            else
            {
                return false;
            }
        }
        public static string formatdate(this DateTime dt) 
        {
            return dt.ToString("dd/MM/yyyy");
        }
    }
}
