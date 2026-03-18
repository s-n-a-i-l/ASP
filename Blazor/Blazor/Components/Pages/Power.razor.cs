namespace Blazor.Components.Pages
{
    public partial class Power
    {
        private double baseNum;
        private double exponent;
        private double result = 1;
        private List<double> steps = new();

        private void OnBaseChanged()
        {
            Calculate();
        }

        private void OnExponentChanged()
        {
            Calculate();
        }

        private void Calculate()
        {
            result = 1;
            steps.Clear();

            if (exponent < 0 || baseNum == 0) return;

            for (int i = 1; i <= (int)exponent; i++)
            {
                result *= baseNum;
                steps.Add(result);
            }
        }
    }
}
