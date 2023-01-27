namespace MvcTask1.Models
{
    public class sampledata
    {
        private static List<Party> attends = new List<Party>()
        {
            new Party(){name="Ahmed" ,email="ahmed@gmail.com", phone=0120076 ,attend="yes"},
             new Party(){name="Adel" ,email="Adel@gmail.com", phone=01555133 ,attend="no"},
              new Party(){name="Mai" ,email="Mai@gmail.com", phone=018975133 ,attend="no"}
        };
        public static List<Party> Attends { get => attends; }

        public static void Add(Party p)
        {
            attends.Add(p);

        }
    }
}
