namespace ButtonSolver;

public class DisplayButtonColor
{
    public List<string> colors = new List<string> { "blue", "red", "orange", "yellow" };

    public string Run()
    {
        string ButtonColor = colors[0];

        colors.RemoveAt(0);

        colors.Add(ButtonColor);



        return ButtonColor;
    }


}