namespace Demo.Extension
{
    public static class StringExtensions
    {
        public static string ToCsvField(this string input)
        {
            try
            {
                // Escape double quotes within the field
                string escapedField = input.Replace("\"", "\"\"");

                // Enclose the field in double quotes if it contains special characters
                if (escapedField.Contains(",") || escapedField.Contains("\"") || escapedField.Contains("\n"))
                {
                    escapedField = "\"" + escapedField + "\"";
                }

                return escapedField;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string StringUnescape(this string input)
        {
            return System.Text.RegularExpressions.Regex.Unescape(input);
        }
    }
}
