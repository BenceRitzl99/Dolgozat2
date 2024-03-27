namespace ClassLibrary1.Models
{
    public class Class
    {


        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Epulet { get; set; }
        public string Iszam { get; set; }
        public string Pozicio { get; set; }


        public Class()
        {

        }
        public Class(string sor)
        {
            string[] t = sor.Split(";");

            Nev = t[0];
            Kor = Convert.ToInt32(t[1]);
            Epulet = t[2];
            Iszam = t[3];
            Pozicio = t[4];
        }
        public override string? ToString()
        {
            return $"A nevem{Nev}, {Kor} éves vagyok, a(z) {Epulet}-ban/ben lakom," +
                $" irányítószámom: {Iszam} és {Pozicio}ként keresem a kenyerem.";
        }
    }
}
