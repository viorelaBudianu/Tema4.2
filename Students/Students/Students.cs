namespace Students
{
    class Students : Humans
    {
        public double Grade { get; set; }
        
        public Students(string Nume,string Prenume,double Nota):base("Nume","Prenume")
        {
            base.FirstName=Prenume;
            base.LastName=Nume;
            this.Grade = Nota;
        }
    }
}
