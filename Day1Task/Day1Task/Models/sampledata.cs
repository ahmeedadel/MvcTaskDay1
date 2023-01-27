namespace Day1Task.Models
{
    public class sampledata
    {
        private static List<Party> attends = new List<Party>()
        {
            new Party(){name="Ahmed" ,email="ahmed@gmail.com", phone=0100076 ,attend="yes"},
             new Party(){name="Adel" ,email="Adel@gmail.com", phone=01155133 ,attend="no"},
              new Party(){name="Mai" ,email="mai@gmail.com", phone=012975133 ,attend="yes"}
        };
        public static List<Party> Attends { get => attends; }

        public static void Add(Party p)
        {
            attends.Add(p);

        }
    }
}
