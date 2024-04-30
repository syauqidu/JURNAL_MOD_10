namespace modul10_1302220112
{
    public class Mahasiswa
    {
        public string name {  get; set; }
        public string nim {  get; set; }
        public List<string> course { get; set; }
        public int year { get; set; }

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            this.name = name;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }
    }
}
