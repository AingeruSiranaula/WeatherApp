namespace WeatherApp.Utilities
{
    public class WeatherCode
    {
        public static string Convert(int code)
        {
            switch (code)
            {
                case 0:
                    return "Clear Sky";
                    break;

                case 1:
                    return "Mainly clear";
                    break;

                case 2:
                    return "Partly cloudy";
                    break;

                case 3:
                    return "Overcast";
                    break;

                case 4:
                    return "Thunderstorm with slight and heavy hail";
                    break;

                default:
                    return "Unknown";
            }
        }
    }
}
