namespace NSLPWasm.Helpers
{
    public class StringHelper
    {
        public static string ValidateNull(string str)
        {
            if (str == null) return "";
            else return str.ToUpper().Trim();
        }
    }
}
