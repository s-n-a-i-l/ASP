using Microsoft.AspNetCore.Components;

namespace TODOlist.Components.Pages
{
    public partial class Converter
    {
        string inputValue = "";
        string result = "";
        string errorMessage = "";
        string fromBase = "10";
        string toBase = "16";

        private bool isInvalidInput => string.IsNullOrWhiteSpace(inputValue);

        private void ConvertTo()
        {
            errorMessage = "";
            result = "";

            try
            {
                int from = int.Parse(fromBase);
                int to = int.Parse(toBase);

                long inputNum;
                if (from == 10) inputNum = long.Parse(inputValue);
                else if (from == 2) inputNum = Convert.ToInt64(inputValue, 2);
                else if (from == 16) inputNum = Convert.ToInt64(inputValue, 16);
                else throw new ArgumentException("Неподдерживаемая система счисления");

                if (to == 10) result = inputNum.ToString();
                else if (to == 2) result = Convert.ToString(inputNum, 2);
                else if (to == 16) result = Convert.ToString(inputNum, 16).ToUpper();
                else throw new ArgumentException("Неподдерживаемая система счисления");
            }
            catch (Exception ex)
            {
                errorMessage = $"Ошибка: {ex.Message}";
            }
        }
    }
}
