namespace TimeTraveler
{
    public class TimerConverter
    {
        public string TimeUnit1 { get; set; }
        public string TimeUnit2 { get; set; }
        public double Request { get; set; }
        public double Result { get; set; }

        public double Convert
        {
            get
            {
                switch (TimeUnit1)
                {
                    case "Days":
                        switch (TimeUnit2)
                        {
                            case "Days":
                                Result = Request;
                                break;
                            case "Hours":
                                Result = Request * 24;
                                break;
                            case "Minutes":
                                Result = Request * 1440;
                                break;
                            case "Seconds":
                                Result = Request * 86400;
                                break;
                        }
                        break;

                    case "Hours":
                        switch (TimeUnit2)
                        {
                            case "Days":
                                Result = Request / 24;
                                break;
                            case "Hours":
                                Result = Request;
                                break;
                            case "Minutes":
                                Result = Request * 60;
                                break;
                            case "Seconds":
                                Result = Request * 3600;
                                break;
                        }
                        break;

                    case "Minutes":
                        switch (TimeUnit2)
                        {
                            case "Days":
                                Result = Request / 1440;
                                break;
                            case "Hours":
                                Result = Request / 60;
                                break;
                            case "Minutes":
                                Result = Request;
                                break;
                            case "Seconds":
                                Result = Request * 60;
                                break;
                        }
                        break;

                    case "Seconds":
                        switch (TimeUnit2)
                        {
                            case "Days":
                                Result = Request / 86400;
                                break;
                            case "Hours":
                                Result = Request / 3600;
                                break;
                            case "Minutes":
                                Result = Request / 60;
                                break;
                            case "Seconds":
                                Result = Request;
                                break;
                        }
                        break;
                }

                return Result;
            }

        }
    }
}